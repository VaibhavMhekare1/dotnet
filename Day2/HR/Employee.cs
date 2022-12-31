namespace HR;

public abstract class  Employee{
    public int Id{get;set;}
    public string Name{get;set;}
    public string Email{get;set;}
    public DateTime DOB{get;set;}

    public Employee(int id,string name,string email,DateTime dob)
    {
        this.Id=id;
        this.Name=name;
        this.Email=email;
        this.DOB=dob;
    }
    public Employee():this(01,"vaibhav","vdm@gmail.com",new DateTime(2000,08,12))
    {

    }

    public abstract void DoWork();

    public override string ToString()
    {
        string str=string.Format("{0}, {1}, {2}, {3} ,{4} ",this.Id,this.Name,this.Email,this.DOB);
        return str;
    }
}