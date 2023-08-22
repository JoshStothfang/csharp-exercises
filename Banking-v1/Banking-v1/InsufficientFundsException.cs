using System;
namespace Banking_v1
{
	public class InsufficientFundsException : Exception
	{
		public InsufficientFundsException() : base()
		{
		}

        public InsufficientFundsException(string message) : base(message)
        {
        }

        public InsufficientFundsException(string message, Exception exception) : base(message, exception)
        {
        }
    }
}

