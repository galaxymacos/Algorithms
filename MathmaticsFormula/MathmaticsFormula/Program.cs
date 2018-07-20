using System;
using FormulaLibrary;

namespace MathmaticsFormula
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Vector2 a = new Vector2(1,2);
            double[,] transformationMatrix = Transformation.RotationMatrix(90);
            var result = a.MatrixMultiplication(transformationMatrix);
            Console.WriteLine(result);
        }
    }
}