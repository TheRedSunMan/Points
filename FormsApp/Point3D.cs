using PointLib;
using System;

namespace FormsApp
{
    [Serializable]
    public class Point3D : Point
    {

        public int Z { get; set; }
        //public int X { get; set; }
        //public int Y { get; set; }


        public Point3D() : base()
        {
            var rnd = new Random();
            Z = rnd.Next(10);
           // X = rnd.Next(10);
           // Y = rnd.Next(10);
        }

        public Point3D(int x, int y, int z) : base(x, y)
        {
            Z = z; // X = x; Y = y;
        }
        public override double Metric()
        {
            return Math.Sqrt(X * X + Y * Y + Z * Z);
        }

        public override string ToString()
        {
            return string.Format($"({X} , {Y}, {Z})");
        }

    }
}
