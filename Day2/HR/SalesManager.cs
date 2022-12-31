namespace HR;

public class SalesManager:SalesEmployee{
    public float Bonus{get;set;}

    public SalesManager():base(){
        this.Bonus=0;
    }
    public SalesManager(int id,string name,string email,DateTime dob,float target,float salesdone,float bonus):base(id,name,email,dob,target,salesdone){
        this.Bonus=bonus;
    }

    public override void DoWork()
    {
        base.DoWork();
    }

    public override string ToString()
    {
        return base.ToString()+" bonus = "+this.Bonus;
    }

}