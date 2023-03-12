using static System.Math;

public delegate double ParamsFunc<T>(params T[] args);

namespace TestTask.MyMath
{
    
    public class SurfaceCalculator
    {
        private Dictionary<string, ParamsFunc<double>> _additionalCalculators;

        private void Initialize()
        {
            this._additionalCalculators = new();
        }
        
        public SurfaceCalculator() => this.Initialize();

        public void AddNewCalculator(string key, ParamsFunc<double> calculator)
        {
            this._additionalCalculators.Add(key, calculator);
        }

        public ParamsFunc<double> GetCalculatorByKey(string key) => this._additionalCalculators[key];

        public static double CountCircleSurface(double radius)
        {
            return PI * Pow(radius, 2);
        }

        public static double CountTriangleSurface(double a, double b, double c)
        {
            double p = (a + b + c) / 2;

            //Heron's formula used
            return Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public static bool IsRightTrangle(double a, double b, double c)
        {
            double[] sides = { a, b, c };
            
            double hypo = sides.Max();
            sides.ToList().Remove(hypo);

            bool res = Abs(Abs(Pow(hypo, 2)) - Abs(Pow(sides[0], 2) + Pow(sides[1], 2))) <= 0;
            return res;
        }
    }
}