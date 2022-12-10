using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using BDD_KnabUIAndAPI.Shared;
using Xunit;
using Newtonsoft.Json;

namespace BDD_KnabUIAndAPI.Steps
{
    [Binding]
    public class TrelloApisStepDefinitions
    {
        private RestResponse membersBoardResponse = null;



        public RestClient CondigureTrelloApi()
        {
            RestClient trelloApi = new RestClient("https://api.trello.com/1");
            return trelloApi;
        }
        
        public RestRequest ConfigureRequest(String url, Method action)
        {
            RestRequest configureRequest = new RestRequest(url);
            configureRequest.Method = action;
            configureRequest.AddParameter("key", TestData.APIKey);
            configureRequest.AddParameter("token", TestData.API_Token);
            return configureRequest;
        }
        
            
        public TrelloApisStepDefinitions(ScenarioContext scenarioContext)
        {
         
        }

        [Given(@"the ""(.*)"" of the user")]
        public void GivenTheOfTheUser(string id)
        {
          
           
        }

        [When(@"the get method is posted for this ""(.*)""")]
        public void WhenTheGetMethodIsPostedForThis(string id)
        {
           
        }


        [Then(@"the response of the API should fetch the details of the member")]
        public void ThenTheResponseOfTheAPIShouldFetchTheDetailsOfTheMember()
        {
            
        }

        //Scenario 2

        [Given(@"I have the valid credentials")]
        public void GivenIHaveTheValidCredentials()
        {
           
        }

        [When(@"calling the get method with key ""(.*)"" and token ""(.*)""")]
        public void WhenCallingTheGetMethodWithKeyAndToken(string key, string token)
        {
            RestClient trelloGetBoardsClient = CondigureTrelloApi();
            RestRequest trelloGetBoardsRequest = ConfigureRequest("members/me/boards?fields=name,url",Method.Get);
            membersBoardResponse = trelloGetBoardsClient.Execute(trelloGetBoardsRequest);

        }

        [Then(@"the repsonse contains all the boards")]
        public void ThenTheRepsonseContainsAllTheBoards()
        {
            Assert.Equal("OK", membersBoardResponse.StatusDescription);
           
        }




    }
}
