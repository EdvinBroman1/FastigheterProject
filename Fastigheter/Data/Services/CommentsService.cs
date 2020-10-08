using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Sockets;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;
using Newtonsoft.Json;
using TeamRedzFastigheter.Shared.Models.RealEstateModel;
using TeamRedzFastigheter.Shared.Models.CommentModel;
using TeamRedzFastigheter.Shared.Enitites;
using System.Text;
using System.Net.Http.Headers;

namespace Fastigheter.Data.Services
{
    [Authorize]
    public class CommentsService
    {
        private const string _ApiUrlBase = "http://localhost:5000/api/comments/";
        private readonly HttpClient _httpClient;
        //private string sUrl = _ApiUrlBase + "api/comments/";
        public CommentsService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<CommentDto>> GetComments(int RealEstateId,string token)
        {
            IEnumerable<CommentDto> Comments;
            /*Uri uri = new Uri(_ApiUrlBase+RealEstateId);
            var requestMessage = new HttpRequestMessage();
            requestMessage.Method = HttpMethod.Get;
            requestMessage.RequestUri = uri;
            requestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
            */
            HttpRequestMessage requestMessage = GetRequestMessage(RealEstateId.ToString(),token);

            try
            {
                var response = await _httpClient.SendAsync(requestMessage);
                string responseToString = await response.Content.ReadAsStringAsync();
                Comments = JsonConvert.DeserializeObject<IEnumerable<CommentDto>>(responseToString);

                return Comments;
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

        public async Task<CommentDto> CreateComment(string RealEstateId, CommentDto comment,int token)
        {
            string sUrl = _ApiUrlBase + "api/comments/" + RealEstateId;
            var response =await _httpClient.GetAsync(sUrl);
            var json = await response.Content.ReadAsStringAsync();


            return null;
        }

        private HttpRequestMessage GetRequestMessage(string value, string token)
        {
            Uri uri = new Uri(_ApiUrlBase + value);
            var requestMessage = new HttpRequestMessage();
            requestMessage.Method = HttpMethod.Get;
            requestMessage.RequestUri = uri;
            requestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
            return requestMessage;
        }
    }
}