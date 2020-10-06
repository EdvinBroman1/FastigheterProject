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

        public async Task<IEnumerable<CommentDto>> GetComments(int RealEstateId)
        {
            IEnumerable<CommentDto> Comments;
            string sUrl = _ApiUrlBase + "api/comments/" + RealEstateId;
            try
            {
                string response = await _httpClient.GetStringAsync(sUrl);
                Comments = JsonConvert.DeserializeObject<IEnumerable<CommentDto>>(response);
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