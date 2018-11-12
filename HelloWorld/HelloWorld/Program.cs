using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("\nWhat is your name? ");
            var name = Console.ReadLine();
            var date = DateTime.Now;
            Console.WriteLine($"\nHello, {name}, on {date:d} at {date:t}!");
            Console.Write("Press any key to exit...");
            Console.ReadKey(true);
                       

            // Go to http://aka.ms/dotnet-get-started-consolehttp://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
