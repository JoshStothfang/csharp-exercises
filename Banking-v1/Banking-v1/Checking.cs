using System;
namespace Banking_v1
{
	public class Checking //uses composition
	{
		private Account _Account { get; set; }

		private static int NextCheckNo = 100;
		public int CheckNo { get; set; }
        //public int AccountNo => _Account.AccountNo; //newer way to get account number from account class
        
		public int AccountNo //gets account number from account class 
		{
			get
			{
				return _Account.AccountNo;
			}
		}
		
        public string Description
		{
			get
			{
				return _Account.Description; //gets descrip from account class
			}
			set
			{
				_Account.Description = value; //passes new description to account class
			}
		}
        public decimal Balance
        {
            get
            {
                return _Account.Balance;
            }
        }

		public bool WriteCheck(decimal Amount)
		{
			if (!Withdraw(Amount))
				return false;

			var CheckNo = NextCheckNo++;
			Console.WriteLine($"Check number {CheckNo} for {Amount}");
			return true;
		}

		public bool Deposit(decimal Amount)
		{
			return _Account.Deposit(Amount); //uses deposit method from account class
		}

		public bool Withdraw(decimal Amount)
		{
			return _Account.Withdraw(Amount);
		}

		public void Transfer(decimal Amount, Checking checking)
		{
			if (this.Withdraw(Amount))
			{
				checking.Deposit(Amount);
				return;
			}
			Console.WriteLine("Transfer failed!");
		}

		public void Print()
		{
			_Account.Print();
		}

        public Checking()//constructor
		{
			_Account = new Account();
		}
	}
}

