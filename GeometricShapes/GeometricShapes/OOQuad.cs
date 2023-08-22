using System;
namespace GeometricShapes
{
	public class OOQuad
	{
		public int side1 { get; set; }
		public int side2 { get; set; }
		public int side3 { get; set; }
		public int side4 { get; set; }

		public int Perimeter()
		{
			return side1 + side2 + side3 + side4;
		}

		public OOQuad(int s1, int s2, int s3, int s4) //constructor
		{
			side1 = s1;
			side2 = s2;
			side3 = s3;
			side4 = s4;
		}
	}
}

