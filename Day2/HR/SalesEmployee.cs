namespace HR;

public class SalesEmployee : Employee
{
    public float Target { get; set; }
    public float SalesDone { get; set; }
    public float Incentive { get; set; }

    public SalesEmployee() : base()
    {
        this.Target = 0;
        this.SalesDone = 0;
        this.Incentive = 0;
    }
    public SalesEmployee(int id, string name, string email, DateTime dob, float target, float salesdone) : base(id, name, email, dob)
    {
        this.Target = target;
        this.SalesDone = salesdone;
        this.Incentive = 0;
    }
    public override void DoWork()
    {
        Console.WriteLine("inside doword of salesemployy");
        if (SalesDone > Target)
        {
            Incentive = 5000;
        }
    }

}