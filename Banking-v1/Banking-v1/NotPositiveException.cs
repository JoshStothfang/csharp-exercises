using System;
namespace Banking_v1
{
	public class NotPositiveException : Exception
	{
        public decimal Amount { get; set; }

		public NotPositiveException() : base()
		{
		}

        public NotPositiveException(string message) : base(message)
        {
        }

        public NotPositiveException(string message, Exception exception) : base(message, exception)
        {
        }
    }
}

