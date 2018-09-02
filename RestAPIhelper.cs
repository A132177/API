using System;
using RestSharp;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace API_automation_Test_Suit
{
    public static class RestAPIhelper
    {
        public static RestClient client;
        public static RestRequest restRequest;
        public static string baseUrl = "http://mydomain.com";

        public static RestClient SetUrl(string endpoint)
        {
            var Url = Path.Combine(baseUrl, endpoint);
            return client = new RestClient(Url);
        }

        public static RestRequest CreateRequest()
        {
            restRequest = new RestRequest(Method.GET);
            restRequest.AddHeader("Accept", "application/Json");
            return restRequest;
        }

        public static IRestResponse GetResponse()
        {
            return client.Execute(restRequest);
        }
      
    }
}
