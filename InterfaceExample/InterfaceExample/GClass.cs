using System;
namespace InterfaceExample
{
	public class GClass : IGnDInterface
	{
		public int i { get; set; }
        public bool b { get; set; }
        public string s { get; set; }

        public DateTime dt { get; set; }

        public void Debug(string s)
        {
        }
    }
}

