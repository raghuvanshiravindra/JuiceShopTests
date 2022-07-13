using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace JuiceShopAPIDemo
{
    public class APIHelper<T>
    {
        public RestClient restClient;
        public RestRequest restRequest;
        public string baseUrl = "https://juice-shop.herokuapp.com/";

        public RestClient SetUrl(string endpoint)
        {
            var url =Path.Combine(baseUrl, endpoint);
            var restClient = new RestClient(url);
            return restClient;
        }

        

        public class AccessToken
        {
            public void GetNewAccessToken()
            {
                Tokens localTokens = new Tokens();

                var client = new RestClient("https://juice-shop.herokuapp.com/api/token");
                var request = new RestRequest("Feedbacks/", Method.Post);
                request.AddHeader("content-type", "application/x-www-form-urlencoded");
                request.AddParameter("application/x-www-form-urlencoded", "grant_type=refresh_token&refresh_token=" + localTokens.refresh_token, ParameterType.RequestBody);
                RestResponse response = client.Execute(request);
                var data = response.Content;
                var responseContent = response.Content;

                var newTokensList = new JavaScriptSerializer().Deserialize<Tokens>(responseContent);

                localTokens.access_token = newTokensList.access_token;
                localTokens.refresh_token = newTokensList.refresh_token;
            }
        }

        public RestRequest CreatePostRequest(string payload)
        {

            Tokens tokens = new Tokens(); 
            var restRequest = new RestRequest("Feedbacks/", Method.Post);
            restRequest.AddHeader("Accept", "application/json, text/plain, */*");
            restRequest.AddHeader("Authorization", "Bearer " + tokens.access_token);            
            return restRequest;
        }
        
        public RestRequest CreateGetRequest()
        {
            var restRequest = new RestRequest("GET",Method.Get);
            restRequest.AddHeader("Accept", "application/json");
            restRequest.AddHeader("Postman-Token", "<calculated when request is sent>");
            return restRequest;
        }

        public RestResponse GetResponse(RestClient client, RestRequest request)
        {
            return client.Execute(request);
        }

        public DTO GetContent<DTO>(RestResponse response)
        {
            var content = response.Content;
            DTO dtoObject = JsonConvert.DeserializeObject<DTO>(content);
            return dtoObject;
        }
    }
}
