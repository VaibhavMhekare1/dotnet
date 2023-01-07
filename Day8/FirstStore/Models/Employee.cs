namespace FirstStore.Models;
using System.ComponentModel.DataAnnotations;
[Serializable]
public class Employee
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

public Employee()
{
   
}
    public Employee(string name, string email, string password)
    {
        this.Name = name;
        this.Email = email;
        this.Password = password;
    }
    public Employee(string email, string password)
    {
        this.Email = email;
        this.Password = password;
    }
    public override bool Equals(object obj)
    {
        Employee e=(Employee)obj;
        return this.Email==e.Email && this.Password==e.Password;
    }

    public override string ToString()
    {
        return "name = "+this.Name+" email = "+this.Email+" pass="+this.Password;
    }

}