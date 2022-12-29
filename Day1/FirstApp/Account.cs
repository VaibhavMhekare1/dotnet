namespace Banking;

public class Account{
    private double Balance;
    private string Name;
    public Account()
    {
        this.Balance=1000;
        this.Name="name";
    }
    public Account(string Name,double Balance)
    {
        this.Name=Name;
        this.Balance=Balance;
    }
    
    // public void SetName(string Name)
    // {
    //     this.Name=Name;
    // }
    // public string GetName()
    // {
    //     return this.Name;
    // }

    //  public void SetBalance(double Balance)
    // {
    //     this.Balance=Balance;
    // }
    // insted of using getter and setter we can write code like this
   public string name{
    get {return this.Name;}
    set { this.Name=value;}
  }
   public double Bal{
    get {return this.Balance; }
    set { this.Balance = value; }
  }
}