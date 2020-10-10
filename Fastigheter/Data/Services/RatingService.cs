using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Reflection;
using TeamRedzFastigheter.Shared.Enitites;
using TeamRedzFastigheter.Shared.Models.UserModel;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Net.Http.Headers;

namespace Fastigheter.Data.Services
{
    public class RatingService
    {
        private readonly int[] PointRaingList = {1,2,3,4,5};
        private string _ApiUrlBase = "http://localhost:5000";
        private HttpClient httpClient;

        public RatingService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public int [] Points   
        {
            get { return PointRaingList; }
        }
        public async Task<bool> UpdateRating(Rating rating, string token)
        {
            string sUrl = _ApiUrlBase + "/api/Users/Rate";
            string toJson = JsonConvert.SerializeObject(rating);
            var stringContet = new StringContent(toJson,Encoding.UTF8,"application/json");
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer",token);
            var response = await httpClient.PutAsync(sUrl, stringContet);
            Console.WriteLine("Response content: ");
            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }
    }
}
