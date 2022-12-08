using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using BDD_KnabUIAndAPI.Shared;


namespace BDD_KnabUIAndAPI.Steps
{
    [Binding]
    public sealed class TrelloApisStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        public RestClient SetupClient()
        {
            // Setup the Client. 
            RestClient client = new RestClient("https://api.trello.com/1");
            return client;
        }

        public RestRequest SetupRequest(string url, Method method)
        {
            // Setup the Request.
            // The added parameters are credentials that are needed to reach the specific boards on the account.
            // The token and key can be acquired at https://trello.com/app-key/ 

            RestRequest request = new RestRequest(url);
            request.Method = method;
            request.AddParameter("key", TestData.APIKey, ParameterType.QueryString);
            request.AddParameter("token", TestData.API_Token, ParameterType.QueryString);

            return request;
        }

        public TrelloApisStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"the ""(.*)"" of the user")]
        public void GivenTheOfTheUser(string id)
        {
           
        }

        [When(@"the get method is posted for this ""(.*)""")]
        public void WhenTheGetMethodIsPostedForThis(string id)
        {
            RestClient client = SetupClient();
            RestRequest request = SetupRequest("actions/{id}", Method.Get);
            RestResponse response = client.Execute(request);
            Console.Write(response);
            //Assert.AreEqual("OK", response.StatusDescription, "Status code is not OK");
        }


        [Then(@"the response of the API should fetch the details of the member")]
        public void ThenTheResponseOfTheAPIShouldFetchTheDetailsOfTheMember()
        {
            
        }

      


    }
}
