using static System.Math;

namespace TestTask.MyMath
{
    public static class Surface
    {
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
    }
}