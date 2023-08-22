using System;
namespace Exceptions
{
	public class BootcampException : Exception
	{
		public int Numerator { get; set; }
		public int Denominator { get; set; }

		//default constructor
		public BootcampException() : base()
		{
		}

		//constructor taking string (for message to display)
		public BootcampException(string message) : base(message)
		{
		}

		//constructor taking string & exception
		public BootcampException(string message, Exception innerException) : base(message, innerException)
		{
		}
	}
}

