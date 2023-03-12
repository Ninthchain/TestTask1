using TestTask.MyMath;
using Xunit.Abstractions;

namespace MathTests;

public class UnitTestCustomSurfaceCalculator
{
    private readonly ITestOutputHelper _testOutputHelper;

    public UnitTestCustomSurfaceCalculator(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

    [Fact]
    public void AddNewSurfaceCalculatorIsCorrect()
    {
        SurfaceCalculator calculator = new ();
        
        _testOutputHelper.WriteLine("Adding new shape. Rectangle Surface Calculator");
        
        calculator.AddNewCalculator("RectangleCalculator", args => 
        {
            if (args.Length > 2)
                throw new Exception("The rectangle surface calculator receiving only 2 args");
            return args[0] * args[1];
        });
        
        _testOutputHelper.WriteLine("Checking if everything is correct.");
        Assert.Equal(6, calculator.GetCalculatorByKey("RectangleCalculator")(3, 2));
    }
}