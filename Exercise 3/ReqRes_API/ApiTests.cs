using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using RestSharp;

namespace ReqRes_API
{
    public class ApiTests
    {
        private IWebDriver driver;

        public static void Main(string[] args)
        {
            var tests = new ApiTests();
            tests.Setup();
            tests.StatusCodeIs200();
            tests.TotalItemsPerPageIsEqualToPerPageParameterValue();
            tests.InvalidParameterInputIsNotDetected();
        }


        [SetUp]
        public void Setup()
        {
            // Create a new ChromeDriver instance
            //var chromeOptions = new ChromeOptions();
            //chromeOptions.AddArgument("--enable-local-storage");
            //chromeOptions.BinaryLocation = "C:\\Users\\where\\Documents\\GitHub\\ReqRes\\Reqres_API_test\\Exercise 3\\ReqRes_API\\chromedriver.exe";
            driver = new ChromeDriver();
        }

        [Test]
        public void StatusCodeIs200()
        {
            // Make a GET request to the API endpoint
            var client = new RestClient("https://reqres.in");
            var request = new RestRequest("/api/{resource}", Method.Get);
            request.AddUrlSegment("resource", "{resource}");
            var response = client.Execute(request);

            // Assert that the status code is 200
            Assert.AreEqual(200, (int)response.StatusCode);
            //driver.Quit();
        }


        [Test]
        public void TotalItemsPerPageIsEqualToPerPageParameterValue()
        {
            // Make a GET request to the API endpoint
            var client = new RestClient("https://reqres.in");
            var request = new RestRequest("/api/{resource}", Method.Get);
            request.AddUrlSegment("resource", "{resource}");
            var response = client.Execute(request);

            // Parse the response body as JSON
            dynamic json = JsonConvert.DeserializeObject(response.Content);

            // Assert that the total items per page is equal to the per_page parameter value
            Assert.AreEqual(json.data.Count, json.per_page);
            //driver.Quit();
        }

        [Test]
        public void InvalidParameterInputIsNotDetected()
        {
            // Make a GET request to the API endpoint
            var client = new RestClient("https://reqres.in");
            var request = new RestRequest("/api/{resource}", Method.Get);
            request.AddUrlSegment("resource", "{resource}");
            var response = client.Execute(request);

            // Parse the response body as JSON
            dynamic json = JsonConvert.DeserializeObject(response.Content);

            // Assert that the response status code is 200 if the page and per_page parameters are valid, otherwise assert that it is 400
            if (json.page < 0 || json.per_page < 0 || !int.TryParse(json.page.ToString(), out int _page) || !int.TryParse(json.per_page.ToString(), out int _perPage))
            {
                Assert.AreEqual(400, (int)response.StatusCode);
            }
            else
            {
                Assert.AreEqual(200, (int)response.StatusCode);
            }

            //driver.Quit();

        }
    }
}

