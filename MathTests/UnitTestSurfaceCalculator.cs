using Xunit.Abstractions;

namespace MathTests;
using TestTask.MyMath;
public class UnitTestSurfaceCalculator
{
    private readonly ITestOutputHelper _testOutputHelper;

    public UnitTestSurfaceCalculator(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

    [Fact]
    public void IsCorrect_CountCircleSurface()
    {
        _testOutputHelper.WriteLine("Testing CountCircleSurfaces(double)\n");
        Assert.Equal(79, Double.Round(SurfaceCalculator.CountCircleSurface(5.0)));
    }

    [Fact]
    public void IsCorrect_CountTriangleSurface()
    {
        _testOutputHelper.WriteLine("Testing CountTriangleSurface(double a, double b, double c)\n\ta=5.0\n\tb=5.0\n\tc=5.0");
        Assert.Equal(11, Double.Round(SurfaceCalculator.CountTriangleSurface(5.0, 5.0, 5.0)));
    }

    [Fact]
    public void IsRightTriangle_True()
    {
        _testOutputHelper.WriteLine("Testing IsRightTriangle(double a, double b, double c) that is true");
        Assert.True(SurfaceCalculator.IsRightTrangle(3, 4, 5));
    }

    [Fact]
    public void IsRightTriangle_False()
    {
        _testOutputHelper.WriteLine("Testing IsRightTriangle(double a, double b, double c) that is false");
        
        Assert.False(SurfaceCalculator.IsRightTrangle(5, 5, 5));
    }
}