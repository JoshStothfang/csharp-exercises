using System;
namespace GeometricShapes
{
	public class Sq
	{
		public int side { get; set; }


		public int Perimeter()
		{
			return side * 4;
		}

		public int Area()
		{
			return side * side;
		}
		/*public Sq()
		{
		}*/
	}
}

