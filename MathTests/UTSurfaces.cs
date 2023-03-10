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
        _testOutputHelper.WriteLine("Testing CountCircleSurfaces(double)\n");
        Assert.Equal(79, Double.Round(Surface.CountCircleSurface(5.0)));
    }

    [Fact]
    public void IsCorrect_CountTriangleSurface()
    {
        _testOutputHelper.WriteLine("Testing CountTriangleSurface(double)\n");
        Assert.Equal(11, Double.Round(Surface.CountTriangleSurface(5.0, 5.0, 5.0)));
    }
}