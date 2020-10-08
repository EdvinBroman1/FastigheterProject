using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Fastigheter.Data.Services
{
    public class TokenService
    {
        private readonly HttpClient _httpClient;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private const string _ApiUrlBase = "http://localhost:5000/token";
        private Task<AuthenticationState> AuthState { get; set; }

        public TokenService(HttpClient httpClient, IHttpContextAccessor httpContextAccessor)
        {
            _httpClient = httpClient ??
            throw new System.ArgumentNullException(nameof(httpClient));
            _httpContextAccessor = httpContextAccessor ??
            throw new System.ArgumentNullException(nameof(httpContextAccessor));
        }

        public async Task<string> GetTokenAsync(string userName, string Password)
        {
            string str = string.Empty;
            var values = new Dictionary<string, string>
              {
               { "username", userName },
               { "password", Password }
            };
            string json = JsonConvert.SerializeObject(values);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync(_ApiUrlBase, httpContent);
            str = await response.Content.ReadAsStringAsync();
            return str;

        }

    }
}
