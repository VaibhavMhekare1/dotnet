namespace EGovernment;
using Bank;
public delegate void taxOperation(Account acct);
public class Government
{
    public void DeductIncomeTax(Account act)
    {
        Console.WriteLine("20% income tax deducted from your account");
        act.Balance=0.80*act.Balance;
    }
    public void DeductServiceTax(Account act)
    {
        Console.WriteLine("10% income tax deducted from your account");
        act.Balance=0.90*act.Balance;
    }
    public void DeductProfessionalTax(Account act)
    {
        Console.WriteLine("15% income tax deducted from your account");
        act.Balance=0.85*act.Balance;
    }
}