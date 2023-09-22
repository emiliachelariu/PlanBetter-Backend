using FluentAssertions;
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
    public class CourseControllerTests : BaseIntegrationTests
    {
        [TestMethod]
        public async Task When_AddCourse_ShouldInsertCourse()
        {
            //Arrange
            var model = new CourseModel()
            {
                
                CourseName = "materie3",
                TeacherId = 91,
                GroupId = 1301
            };
            //Act
            var result = await HttpClient.PostAsJsonAsync("api/course", model);
            //Assert
            result.EnsureSuccessStatusCode();

            var courseidfromresult = await result.Content.ReadAsStringAsync();
            courseidfromresult.Should().NotBeNullOrEmpty();

            var resultOfGetcourseById = await HttpClient.GetAsync($"api/course/{courseidfromresult}");
            resultOfGetcourseById.EnsureSuccessStatusCode();

            var coursefromresult = await resultOfGetcourseById.Content.ReadFromJsonAsync<Course>();
            coursefromresult.Should().NotBeNull();
            coursefromresult.Id.ToString().Should().Be(courseidfromresult);
        }
    }
}