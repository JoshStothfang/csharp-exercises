using System;
namespace Banking_v1
{
	public class Savings : Account //uses inheritance (oop)
	{
		public decimal InterestRate { get; set; } = 0.12m; //m or M says it is a decimal

		public decimal CalculateInterestByMonths(int months)
		{
			var Interest =  Balance * ((InterestRate / 12) * months);
			Deposit(Interest);
			return Interest;
		}

		public Savings() : base() //use Savings constructor to call Account constructor
		{

		}
	}
}

