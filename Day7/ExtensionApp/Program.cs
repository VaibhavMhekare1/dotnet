using Math;

MathEngine me=new MathEngine();
Console.WriteLine(me.Add(3,5));
Console.WriteLine(me.Sub(13,8));
Console.WriteLine(me.Multiplication(3,5));//Extension Method even if mathengine dosen't have 
                                          //multipliation we can use it
Console.WriteLine(me.Division(35,5));


int[] arr={4,2,5,2,3,4,5,1,2};
int count=arr.Count();
Console.WriteLine("count with duplicate = "+count);
count=arr.Distinct().Count();
Console.WriteLine("count without duplicate = "+count);
var newarr=arr.Skip(4);
foreach(var a in newarr)
{
    Console.Write(a+" ");
}
Console.WriteLine();
newarr=arr.Take(5);
foreach(var a in newarr)
{
    Console.Write(a+" ");
}