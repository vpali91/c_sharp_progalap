using System;

namespace getter_setter
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal allat = new Animal(5, "Medvedisznóember", true);
            allat.SetAge(4);
            Console.WriteLine(allat.GetAge());
            Console.WriteLine(allat.GetAlive());
            allat.SetAlive(false);
            Console.WriteLine(allat.GetAlive());
        }
    }
}
