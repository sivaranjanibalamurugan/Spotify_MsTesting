using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using System;
using System.Net;

namespace SpotifyTestProject
{
    [TestClass]
    public class TestGetEndPoint
    {
        private string myToken = " Bearer BQABwlUQqPNQ6FD5YBLPzoAm83BjleypFRun86L78MY5v113ziazHKu_HqzVy0wjQhxkA737JD-jMEBhGcJk4fDGJO_zMDFqr6ps8IGKZoGmN86YphN_KcdeO_V4rs4exANjURrJ213K0X7Ga_6IziicNuWK7Ud4_nfYDTxS4qJUooB-Cyb-9vS4JzQYdCmqIIFaTIM8yOn4oMuddvqC3WnodOmqtzRlx93mrklfb2zv9tZGxT1qljwvG4KfucG0Bh8yULe4wbBYODgf1oU6QCEl3gH0GYn3vGl_ueNC";
        private string getUrl = "https://api.spotify.com/v1/me";
        private static IRestResponse restResponse { get; set; }
        [TestMethod]
        public void TestGetUsingRestSharp()
        {
            IRestClient restClient = new RestClient();
            IRestRequest restRequest = new RestRequest(getUrl);

            restRequest.AddHeader("Authorization", "token" + myToken);
            restResponse = restClient.Get(restRequest);
            Assert.AreEqual(HttpStatusCode.OK, restResponse.StatusCode);

            if(restResponse.IsSuccessful)
            {
                Console.WriteLine("Status Code:" + restResponse.StatusCode);
                Console.WriteLine("Response: " + restResponse.Content);
            }
            Console.WriteLine(restResponse.ErrorMessage);
            Console.WriteLine(restResponse.ErrorException);
        }
    }
}
