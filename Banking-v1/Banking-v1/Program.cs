using Banking_v1;
/*
var chk1 = new Checking();
chk1.Description = "Checking Account";
chk1.Deposit(300);
chk1.Withdraw(50);
chk1.WriteCheck(25);

var chk2 = new Checking();
chk2.Description = "Slush Fund";
chk1.Transfer(250, chk2);

chk1.Print();
chk2.Print();
*/

var sav1 = new Savings();
sav1.Description = "Savings Account";
sav1.Deposit(400);
sav1.Withdraw(-50);
sav1.Print();

/*
var chk1 = new Checking();
chk1.Description = "Checking Account";
chk1.Deposit(300);
chk1.Withdraw(50);
chk1.WriteCheck(25);

var chk2 = new Checking();
chk2.Description = "Slush Fund";
chk1.Transfer(25, chk2);

chk1.Print();
chk2.Print();


var acctChecking = new Account();

var acctSavings = new Account();

acctSavings.Deposit(500);
acctSavings.Withdraw(313);
acctSavings.Transfer(187, acctChecking);
acctChecking.Withdraw(200);
acctSavings.Deposit(-100);
//187 checking, 0 savings

acctChecking.Transfer(287, acctSavings);


acctChecking.Print();
acctSavings.Print();
*/


