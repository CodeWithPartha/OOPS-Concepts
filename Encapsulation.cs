/*using System;
class Account
{
    int accountBalance=40000;
    public void SetBalance(int amount) //Encapsulation
    {
        if (amount < 0)
        {
            Console.WriteLine("You can't use negative value");
        }
        else{
        accountBalance = amount;
    }
    }
        public void GetBalance()
    {
         Console.WriteLine("Your account balance is : " + accountBalance);
    }
}
class Program{
    public static void Main(string[] args)
    {
        Account myAccount = new Account();
       myAccount.SetBalance(-10000);
       myAccount.GetBalance();
       Console.ReadLine();
    }
}*/

// with the help of properties in encapsulation
/*using System;
class Account
{
    int accountBalance=40000;
    public int Balance
    {
        set
        {
            if (value < 0)
        {
Console.WriteLine("You can't use negative value");
        }
        else
        {
            accountBalance=value;
        }
    }
    get
    {
        return accountBalance;
    }
}
}
class Program{
    public static void Main(string[] args)
    {
        Account myAccount = new Account();
       myAccount.Balance=10000;
       Console.WriteLine(myAccount.Balance);
       Console.ReadLine();
    }
}*/