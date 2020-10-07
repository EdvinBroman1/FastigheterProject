using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Sockets;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;
using Newtonsoft.Json;
using TeamRedzFastigheter.Shared.Models.RealEstateModel;
using Fastigheter.Data;
using System.Net.Http.Headers;
using System.Text;

namespace Fastigheter.Data.Services
{
    [Authorize]
    public class RealEstateService
    {
        private const string _ApiUrlBase = "http://localhost:5000/";
        private readonly HttpClient _httpClient;
        public RealEstateService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<RealEstateDto> GetRealEstateDetailAsync(int id)
        {
            RealEstateDto realEstate;
            string sUrl = _ApiUrlBase + "api/RealEstates/" + id;
            try
            {
                string response = await _httpClient.GetStringAsync(sUrl);
                realEstate = JsonConvert.DeserializeObject<RealEstateDto>(response);
                return realEstate;
            }
            catch (SocketException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {

            }

            return null;
        }


        public async Task<RealEstateDto[]> GetRealEstatesByUserName(string username)
        {
            RealEstateDto[] realEstates;
            string sUrl = _ApiUrlBase + $"api/RealEstates/byuser/"+username;
            string respons = await _httpClient.GetStringAsync(sUrl);

                if (respons != null)
                {
                    realEstates = JsonConvert.DeserializeObject<RealEstateDto[]>(respons);
                    return realEstates;
                }
            return null;
            
        }

        public async Task <RealEstateDto[]> GetRealEstates() 
        {
            RealEstateDto[] realEstates;
            string sUrl = _ApiUrlBase + $"api/RealEstates";
            try
            {     
                string respons = await _httpClient.GetStringAsync(sUrl);

                if (respons != null)
                {
                    realEstates = JsonConvert.DeserializeObject<RealEstateDto[]>(respons);
                    return realEstates;
                }
            }
            catch (SocketException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {

            }

            return null;
        }

        public async Task<RealEstateDto[]> GetRealEstateAsync()
        {

            RealEstateDto[] realEstates;
            string sUrl = _ApiUrlBase + "api/RealEstates";

            try
            {
                string respons = await _httpClient.GetStringAsync(sUrl);
                if (respons != null)
                {
                    realEstates = JsonConvert.DeserializeObject<RealEstateDto[]>(respons);
                    return realEstates;
                }
            }
            catch (SocketException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {

            }
            return null;

        }

        public async Task<bool> CreateRealestate(int userid, RealEstateDto realestate, string token)
        {
            string sUrl = _ApiUrlBase + $"api/RealEstates";

            string RealEstateJson = JsonConvert.SerializeObject(realestate);

             var stringContent = new StringContent(RealEstateJson, Encoding.UTF8, "application/json");
        
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var response = await _httpClient.PostAsync(sUrl, stringContent);
            return true;
        }
    }
}
