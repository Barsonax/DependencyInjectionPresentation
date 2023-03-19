using Moq;

namespace DependencyInjectionContainer.UnitTests;

public class ServiceTests
{
    [Test]
    public void DoWork_ShouldCallWaitExpectedTimes()
    {
        //ARRANGE
        var waitServiceMock = new Mock<IWaitService>();
        var service = new Service(waitServiceMock.Object);
        
        //ACT
        service.DoWork();

        //ASSERT
        waitServiceMock.Verify(x => x.Wait(10000), Times.Exactly(10));
    }
}