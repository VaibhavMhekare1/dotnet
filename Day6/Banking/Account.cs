namespace Bank;
using EGovernment;
using Employee;
public class Account{

    public event  taxOperation overBalance;
    public event  bankOperation underBalance;
    public double Balance{get;set;}
    
    public Account(int amount)
    {
        this.Balance=amount;
    }
    public void Deposit(double amount)
    {
        this.Balance+=amount;
    }
    public void Withdraw(double amount)
    {
        if(amount>this.Balance)
        {
            Console.WriteLine("please enter valid amount");
        }else{
            this.Balance-=amount;
        }
    }

    public override string ToString()
    {
        return base.ToString()+" current balance ="+this.Balance;
    }

    public void processBalance()
    {
        if(this.Balance>250000)
        {
            overBalance(this);

        }
        if(this.Balance<5000)
        {
             underBalance();
        }
    }

}