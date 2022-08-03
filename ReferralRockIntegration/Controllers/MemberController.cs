using Microsoft.AspNetCore.Mvc;
using ReferralRockIntegration.Dtos;
using ReferralRockIntegration.Models;
using System.Text.Json;

namespace ReferralRockIntegration.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MemberController
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public MemberController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        [Route("getmembersasync")]
        public async Task<Members> GetMembersAsync()
        {
            var client = _httpClientFactory.CreateClient("ReferralRock");
            var response = await client.GetAsync("Members");

            var json = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<Members>(
                json,
                options: new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                }) ?? new Members();
        }

            [HttpGet]
        [Route("getreferralsasync")]
        public async Task<Referrals> GetReferralsAsync(string memberId)
        {
            var client = _httpClientFactory.CreateClient("ReferralRock");
            var response = await client.GetAsync($"Referrals?memberId={memberId}");

            var json = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<Referrals>(
                json,
                options: new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                }) ?? new Referrals();
        }

        [HttpPost]
        [Route("savereferralasync")]
        public async Task SaveReferralAsync(NewReferralRequest request)
        {
            var amount = double.Parse(request.Amount);
            var newReferral = new NewReferral(
                referralCode: request.ReferralCode,
                firstName: request.FirstName,
                lastName: request.LastName,
                email: request.Email,
                phoneNumber: request.Phone,
                amount: amount,
                status: request.IsApproved ? "approved" : "pending");

            var content = JsonContent.Create(newReferral);
            var message = new HttpRequestMessage(
                HttpMethod.Post,
                "Referrals")
            {
                Content = content
            };

            var client = _httpClientFactory.CreateClient("ReferralRock");
            await client.SendAsync(message);
        }

        [HttpPost]
        [Route("updatereferralasync")]
        public async Task UpdateReferralAsync(EditReferralRequest request)
        {
            var updateRequest =  new UpdateReferralRequest();
            updateRequest.Query.PrimaryInfo.ReferralId = request.ReferralId;
            updateRequest.Query.SecondaryInfo.PhoneNumber = request.Phone;
            updateRequest.Query.SecondaryInfo.Email = request.Email;
            updateRequest.Referral.FirstName = request.FirstName;
            updateRequest.Referral.LastName = request.LastName;
            updateRequest.Referral.Email = request.Email;
            updateRequest.Referral.PhoneNumber = request.Phone;
            updateRequest.Referral.Amount = 1;

            var requestArr = new UpdateReferralRequest[] { updateRequest };
            var content = JsonContent.Create(requestArr);
            var message = new HttpRequestMessage(
                HttpMethod.Post,
                "referral/update")
            {
                Content = content
            };

            var client = _httpClientFactory.CreateClient("ReferralRock");
            await client.SendAsync(message);
        }

        [HttpPost]
        [Route("removereferralasync")]
        public async Task RemoveReferralAsync(RemoveReferralRequest request)
        {
            var req = new RemoveQuery
            {
                Query = new Query
                {
                    PrimaryInfo = new PrimaryInfo
                    {
                        ReferralId = request.ReferralId
                    }
                }
            };

            var reqArr = new RemoveQuery[] { req };
            var content = JsonContent.Create(reqArr);
            var message = new HttpRequestMessage(
                HttpMethod.Post,
                "referral/remove")
            {
                Content = content
            };

            var client = _httpClientFactory.CreateClient("ReferralRock");
            await client.SendAsync(message);
        }
    }
}
