using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            //switch(paraméter){case "eset": parancs; break; case "eset2": parancs; break;
            //break megtöri a switch futását ott ahol teljesül a feltételünk és tovább fut a switchet követő parancs
            //példa számokkal
            int day = 4;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }

            //Ugyanezt megtehetjük bármilyen paraméterrel
            //Default értéket adhatunk meg, ha a switch egyik feltételének sem felel meg az inputértékünk
            string job = "software developer";
            int salary = 0;
            switch (job)
            {
                case "software developer":
                    salary = 2000;
                    Console.WriteLine($"Your salary as software developer: {salary}$");
                    break;
                case "janitor":
                    salary = 800;
                    Console.WriteLine($"Your salary as janitor: {salary}$");
                    break;
                case "secretary":
                    salary = 1000;
                    Console.WriteLine($"Your salary as secretary: {salary}$");
                    break;
                default:
                    Console.WriteLine($"{job} profession not found!");
                    break;
            }

        }
    }
}
