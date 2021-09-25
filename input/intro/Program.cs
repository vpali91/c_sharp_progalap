using System;

namespace InputIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter username:");
            //A ReadLine a teljes beírt inputot hozza a console-ból
            string userName = Console.ReadLine();
            Console.WriteLine($"Hello {userName}!"); //string interpolation

            //Readkey egyetlen karaktert vár, ilyenkor amint leütötted a karaktert továbblép
            Console.WriteLine("Are you sure? Enter 'y' or 'n':");
            var inputYesOrNo = Console.ReadKey();

            //Read() ASCII értékkel tér vissza
            Console.WriteLine("Give a character: ");
            int read = Console.Read();
            Console.WriteLine("ASCII: "+ read);

            Console.WriteLine("Enter a number:");
            //int numberinput = Convert.ToInt32(Console.ReadLine()); //hibalehetőség, lehetőleg maradjunk annál, hogy először string, aztán alakítjuk át, vagy ellenőrizzük az átalakíthatóságot
            string numberinput = Console.ReadLine();
            try
            {
                int inputToNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Your number + 2= " + (inputToNumber+2));
            }
            catch
            {
                Console.WriteLine("Number!!!!");
            }
            //használhatunk feltételt(if) is while-al kombinálva ha szeretnénk a felhasználónak újabb esélyt adni.

            // A fordított per jel (\) escape karakter, amivel stringen belül spec karaktereket, sortöréseket és egyéb dolgokat írathatunk ki, amit egyébként nem tehetnénk meg
            Console.WriteLine("Sortörés \n Új sor \n Következő sor.");
            Console.WriteLine("Escape karakterrel például  \"\" -et is kiírathatunk");

            Console.WriteLine("Write a text to calculate length: ");
            string text = Console.ReadLine();
            Console.WriteLine($"Your text length is: {text.Length} ");
        }
    }
}
