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
    public class StudentGroupControllerTests : BaseIntegrationTests
    {
        [TestMethod]
        public async Task When_AddStudentGroup_ShouldInserStudentGroup()
        {
            //Arrange
            
            var model = new StudentGroupModel()
            {
                GroupName="1301a",
                StudentId=1,
            };
            //Act
            var result = await HttpClient.PostAsJsonAsync("api/studentgroup", model);
            //Assert
            result.EnsureSuccessStatusCode();

            var studentgroupIdFromResult=await result.Content.ReadAsStringAsync();
            studentgroupIdFromResult.Should().NotBeNullOrEmpty();

            var resultOfGetStudentGroupById=await HttpClient.GetAsync($"api/studentgroup/{studentgroupIdFromResult}");
            resultOfGetStudentGroupById.EnsureSuccessStatusCode();

            var studentgroupfromresult = await resultOfGetStudentGroupById.Content.ReadFromJsonAsync<StudentGroup>();
            studentgroupfromresult.Should().NotBeNull();
            studentgroupfromresult.Id.ToString().Should().Be(studentgroupIdFromResult);
        }
        [TestMethod]
        public async Task When_UpdateDatabase_ShouldChangeStudentGroupData()
        {
            //Arrange

            var addStudentGroupModel = new AddStudentGroupModel()
            {
                GroupName = "1301a",
                StudentId = 1,
            };
            var result = await HttpClient.PostAsJsonAsync("api/studentgroup", addStudentGroupModel);
            result.EnsureSuccessStatusCode();
            var studentgroupIdFromResult = await result.Content.ReadAsStringAsync();

            var expectedChangeStudentGroupGroupName = "1310a";
            var studentgroup = new StudentGroup()
            {
                Id = Convert.ToInt32(studentgroupIdFromResult),
                GroupName = expectedChangeStudentGroupGroupName,
                StudentId = 1
            };
            //Act
            var resultForUpdateStudentGroup = await HttpClient.PutAsJsonAsync("api/studentgroup", studentgroup);


            //Assert
            resultForUpdateStudentGroup.EnsureSuccessStatusCode();

            var resultOfGetStudentGroupById = await HttpClient.GetAsync($"api/studentgroup/{studentgroupIdFromResult}");
            resultOfGetStudentGroupById.EnsureSuccessStatusCode();
            var studentgroupFromResult = await resultOfGetStudentGroupById.Content.ReadFromJsonAsync<StudentGroup>();

            studentgroupFromResult.Should().NotBeNull();
            studentgroupFromResult.Id.ToString().Should().Be(studentgroupIdFromResult);

            studentgroupFromResult.GroupName.Should().Be(expectedChangeStudentGroupGroupName);
        }
    }
}
