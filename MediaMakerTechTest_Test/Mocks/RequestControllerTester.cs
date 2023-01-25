using FluentAssertions;
using FluentAssertions.Execution;
using MediaMakerTechTest.Controllers;
using MediaMakerTechTest.Data.Abstractions;
using MediaMakerTechTest.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;

namespace MediaMakerTechTest_Test.Mocks
{
    // In order to test the controller, we'll have to use mocking.
    // We need to be able to mock the data access object.
    // I don't want EF to be called every time I want to test the controller.

    public class RequestControllerTester
    {
        [Fact]
        public void Can_Get_Requests_From_Controller()
        {
            // Mocking the data access object used by the controller.
            Mock<IDataAccessor<Request>> mock = new Mock<IDataAccessor<Request>>();
            mock.Setup(s => s.Get()).Returns(() =>
                new List<Request>()
                {
                    new Request { Id = 1, Description = "Test 1" },
                    new Request { Id = 2, Description = "Test 2" },
                    new Request { Id = 3, Description = "Test 3" }
                }.AsQueryable()
            );

            // Converting the mocked object into a real one.
            IDataAccessor<Request> dataAccessor = mock.Object;

            // Instantiate the controller using the mocked data access object.
            RequestController controller = new RequestController(dataAccessor);

            // Call Get() on the controller and cast the return object in a null-safe way.
            ObjectResult result = (controller?.Get() as ObjectResult) ?? new ObjectResult(new List<Request>().AsQueryable());

            // Get() returns an ActionResult, so we need to get the value out.
            IQueryable<Request> value = (result.Value as IQueryable<Request>) ?? new List<Request>().AsQueryable();

            // Make our assertions.
            using (new AssertionScope())
            {
                value.Count().Should().Be(3);

                for (int i = 0; i < 3; ++i)
                {
                    value.ElementAt(i).Id.Should().Be(i + 1);
                    value.ElementAt(i).Description.Should().Be($"Test {i + 1}");
                }
            }
        }

        //[Fact]
        //public void Get_Add_Request_To_Controller()
        //{
        //    // Mocking the data access object used by the controller.
        //    Mock<IDataAccessor<Request>> mock = new Mock<IDataAccessor<Request>>();
        //    mock.Setup(s => s.Add(It.IsAny<Request>()));

        //    // There is no controller.Add() function, so there is nothing to test.
        //}
    }
}
