using System;
namespace InterfaceExample
{
	public class Hamster : IBreedSpeak
	{
		public string Breed { get; set; }
		public string Color { get; set; }
		public string Speak { get; set; }
	}
}

