namespace FormulaLibrary
{
    public class Point2
    {
        public int[] Coordinate { get; set; }

        public Point2(int x,int y)
        {
            Coordinate = new[]{x,y};
        }
        public static Vector2 operator -(Point2 a, Point2 b)
        {
            return new Vector2(a.Coordinate[0]-b.Coordinate[0],a.Coordinate[1]-b.Coordinate[1]);
        }

        
    }
}