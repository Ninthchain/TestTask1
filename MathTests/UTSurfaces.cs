using Xunit.Abstractions;

namespace MathTests;
using TestTask.MyMath;
public class UnitTest1
{
    private readonly ITestOutputHelper _testOutputHelper;

    public UnitTest1(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

    [Fact]
    public void IsCorrect_CountCircleSurface()
    {
        _testOutputHelper.WriteLine("Testing CountCircleSurfaces(double)");
        Assert.Equal(78.54, Surface.CountCircleSurface(5.0));
    }

    [Fact]
    public void IsCorrect_CountTriangleSurface()
    {
        _testOutputHelper.WriteLine("Testing");
        Assert.Equal(10.825, Surface.CountTriangleSurface(5.0, 5.0, 5.0));
    }
}