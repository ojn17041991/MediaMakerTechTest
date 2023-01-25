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

        // Simple test data for the Add test method.
        public static IEnumerable<object[]> getInsertData()
        {
            yield return new object[] { new Request { Description = "Test 1" } };
            yield return new object[] { new Request { Description = "Test 2" } };
            yield return new object[] { new Request { Description = "Test 3" } };
        }

        [Theory]
        [MemberData(nameof(getInsertData))]
        public void Get_Add_Request_To_Controller(Request request)
        {
            // Mocking the data access object used by the controller.
            Mock<IDataAccessor<Request>> mock = new Mock<IDataAccessor<Request>>();

            // Since we're mocking an add method, we need something to store the inserted values.
            IList<Request> mockedDataStore = new List<Request>();

            // Mock the data accessor Add method to insert into the data store.
            mock.Setup(s => s.Add(It.IsAny<Request>())).Callback<Request>(r => mockedDataStore.Add(r));

            // Converting the mocked object into a real one.
            IDataAccessor<Request> dataAccessor = mock.Object;

            // Instantiate the controller using the mocked data access object.
            RequestController controller = new RequestController(dataAccessor);

            // Call Add() on the controller.
            // We're inserting to a mock data store. We don't care about the ActionResult itself.
            ActionResult result = controller.Add(request);

            // Make our assertions.
            using (new AssertionScope())
            {
                mockedDataStore.Count().Should().Be(1);
                mockedDataStore.First().Id.Should().Be(request.Id);
                mockedDataStore.First().Description.Should().Be(request.Description);
            }
        }
    }
}
