using System;
using System.Threading.Tasks;

public class Program
{
    public static async Task Main()
    {
        Task sleepTask = Sleep(); // Start Sleep() asynchronously without awaiting it yet
        Console.WriteLine("Await delay over!"); // This will print immediately


        await sleepTask; // Now wait for Sleep() to finish
    }

    static async Task Sleep()
    {
        Console.WriteLine("Delay begins.");
        await Task.Delay(3000);
        Console.WriteLine("Delay over.");
    }
}
