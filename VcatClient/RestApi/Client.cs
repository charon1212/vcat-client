using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace VcatClient.RestApi
{
    public static class Client
    {
        static HttpClient client;
        private static readonly string baseUrl = "https://goauviv6u0.execute-api.ap-northeast-1.amazonaws.com/prod/vcat/v1";
        static Client()
        {
            client = new HttpClient();
        }
        
        private static async Task<HttpResponseMessage> getRequest(string uri, string productId)
        {
            var url = baseUrl + "/" + productId + "/" + uri;
            var result = await client.GetAsync(url);
            return result;
        }
        public static async Task<JObject> sendGetRequest(string uri, string productId)
        {
            var result = await getRequest(uri, productId);
            if (result.StatusCode != System.Net.HttpStatusCode.OK)
            {
                return null;
            }
            var jsonStr = await result.Content.ReadAsStringAsync();
            JObject json2 = JObject.Parse(jsonStr);
            return json2;
        }

        public static async Task<HttpResponseMessage> patchRequest(string uri, string productId, string body)
        {
            var url = baseUrl + "/" + productId + "/" + uri;
            var message = new HttpRequestMessage(new HttpMethod("PATCH"), url);
            message.Content = new StringContent(body);

            var result = await client.SendAsync(message);
            return result;
        }
        public static async Task<HttpResponseMessage> patchRequest(string uri, string productId, JObject body)
        {
            var bodyStr = JsonConvert.SerializeObject(body, Formatting.None);
            var request = await patchRequest(uri, productId, bodyStr);
            return request;
        }
    }
}
