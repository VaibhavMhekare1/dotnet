namespace HR;
public class Person
{
    // public readonly string name;
    // public Person(){
    //     name="vaibhav";
    // } it is for checking read only
    public int Id { get; set; }
    public string name { get; set; }
    public string email { get; set; }
    //singleton 
    //by using singleton we can create only one object
    //while instantiating another object we get previously created object only
    //constructor is always private in singleton

    public static Person _ref = null;

    //make constructor private
    Person()//we can write private class like this default access specifier is private
    {
        this.Id = 42;
        this.name = "vaibhav";
        this.email = "abc@mail.com";
    }
    
    public static Person CreateInstance(){
        if(_ref==null)
        {
            _ref=new Person();
        }
        return _ref;
    }

    public void display(params string[] name)
    {
        foreach (string n in name)
        {
            Console.Write(n + " ");
        }
        Console.WriteLine();
    }

    public void swap(ref int num1, ref int num2)
    {
        int temp = num1;
        num1 = num2;
        num2 = temp;
    }

    public void Calculate(int n1, int n2, out int sum, out int mul)
    {
        sum = n1 + n2;
        mul = n1 * n2;
    }
}