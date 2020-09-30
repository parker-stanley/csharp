using System;
namespace ClassOneStudio
{
    public class Calculations
    {
        public static double Area(double radius)
        {
            double area = Math.PI * radius * radius;
            return area;
        }

        public static double Circumference(double radius)
        {
            double circumference = Math.PI * radius * 2;
            return circumference;
        }

        public static double Diameter(double radius)
        {
            double diameter = 2 * radius;
            return diameter;
        }
    }
}
