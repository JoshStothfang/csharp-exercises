using System;
namespace GeometricShapes
{
	public class Rect
	{

		public int side1 { get; set; }
        public int side2 { get; set; }

		public int Perimeter()
		{
			return (side1 + side2) * 2;
		}

		public int Area()
		{
			return side1 * side2;
		}
        /*public Rect()
		{
		}*/
    }
}

