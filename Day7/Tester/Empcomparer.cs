namespace Person;

public class Empcomparer:IComparer<Employee>
{
    public int Compare(Employee e1,Employee e2)
    {
        return e1.Ename.CompareTo(e2.Ename);
    }
}