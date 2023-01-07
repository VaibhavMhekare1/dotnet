namespace Person;

public class Player:IComparable{
    public string Name{get;set;}
    public int Age{get;set;}
    public int Matches{get;set;}
 
    public Player(string name,int age,int matches)
    {
        this.Name=name;
        this.Age=age;
        this.Matches=matches;
    }
    public override string ToString()
    {
     return "player name = "+this.Name+" player age = "+this.Age+" Matches played = "+this.Matches;   
    } 
    public int CompareTo(object? obj)
    {
        Player a=obj as Player;
        return this.Name.CompareTo(a.Name);
    }
}