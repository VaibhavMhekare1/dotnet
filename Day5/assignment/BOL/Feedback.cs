namespace BOL;
using System.ComponentModel.DataAnnotations;
[Serializable] //attribute{annotation in java} --contains metadata
public class Feedback
{
     public int F_id{get;set;}
     public string F_name{get;set;}
     public int Rating{get;set;}
     public string Comment{get;set;}

     public Feedback()
     {
        this.F_id=42;
        this.F_name="vaibhav";
        this.Rating=4;
        this.Comment="";
     }
     public Feedback(int fid,string fname,int rating,string comment)
     {
        this.F_id=fid;
        this.F_name=fname;
        this.Rating=rating;
        this.Comment=comment;
     }
    public override string ToString()
    {
        return "faculty id "+this.F_id+"  Faculty name "+this.F_name+"  rating "+this.Rating+"  Comment "+this.Comment;
    }
}
