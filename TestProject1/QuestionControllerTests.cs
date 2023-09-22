using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using PlanBetter.Api;
using PlanBetter.Business.Models;
using PlanBetter.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace PalanBetter.IntegrationTests
{
    [TestClass]
    public class QuestionControllerTests : BaseIntegrationTests
    {
        [TestMethod]
        public async Task When_AddQuestion_ShouldInsertQuestion()
        {
            //Arrange


            var model = new QuestionModel()
            {
                CourseId = 200,
                QuestionText = "cand?",
                StudentId = 3
            };
            //Act
            var result = await HttpClient.PostAsJsonAsync("api/question", model);
            //Assert
            result.EnsureSuccessStatusCode();

            var questionidfromresult = await result.Content.ReadAsStringAsync();
            questionidfromresult.Should().NotBeNullOrEmpty();

            var resultOfGetquestionById = await HttpClient.GetAsync($"api/question/{questionidfromresult}");
            resultOfGetquestionById.EnsureSuccessStatusCode();

            var questionfromresult = await resultOfGetquestionById.Content.ReadFromJsonAsync<Question>();
            questionfromresult.Should().NotBeNull();
            questionfromresult.Id.ToString().Should().Be(questionidfromresult);

        }
    }
}
