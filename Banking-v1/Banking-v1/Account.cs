using System;
using System.Security.Principal;

namespace Banking_v1
{
	public class Account
	{
		public static string RoutingNo { get; set; } = "123456789";
		private static int NextAccountNo = 1;

		public int AccountNo { get; set; }
		public decimal Balance { get; set; } = 0;
		public string Description { get; set; } = string.Empty;
		public DateTime DateCreated { get; set; } = DateTime.Now;

		public bool Deposit(decimal Amount)
		{
			if(!AmountIsPositive(Amount))
				return false;

			Balance += Amount;
			return true;
		}

		public bool Withdraw(decimal Amount)
		{
            if (!AmountIsPositive(Amount))
                throw new NotPositiveException();

            if (Balance < Amount)
			{
				try
				{
                    throw new InsufficientFundsException("Insufficient funds!");
                }
				catch
				{
					Console.WriteLine("Insufficient funds!");
                    return false;
                }		
			}

			Balance -= Amount;
			return true;
		}

		public void Transfer(decimal Amount, Account ToAccount)
		{
			/*
			var rc = this.Withdraw(Amount);
			if (rc)
			{
                ToAccount.Deposit(Amount);
            }
			*/
			if (this.Withdraw(Amount))
			{
                ToAccount.Deposit(Amount);
				return;
            }
			Console.WriteLine("Transfer failed!");
        }

		private bool AmountIsPositive(decimal Amount)
		{
			if (Amount > 0)
			{
				return true;
			}

            var ex = new NotPositiveException("Amount must be greater than zero!");
            ex.Amount = Amount;

            try
			{
				throw ex;
            }
			catch
			{
				Console.WriteLine($"{ex.Amount} is not greater than zero!");
                return false;
            }
        }

        public void Print()
		{
            Console.Write($"AccountNo: {AccountNo}, ");
            Console.Write($"Description: [{Description}], ");
            Console.Write($"Balance: {Balance}, ");
            Console.Write($"Created: {DateCreated}");
            Console.WriteLine();
        }

		public Account() //constructor
		{
			this.AccountNo = NextAccountNo++;
		}
	}
}

