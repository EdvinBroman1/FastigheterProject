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
using System.Net.Http.Headers;

namespace Fastigheter.Data.Services
{
    [Authorize]
    public class CommentsService
    {
        private const string _ApiUrlBase = "http://localhost:5000/";
        private readonly HttpClient _httpClient;
        public CommentsService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<CommentDto>> GetComments(int RealEstateId, string token)
        {

            IEnumerable<CommentDto> Comments;
            string sUrl = _ApiUrlBase + "api/comments/" + RealEstateId;
            Uri uri = new Uri(sUrl);
            var requestMessage = new HttpRequestMessage();
            requestMessage.Method = HttpMethod.Get;
            requestMessage.RequestUri = uri;
            requestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);


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
    }
}
