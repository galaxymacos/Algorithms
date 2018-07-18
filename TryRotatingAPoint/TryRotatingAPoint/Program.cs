using System;
using System.Collections.Generic;

namespace TryRotatingAPoint
{
    class Program
    {
        static void Rotate(List<int[]> tetris)
        {
            int[] pivotPoint = tetris[2];
            for (int i = 0; i < tetris.Count; i++)
            {
                var preX = tetris[i][1];
                var preY = tetris[i][0];
                if (i != 2)    // Not move the pivot point
                {
                    // anti clockwise rotation
                    var afterRotateX = pivotPoint[1] - preY + pivotPoint[0];
                    var afterRotateY = pivotPoint[0] + preX - pivotPoint[1];
                    
                    // clockwise rotation
//                    var afterRotateX = pivotPoint[1] + preY - pivotPoint[0];
//                    var afterRotateY = pivotPoint[0] - preX + pivotPoint[1];
                    
                    
                    tetris[i] = new[] {afterRotateY,afterRotateX};
                }
            }
        }
        
        static void Main(string[] args)
        {
            List<int[]> tetris = new List<int[]>
            {
                new []{4,5}, new []{5,5}, new []{6,5}, new []{7,5}
            };
            Rotate(tetris);
            foreach (int[] tetri in tetris)
            {
                foreach (int i in tetri)
                {
                    Console.Write(i);
                }

                Console.WriteLine();
            }
            
            
        }

        
    }
}