using System.Reflection;
string path=@"D:\CDAC NEW\dotnet\dotnet\Day5\TypeSolution\Catalog\bin\Debug\net7.0\Catalog.dll";//sit git path
Assembly asm=Assembly.LoadFile(path);
string name=asm.FullName;
Console.WriteLine(name);

Type[] types=asm.GetTypes();//gel all type present in assembly
for( int i=0;i<types.Count();i++){
    string typeName=types[i].Name;
    Console.WriteLine(typeName);
    MethodInfo [] mi=types[i].GetMethods();
    // foreach( MethodInfo m in mi){
    // string methodName=m.Name;
    // Console.WriteLine(methodName);
    // }

}



