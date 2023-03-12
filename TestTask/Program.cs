// See https://aka.ms/new-console-template for more information

using TestTask.MyMath;

namespace ConsoleApp1
{
    static class Program
    {
        public static void Main(string[] args)
        {
            //Testing the inserting of new calcs

            SurfaceCalculator calculator = new ();
            
            calculator.AddNewCalculator("RectangleSurface", args =>
            {
                if (args.Length > 2)
                    throw new Exception("The rectangle surface calculator receiving only 2 args");
                return args[0] * args[1];
            });
            
            Console.WriteLine(calculator.GetCalculatorByKey("RectangleSurface"));
        }
    }
}