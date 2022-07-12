using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public RestRequest CreatePostRequest(string payload)
        {
            var restRequest = new RestRequest("Feedbacks/", Method.Post);
            restRequest.AddHeader("Accept", "application/json, text/plain, */*");
            restRequest.AddHeader("Authorization", "Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiJ9.eyJzdGF0dXMiOiJzdWNjZXNzIiwiZGF0YSI6eyJpZCI6NDYxLCJ1c2VybmFtZSI6IiIsImVtYWlsIjoiamVhbm5pbmVzd29ybGRAaG90bWFpbC5jb20iLCJwYXNzd29yZCI6IjYzNjFmYzEwOGVhNGUxYTk1YWQwMjhkMWMwYTdlMzAwIiwicm9sZSI6ImN1c3RvbWVyIiwiZGVsdXhlVG9rZW4iOiIiLCJsYXN0TG9naW5JcCI6IjAuMC4wLjAiLCJwcm9maWxlSW1hZ2UiOiIvYXNzZXRzL3B1YmxpYy9pbWFnZXMvdXBsb2Fkcy9kZWZhdWx0LnN2ZyIsInRvdHBTZWNyZXQiOiIiLCJpc0FjdGl2ZSI6dHJ1ZSwiY3JlYXRlZEF0IjoiMjAyMi0wNy0xMiAxMDoxMjozNy4xNjUgKzAwOjAwIiwidXBkYXRlZEF0IjoiMjAyMi0wNy0xMiAxMDoxMjozNy4xNjUgKzAwOjAwIiwiZGVsZXRlZEF0IjpudWxsfSwiaWF0IjoxNjU3NjIwNzkzLCJleHAiOjE2NTc2Mzg3OTN9.hdV0ppixWtfXHZZsTcUQ_TlQRuJbT97fH9kUgZUsPMFHrl0G9jK8jPJBt9pGuyX976OV9HwKrScHy5aNkiexSfpAVrK7eqoLWD06keV9BNlgepugfELLFL_IqnFe0dSUNaQGdb2BNlvE77tINVq_IsNb23usosTFkT8lfZb3QLA"); restRequest.AddParameter("application/json", payload, ParameterType.RequestBody);
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
