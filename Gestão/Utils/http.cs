using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Gestão.Utils
{
    public class http
    {
        private readonly RestClient _client;
        public http(string controller)
        {
            _client = new RestClient(Constants.baseUrl + controller);
        }

        public async Task<T> GetAsync<T>(string url, string? token) where T : class
        {
            var request = new RestRequest(url, Method.Get);

            if (!string.IsNullOrEmpty(token))
            {
                request.AddHeader("Authorization", $"Bearer {token}");
            }
            var response = await _client.GetAsync<T>(request);
            return response;
        }

        public async Task<T> PostAsync<T>(string url, string? token, object body) where T : class
        {
            var request = new RestRequest(url, Method.Post);
            if (!string.IsNullOrEmpty(token))
            {
                request.AddHeader("Authorization", $"Bearer {token}");
            }
            request.AddJsonBody(body);
            var response = await _client.PostAsync<T>(request);
            return response;
        }

        public async Task<T> UpdateAsync<T>(string url, string? token) where T : class
        {
            var request = new RestRequest(url, Method.Put);
            if (!string.IsNullOrEmpty(token))
            {
                request.AddHeader("Authorization", $"Bearer {token}");
            }
            var response = await _client.PostAsync<T>(request);
            return response;
        }
        
    }
}
