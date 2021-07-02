using System;

namespace HelloWorld.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var world = new World();
            Console.WriteLine(world.Greeting());
        }
    }
}
