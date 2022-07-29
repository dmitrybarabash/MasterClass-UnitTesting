using Moq;
using NUnit.Framework;

namespace Thing.Domain.Tests;

public class Tests
{
    // To write a test we could use the real ThingDependency.
    // Actually it will be an integration test, not unit test.
    [Test]
    public void TestUsingRealDependency()
    {
        var sut = new ThingBeingTested(new ThingDependency());

        // Test code
    }

    // To isolate the ThingBeingTested from the rest of the system, Moq can create
    // a mock version of an IThingDependency. The Setup() method is used to tell
    // the mock how to behave when it is called by the ThingBeingTested.
    [Test]
    public void TestUsingMockDependency()
    {
        // Create mock version
        var mockDependency = new Mock<IThingDependency>();

        // Set up mock version's method
        mockDependency
            .Setup(x => x.JoinUpper(It.IsAny<string>(), It.IsAny<string>()))
            .Returns("A B");

        // Set up mock version's property
        mockDependency
            .Setup(x => x.Meaning)
            .Returns(42);

        // Create thing being tested with a mock dependency
        var sut = new ThingBeingTested(mockDependency.Object);

        var result = sut.MakeThingPurpose();

        Assert.That("A B = 42", Is.EqualTo(result));
    }

    // Here Moq is used to test the correct interactions are occurring between
    // the ThingBeingTested and the IThingDependency. The Verify() method is used to check
    // that the mock JoinUpper() method is being called exactly once with the values
    // "Sarah" and "Smith". The test code is also expecting the method to be called exactly once.
    [Test]
    public void TestUsingMockDependencyUsingInteractionVerification()
    {
        // Create mock version
        var mockDependency = new Mock<IThingDependency>();

        // Create thing being tested with a mock dependency
        var sut = new ThingBeingTested(mockDependency.Object)
        {
            FirstName = "Sarah",
            LastName = "Smith"
        };

        sut.MakeThingPurpose();

        // Assert that the JoinUpper method was called with Sarah Smith
        mockDependency.Verify(x => x.JoinUpper("Sarah", "Smith"), Times.Once);

        // Assert that the Meaning property was accessed once
        mockDependency.Verify(x => x.Meaning, Times.Once);
    }

    // Moq can be used to test in isolation other parts of applications such as ASP.NET Core MVC
    // controllers, where the controller requires a dependency (such as an IFooRepository)
    //[Test]
    //public void ContollerTest()
    //{
    //    var mockDependency = new Mock<IFooRepository>();
    //
    //    var sut = new HomeController(mockDependency.Object);
    //
    //    // Test code
    //}
}