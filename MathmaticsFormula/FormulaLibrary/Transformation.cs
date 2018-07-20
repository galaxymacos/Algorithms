using System;

namespace FormulaLibrary
{
    public static class Transformation
    {
        public static double[,] RotationMatrix(double angle)    // in degree
        {
            double radian = angle / 180 * Math.PI;
            return new[,]
            {
                {Math.Round(Math.Cos(radian),2), Math.Round(-Math.Sin(radian),2)},
                {Math.Round(Math.Sin(radian),2), Math.Round(Math.Cos(radian),2)}
            };
        }
        
        public static double[,] ReflectionMatrix(double angle)    // in degree
        {
            double radian = angle / 180 * Math.PI;
            return new[,]
            {
                {Math.Round(Math.Cos(2*radian),2), Math.Round(Math.Sin(2*radian),2)},
                {Math.Round(Math.Sin(2*radian),2), Math.Round(-Math.Cos(2*radian),2)}
            };
        }
        
        public static double[,] ShearMatrix(double angle, double factor)    // in degree
        {
            double radian = angle / 180 * Math.PI;
            return new[,]
            {
                {Math.Round(1-factor*Math.Sin(radian)*Math.Cos(radian),2), Math.Round(factor*Math.Pow(Math.Cos(radian),2),2)},
                {Math.Round(-factor*Math.Pow(Math.Sin(radian),2),2), Math.Round(1+factor*Math.Sin(radian)*Math.Cos(radian),2)}
            };
        }
    }
}