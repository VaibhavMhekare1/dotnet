namespace Person;
//how to compare class without implementing Icomparable

public class Employee
{
    public int EmpId { get; set; }
    public string Ename { get; set; }
    public double Salary { get; set; }

    public Employee()
    {
        this.EmpId = 0;
        this.Ename = null;
        this.Salary = 0;
    }
    public Employee(int id, string name, double salary)
    {
        this.EmpId = id;
        this.Ename = name;
        this.Salary = salary;
    }

    public override string ToString()
    {
        return "Emp id :"+this.EmpId+" Emp name :"+this.Ename+" Emp salary :"+this.Salary;
    }
}