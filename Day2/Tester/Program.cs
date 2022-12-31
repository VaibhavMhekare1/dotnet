using Membership;
using HR;
Console.WriteLine("enter email");
string email = Console.ReadLine();
Console.WriteLine("enter password");
string password = Console.ReadLine();
if (AuthManager.Validate(email, password))
{
    Console.WriteLine("logged in successfully");
    Employee emp = new SalesManager();
    emp.DoWork();
    Console.WriteLine(emp);

}
else
{
    Console.WriteLine("enter correct username or password");
}