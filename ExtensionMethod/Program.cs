// See https://aka.ms/new-console-template for more information

using ExtensionMethod;
using System.Runtime.CompilerServices;

//await Do();
//Console.WriteLine(await DoWorkAsync());
//Console.WriteLine( DoWork());

await Task.Run(() => {Thread.Sleep(5000);});
Console.WriteLine("level 1");
await Task.Run(() => { Thread.Sleep(10000); });
Console.WriteLine("level 2");
await Task.Run(() => { Thread.Sleep(5000); });
Console.WriteLine("level 3");
string DoWork()
{
  
  Thread.Sleep(10000);
    return "done";
}

Task<string> DoWorkAsync()
{
    return Task.Run(() =>
    {
        Thread.Sleep(10000);
         return "hello async";
    });
}

 async Task Do()
{
    await Task.Run(() =>
    {
        Thread.Sleep(5000);
        
    });
}


