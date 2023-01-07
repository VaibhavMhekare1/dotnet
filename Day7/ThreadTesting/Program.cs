using System.Threading;

Console.WriteLine("thread id = "+Thread.CurrentThread.ManagedThreadId);
Cosole.WriteLine("thread name = "+Thread.CurrentThread.Name);
Thread.CurrentThread.Name="main thread";//we can assign current thread name
Cosole.WriteLine("thread name = "+Thread.CurrentThread.Name);