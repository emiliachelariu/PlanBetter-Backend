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
    public class ExamControllerTests:BaseIntegrationTests
    {
        [TestMethod]
        public async Task When_AddExam_ShouldInsertExam()
        {
            //Arrange
           

            var model = new AddExamModel()
            {
                CourseId = 100,
                Date = new DateTime(2022, 7, 17, 16, 7, 35, 571, DateTimeKind.Local).AddTicks(8239),
                Details = "detalii",
                GroupId = 1301,
                RoomNo = "acolo",
                TeacherId = 93,
                TimeEnd = new DateTime(2022, 7, 17, 16, 7, 35, 571, DateTimeKind.Local).AddTicks(8239),
                TimeStart = new DateTime(2022, 7, 17, 16, 7, 35, 571, DateTimeKind.Local).AddTicks(8239),
            };
            //Act
            var result = await HttpClient.PostAsJsonAsync("api/exam", model);
            //Assert
            result.EnsureSuccessStatusCode();

            var examidfromresult = await result.Content.ReadAsStringAsync();
            examidfromresult.Should().NotBeNullOrEmpty();

            var resultOfGetexamById = await HttpClient.GetAsync($"api/exam/{examidfromresult}");
            resultOfGetexamById.EnsureSuccessStatusCode();

            var examfromresult = await resultOfGetexamById.Content.ReadFromJsonAsync<Exam>();
            examfromresult.Should().NotBeNull();
            examfromresult.Id.ToString().Should().Be(examidfromresult);

        }
    }
}
