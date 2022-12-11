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
        private RestResponse MembersBoardResponse = null;
        private RestResponse BoardIdResponse = null;
        private RestResponse CreateBoardResponse = null;



        public RestClient ConfigureTrelloApi()
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
      
        //Scenario 1: Get a specific board by calling the api with the specific Board Id

        [Given(@"the board ID of a specific board")]
        public void GivenTheBoardIDOfASpecificBoard()
        {
            
        }

        [When(@"the get board method is posted for this ""(.*)""")]
        public void WhenTheGetBoardMethodIsPostedForThis(string id)
        {
            id = TestData.Board_Id;
            RestClient TrelloGetBoardClient = ConfigureTrelloApi();
            RestRequest TrelloGetBoardRequest = ConfigureRequest("boards/" + id, Method.Get);
            BoardIdResponse = TrelloGetBoardClient.Execute(TrelloGetBoardRequest);
        }

        [Then(@"the response of the API should fetch the details of the board")]
        public void ThenTheResponseOfTheAPIShouldFetchTheDetailsOfTheBoard()
        {
            Assert.Equal("OK", BoardIdResponse.StatusDescription);
            Assert.Contains("Test Management", BoardIdResponse.Content);
           
        }


        //Scenario 2: Retrieve all the board names for the logged in user

        [Given(@"I have the valid credentials")]
        public void GivenIHaveTheValidCredentials()
        {
           
        }

        [When(@"calling the get member boards")]
        public void WhenCallingTheGetMemberBoards()
        {
            RestClient TrelloGetBoardsClient = ConfigureTrelloApi();
            RestRequest TrelloGetBoardsRequest = ConfigureRequest("members/me/boards?fields=name,url", Method.Get);
            MembersBoardResponse = TrelloGetBoardsClient.Execute(TrelloGetBoardsRequest);
        }

        [Then(@"the repsonse contains all the boards belonging to the user")]
        public void ThenTheRepsonseContainsAllTheBoardsBelongingToTheUser()
        {
            Assert.Equal("OK", MembersBoardResponse.StatusDescription);
            Assert.NotNull(MembersBoardResponse);
        }



        //Scenario 3: Creating a new board (everytime although the same name it generates a new ID. By this way its unique ID)

        [Given(@"I have the board name")]
        public void GivenIHaveTheBoardName()
        {

        }

        [When(@"I call the Create board API with ""(.*)""")]
        public void WhenICallTheCreateBoardAPIWith(string boardName)
        {
            boardName = TestData.Board_Name;
            RestClient CreateBoardClient = ConfigureTrelloApi();
            RestRequest CreateBoardRequest = ConfigureRequest("/boards/?name=" + boardName, Method.Post);
            CreateBoardResponse = CreateBoardClient.Execute(CreateBoardRequest);
        }

        [Then(@"the response should be successful")]
        public void ThenTheResponseShouldBeSuccessful()
        {
            Assert.NotNull(CreateBoardResponse);
            Assert.Contains(TestData.Board_Name, CreateBoardResponse.Content);
        }
    }
}
