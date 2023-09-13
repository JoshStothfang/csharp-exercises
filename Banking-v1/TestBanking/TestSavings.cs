using Banking_v1;

namespace TestBanking;

public class TestSavings
{
    Savings? sav = null;
    Savings? sav2 = null;

    public TestSavings()
    {
        sav = new Savings();
        sav2 = new Savings()
        {
            Balance = 1000
        };
    }

    [Theory]
    [InlineData(100)]
    [InlineData(150)]
    public void TestDeposit(decimal amt)
    {
        var initBalance = sav!.Balance;
        Assert.True(sav.Deposit(amt));
        Assert.Equal(initBalance + amt, sav.Balance);
    }

    [Theory]
    [InlineData(250, 200, 50)]
    [InlineData(1000, 500, 500)]
    [InlineData(10, 7, 3)]
    public void TestWithdraw(decimal initBalance, decimal balance, decimal amt)
    {
        sav!.Balance = initBalance;
        Assert.True(sav.Withdraw(amt));
        Assert.Equal(balance, sav.Balance);
    }

    [Fact]
    public void TextWithdrawException()
    {
        Assert.Throws<NotPositiveException>(() => sav!.Withdraw(-100));
    }

    [Theory]
    [InlineData(250)]
    [InlineData(500)]
    public void TestTransfer(decimal amt)
    {
        sav2!.Transfer(amt, sav!);
        Assert.Equal(amt, sav!.Balance);
    }
}
