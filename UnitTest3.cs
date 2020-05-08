using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;

namespace NUnitTestProject3
{
    public class Tests
    {
      
        [Test]
        public void Test1()
        {
            var client = new RestClient("https://disease.sh/v2/apple/countries/Russia");
            var request = new RestRequest();
            request.Method = Method.GET;
            request.AddHeader("Accept", "application/json");
            var b = client.Execute(request);
            var jsonResponse = JsonConvert.DeserializeObject(b.Content);
            Assert.IsNotNull(b.Content == "Moscow", "Saint Petersburg - Russia", "all");
        }

        [Test]
        public void Test2()
        {
            var client = new RestClient("https://disease.sh/v2/apple/countries/Russia/Moscow");
            var request = new RestRequest();
            request.Method = Method.GET;
            request.AddHeader("Accept", "application/json");
            var d = client.Execute(request);
            var jsonResponse = JsonConvert.DeserializeObject(d.Content);
            Assert.IsTrue(d.StatusCode == System.Net.HttpStatusCode.OK);
        }

    }
}