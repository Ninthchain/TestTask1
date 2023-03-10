namespace TestTask.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        [Fact]
        void CountTriangleSurfaceIsCorrect() => Assert.StrictEqual(10.825317547305483, MyMath.Surface.CountTriangleSurface(5, 5, 5));

        [Fact]
        void CountCircleSurfaceIsCorrect() => Assert.StrictEqual(12.566, MyMath.Surface.CountCircleSurface(2));
    }
}