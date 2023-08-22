using System;
namespace GeometricShapes
{
	public class Quad
	{
		public int side1 { get; set; }
        public int side2 { get; set; }
        public int side3 { get; set; }
        public int side4 { get; set; }

        public int Perimeter()
        {
            return side1 + side2 + side3 + side4;
        }

        /*public Quad()
		{
		}*/
    }
}

