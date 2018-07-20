namespace FormulaLibrary
{
    public class Vector2
    {
        public double[] Coordinate { get; set; }

        public Vector2(double x, double y)
        {
            Coordinate = new []{x,y};
        }
        
        public static Vector2 operator +(Vector2 a, Vector2 b)
        {
            return new Vector2(a.Coordinate[0]+b.Coordinate[0],a.Coordinate[1]+b.Coordinate[1]); 
        } 
        
        public Vector2 MatrixMultiplication(double[,] matrix)
        {
            double[] result = new double[2];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    result[i] += matrix[i, j] * Coordinate[j];
                }
            }
            return new Vector2(result[0],result[1]);
        }

        public override string ToString()
        {
            return $"({Coordinate[0]},{Coordinate[1]})";
        }
    }
}