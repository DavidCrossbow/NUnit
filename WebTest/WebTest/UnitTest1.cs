using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;
using System.Data.Common;
using System.Linq;
using System.Runtime.InteropServices;

namespace WebTest
{
    public class Tests
    {
        Response dsrz;
        object status;

        [OneTimeSetUp]
        public void Setup()
        {

            var client = new RestClient("https://disease.sh/v2/continents");
            var request = new RestRequest("Oceania");
            request.Method = Method.GET;
            request.AddHeader("Accept", "application/json");
            var j = client.Execute(request);
            dsrz = JsonConvert.DeserializeObject<Response>(j.Content);
            status = j.StatusCode;
        }
        
        [Test]
        public void Test1()
        {
            Assert.Greater(int.Parse(dsrz.Cases), 0);
            // Проверка, что количество случаев заражения не отрицательное число
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual("Oceania",dsrz.Continent);
            // Проверка названия континента 
        }

        [Test]
        public void Test3()
        {
            Assert.IsTrue(dsrz.Countries.Count > 0);
            // Количество стран на континенте - натуральное число
        }

        [Test]
        public void Test4()
        {
            Assert.AreEqual(status, System.Net.HttpStatusCode.OK);
        }

        [Test]
        public void Test5()
        {
            Assert.That(dsrz.Countries, Has.Member("Australia"));
            // Среди стран присутствует Австралия
        }
    }
}