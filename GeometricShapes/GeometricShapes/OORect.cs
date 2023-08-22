using System;
namespace GeometricShapes
{
	public class OORect : OOQuad
	{
		public int Area()
		{
			return side1 * side2;
		}

		public OORect(int s1, int s2) : base(s1, s2, s1, s2)
		{
		}
	}
}

