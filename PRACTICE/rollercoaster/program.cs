namespace Rollercoaster
{
    class Program
    {
        static void Main(string[] args)
        {
            int bill;
            int height;
            int age;

            Console.WriteLine("Rollercoaster");
            Console.WriteLine("What is your height?");
            String height_input =Console.ReadLine();

            Console.WriteLine("What is your age?");
            String age_input = Console.ReadLine();


            if(int.TryParse(height_input, out height) && int.TryParse(age_input, out age))
            {
                if (height>120){
                    if (age < 12)
                    {
                        bill = 5;
                        Console.WriteLine($"Ticket: {bill}$");
                    }
                    else if(age <= 18)
                    {
                        bill = 7;
                        Console.WriteLine($"Ticket: {bill}$");
                    }
                    else
                    {
                        bill = 10;
                        Console.WriteLine($"Ticket: {bill}$");
                    }
                }
                else
                {
                    Console.WriteLine("Go home!");
                }
            }
            else
            {
                Console.WriteLine("Give a number!");
            }
        }
    }
}
