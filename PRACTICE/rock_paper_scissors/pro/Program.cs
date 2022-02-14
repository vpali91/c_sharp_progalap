using System;

namespace Rock
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] tomb = {
 @"
    _______
---'   ____)
      (_____)
      (_____)
      (____)
---.__(___)
",
@"
    _______
-- - '   ____)____
          ______)
          _______)
         _______)
---.__________)
",
 @"
    _______
-- - '   ____)____
          ______)
       __________)
      (____)
-- -.__(___)
"
};
            bool ingame = true;
            int choice;

            while (ingame)
            {
                Console.WriteLine("What do you choose? 0 - Rock, 1 - PAper, 2 - Scissors");
                String input = Console.ReadLine();

                if (int.TryParse(input, out choice))
                {
                    if (choice >= 0 && choice <= 2)
                    {
                        ingame = false;
                        Random rand = new Random();
                        int random_number = rand.Next(0, 2);
                        Console.WriteLine(@$"Your choice:
                                            {choice}
                                            {tomb[choice]}
                                            Computer's choice
                                            {tomb[random_number]}");

                        if ((choice == 0 && random_number == 2) || (choice == 1 && random_number == 0) || (choice == 2 && random_number == 1))
                            Console.WriteLine("You win!");
                        else if (choice == random_number)
                            Console.WriteLine("Draw");
                        else
                            Console.WriteLine("You loose");
                    }
                    else
                        Console.WriteLine("Give a number between 0 && 2!");
                }
                else
                    Console.WriteLine("Give a number!");
            }
        }
    }
}
