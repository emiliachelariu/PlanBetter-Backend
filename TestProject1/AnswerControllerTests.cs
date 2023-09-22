//using FluentAssertions;
//using Microsoft.AspNetCore.Mvc.Testing;
//using PlanBetter.Api;
//using PlanBetter.Business.Models;
//using PlanBetter.Domain.Entities;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net.Http.Json;
//using System.Text;
//using System.Threading.Tasks;

//namespace PalanBetter.IntegrationTests
//{
//    [TestClass]
//    public class AnswerControllerTests
//    {
//        [TestMethod]
//        public async Task When_AddAnswer_ShouldInsertAnswer()
//        {
//            //Arrange
//            var application = new WebApplicationFactory<Startup>()
//        .WithWebHostBuilder(builder =>
//        {
//            // ... Configure test services
//        });
//            var client = application.CreateClient();

//            var model = new AnswerModel()
//            {
//                QuestionId = 1,
//                AnswerText="raspuns",
//                TeacherId = 1
//            };
//            //Act
//            var result = await client.PostAsJsonAsync("api/answer", model);


//            //Assert
//            result.EnsureSuccessStatusCode();


//            var answerIdFromResult = await result.Content.ReadAsStringAsync();
//            answerIdFromResult.Should().NotBeNullOrEmpty();


//            var resultOfGetanswerById = await client.GetAsync($"api/answer/{answerIdFromResult}");
//            resultOfGetanswerById.EnsureSuccessStatusCode();


//            var answerFromResult = await resultOfGetanswerById.Content.ReadFromJsonAsync<Answer>();
//            answerFromResult.Should().NotBeNull();
//            answerFromResult.Id.ToString().Should().Be(answerIdFromResult);
//        }
//    }
//}
