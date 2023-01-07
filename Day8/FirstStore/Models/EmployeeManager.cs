using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;
namespace FirstStore.Models;

public  class EmployeeManager{
    static List<Employee> emp=new List<Employee>();
   
        public static bool b=true;
     public static void AddEmployee(Employee newemp)
     {
        string filename = @"d:\employees.json";
        if(b)
        {
        string jsonstring = System.IO.File.ReadAllText(filename);
        emp = JsonSerializer.Deserialize<List<Employee>>(jsonstring);
        b=false;
        }  
        emp.Add(newemp);
        var option = new JsonSerializerOptions { IncludeFields = true };
        var productjson = JsonSerializer.Serialize<List<Employee>>(emp, option);
        System.IO.File.WriteAllText(filename, productjson);
     }

     public static List<Employee> GetAllEmployees()
     {
        string filename = @"d:\employees.json";
       if(b)
        {
        string jsonstring = System.IO.File.ReadAllText(filename);
        emp = JsonSerializer.Deserialize<List<Employee>>(jsonstring);
        b=true;
        }    
        return emp;
     }
}