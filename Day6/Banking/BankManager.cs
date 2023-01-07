namespace Employee;

public  delegate void bankOperation();
public class BankManager{

    public void BlockAccount()
    {
        Console.WriteLine("your bank account is blocked due to low balance");
    }

    public void SendEmail()
    {
         Console.WriteLine("blocked account sending email");
    }

    public void SendSms()
    {
          Console.WriteLine("sending sms..........");
    }
}