using System;
namespace InterfaceExample
{
	public class DClass
	{
		public IGnDInterface gc { get; set; }

		public DClass()
		{
			gc = new GClass();
			gc.i = 1;
			gc.b = true;
			gc.s = "George";
			gc.Print(gc.i, gc.b, gc.s);
		}
	}
}

