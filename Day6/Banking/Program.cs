using EGovernment;
using  Bank;
using Employee;
Government vm=new Government();
taxOperation income=new taxOperation(vm.DeductIncomeTax);
taxOperation prof=new taxOperation(vm.DeductProfessionalTax);

BankManager bm=new BankManager();
bankOperation block=new bankOperation(bm.BlockAccount);
bankOperation sms=new bankOperation(bm.SendSms);
bankOperation email=new bankOperation(bm.SendEmail);


Account act1=new Account(5000);
act1.overBalance+=income;
act1.overBalance+=prof;
act1.underBalance+=block;
act1.underBalance+=sms;
act1.underBalance+=email;
Console.WriteLine("Enter amount to deposit");
act1.Deposit(int.Parse(Console.ReadLine()));
Console.WriteLine("before performing operation");
Console.WriteLine(act1);

act1.processBalance();
Console.WriteLine("after performing operation");
Console.WriteLine(act1);