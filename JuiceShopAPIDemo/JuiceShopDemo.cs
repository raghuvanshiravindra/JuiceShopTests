using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuiceShopAPIDemo
{
    public class JuiceShopDemo
    {
        public ListOfJuicesDTO GetJuices()
        {
            var restClient = new RestClient("https://juice-shop.herokuapp.com");
            var restRequest = new RestRequest("/rest/products/search?q=", Method.Get);
            restRequest.AddHeader("Accept", "application/json, text/plain, */*");
            restRequest.RequestFormat = DataFormat.Json;

            RestResponse response = restClient.Execute(restRequest);
            var content = response.Content;

            var juices = JsonConvert.DeserializeObject<ListOfJuicesDTO>(content);
            return juices;
        }
    }
}
