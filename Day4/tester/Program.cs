using HR;


 Person p=Person.CreateInstance();
Console.WriteLine(p.name);
p.display("vaibhav d m");
p.display("vaibhav","mhekare");
p.display("vaibhav","dattatray","mhekare");
int n1=3;
int n2=5;
Console.WriteLine("before swapping");
Console.WriteLine(n1);
Console.WriteLine(n2);
p.swap(ref n1,ref n2);//we have to always pass argument using ref keyword
//if we do swapping without using reference it wouldn't change orignal value bcz we pass only copy of it not it's reference
Console.WriteLine("after swapping");
Console.WriteLine(n1);
Console.WriteLine(n2);

p.Calculate(2,6,out int sum,out int multi);// we can return two values using out keyword
Console.WriteLine("sum "+sum);
Console.WriteLine("multiplication "+multi);

Person p2=Person.CreateInstance();
Console.WriteLine(p2.name);
p2.name="****vaibhav****";
Console.WriteLine(p2.name);
Console.WriteLine(p.name);
