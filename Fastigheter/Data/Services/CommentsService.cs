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
        private string _ApiUrlBase = "http://localhost:5000/api/comments/";
        private readonly HttpClient _httpClient;
        public CommentsService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<CommentDto>> GetComments(int RealEstateId,string token)
        {
            IEnumerable<CommentDto> Comments;
            HttpRequestMessage requestMessage = GetRequestMessage(RealEstateId.ToString(), token);
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

        public async Task<bool> CreateComment(Comment comment,string token,int RealEstateId)
        {
            _ApiUrlBase = "http://localhost:5000/api/comments/";
            string sUrl = _ApiUrlBase;
            string commentJson = JsonConvert.SerializeObject(comment);

            var stringContent = new StringContent(commentJson, Encoding.UTF8, "application/json");
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var response = await _httpClient.PostAsync(sUrl, stringContent);
            return true;
        }

        private Task InvokeAsync(Action p)
        {
            throw new NotImplementedException();
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