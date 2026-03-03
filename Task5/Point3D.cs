using System;

namespace Task5
{
    public struct Point3D
    {
        public int X;
        public int Y;
        public int Z;
        public Point3D(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }


        /// <summary>
        /// Обчислює відстань від поточної точки до початку координат (0,0,0).
        /// </summary>
        public double CalculateDistanceToZero()
        {
            return Math.Sqrt(X * X + Y * Y + Z * Z);
        }
    }

}
