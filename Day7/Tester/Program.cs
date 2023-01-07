using Person;
using System.Collections.Generic;


List<Employee> employees=new List<Employee>();
employees.Add(new Employee(1, "Sham",30000));
employees.Add(new Employee(2, "Rajendra",67000));
employees.Add(new Employee(4, "Raghu",20000));

Console.WriteLine("List of Employees before Sort");
foreach(Employee emp in employees){
    Console.WriteLine(emp);
}

Empcomparer ec=new Empcomparer();
employees.Sort(ec);
Console.WriteLine("after sorting");
employees.ForEach(a=>Console.WriteLine(a));

Player p1 = new Player("Sourav Ganguly", 50, 300);
Player p2 = new Player("Sachin Tendulkar", 49, 350);
Player p3 = new Player("Rahul Dravid", 48, 250);

List<Player> players=new List<Player>();
players.Add(p1);
players.Add(p2);
players.Add(p3);

players.ForEach(a=>Console.WriteLine(a));
players.Sort();
Console.WriteLine("after sorting");
players.ForEach(a=>Console.WriteLine(a));