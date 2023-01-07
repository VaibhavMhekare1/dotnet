using BOL;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

Console.WriteLine("welcome to feedback system");
bool exit = true;
Console.WriteLine("1 to add feedback\n2 update details\n3 delete user\n4 getbyid\n5 get all\n6 exit");
List<Feedback> al = new List<Feedback>();
string filename=@"d:\products.json";
string jsonstring=File.ReadAllText(filename);
al=JsonSerializer.Deserialize<List<Feedback>>(jsonstring);
try
{
    while (exit)
    {
        Console.WriteLine("enter your choise");
        var option = Console.ReadLine();
        int cases = int.Parse(option);

        switch (cases)
        {
            case 1:
                Console.WriteLine("enter faculty id faculty name rating and comment ");
                al.Add(new Feedback(int.Parse(Console.ReadLine()), Console.ReadLine(), int.Parse(Console.ReadLine()), Console.ReadLine()));
                Console.WriteLine("feedback added successfully");
                break;
            case 2:
                Console.WriteLine("enter faculty id to update rating");
                int id = int.Parse(Console.ReadLine());
                bool flag=true;
                for(int i=0;i<al.Count;i++)
                {
                    if(al[i].F_id==id)
                    {
                       Console.WriteLine("entert new rating");
                       al[i].Rating=int.Parse(Console.ReadLine());
                       flag=false;
                       break;
                    }
                }

                break;
            case 3:
                Console.WriteLine("enter faculty id to delete feedback");
                 id = int.Parse(Console.ReadLine());
                 flag = true;
                for (int i = 0; i < al.Count; i++)
                {
                    if (al[i].F_id == id)
                    {
                        al.RemoveAt(i);
                        i--;
                        flag = false;
                        Console.WriteLine("removed successfully");
                        break;
                    }
                }
                if (flag)
                {
                    Console.WriteLine("enter valid id");
                }
                break;
            case 4:
                Console.WriteLine("enter faculty id to show details");
                id = int.Parse(Console.ReadLine());
                flag = true;
                al.ForEach((a) =>
                {
                    if (a.F_id == id)
                    {
                        Console.WriteLine(a);
                        flag = false;
                    }
                });
                if (flag)
                {
                    Console.WriteLine("enter valid id");
                }
                break;
            case 5:
                al.ForEach((a) => Console.WriteLine(a));
                break;

            case 6:
                exit = false;
                Console.WriteLine("exited successfully");
                break;
        }
    }
}
catch (Exception e)
{
   
}
finally
{
    var option = new JsonSerializerOptions { IncludeFields = true };
    var productjson = JsonSerializer.Serialize<List<Feedback>>(al, option);
    File.WriteAllText(filename,productjson);
}