using System.Diagnostics;
using FluentAssertions;
using NoDependencyInjection;

namespace Services.UnitTests;

public class ServiceTests
{
    [Test]
    public void DoWork_ShouldRunForExpectedTime()
    {
        //ARRANGE
        var service = new Service();
        var stopWatch = Stopwatch.StartNew();
        
        //ACT
        service.DoWork();

        //ASSERT
        stopWatch.ElapsedMilliseconds.Should().BeInRange(110000, 90000);
    }
}