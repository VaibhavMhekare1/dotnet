using Banking;
using Math;
using System.Collections.Generic;
int a = 10;
var p = new
{
    FirstName = "vaibhav",
    LastName = "mhekare",
    id = 10
};
Console.WriteLine("a = {0}", a);
Console.WriteLine(p);
Account act = new Account("vaibhav", 5000);
Console.WriteLine("old balance act = {0}", act.Bal);
Console.WriteLine("changing balance to 10000");
act.Bal = 10000;
Console.WriteLine("new balance act = {0}", act.Bal);
Account act2 = new Account("abc", 2000);
List<Account> accounts = new List<Account>();
accounts.Add(act);
accounts.Add(act2);
foreach (Account ab in accounts)
{
    Console.WriteLine(ab.Bal);
}
Complex c1=new Complex(2,3);
Complex c2=new Complex(3,2);
Complex c3=c1+c2;
Console.WriteLine("c1 = {0}+{0}i",c1.Real,c1.Img);
Console.WriteLine("c2 = {0}+{0}i",c2.Real,c2.Img);
Console.WriteLine("c3 = {0}+{0}i",c3.Real,c3.Img);