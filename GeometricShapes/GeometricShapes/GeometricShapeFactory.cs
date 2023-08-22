using System;
namespace GeometricShapes
{
	public static class GeometricShapeFactory
	{
		public static OOQuad CreateInstance(int s1, int s2, int s3, int s4)
		{
			return new OOQuad(s1, s2, s3, s4);
		}

        public static OORect CreateInstance(int s1, int s2)
        {
            return new OORect(s1, s2);
        }

        public static OOSq CreateInstance(int s1)
        {
            return new OOSq(s1);
        }
	}
}

