namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            String rock = @"
    _______
---'   ____)
      (_____)
      (_____)
      (____)
---.__(___)
";

            String paper = @"
    _______
-- - '   ____)____
          ______)
          _______)
         _______)
---.__________)
";

            String scissors = @"
    _______
-- - '   ____)____
          ______)
       __________)
      (____)
-- -.__(___)
";

            String[] tomb = { rock, paper, scissors };
            bool ingame = true;

            while (ingame)
            {
                Console.WriteLine("What do you choose? 0 - Rock, 1 - PAper, 2 - Scissors");
                String input = Console.ReadLine();
                int choice;

                if (int.TryParse(input, out choice))
                {
                    if (choice >= 0 && choice <= 2)
                    {
                        ingame = false;
                        Random rand = new Random();
                        int random_number = rand.Next(0, 2);
                        Console.WriteLine("Your choice:");
                        Console.WriteLine(choice);
                        Console.WriteLine(tomb[choice]);
                        Console.WriteLine("Computer's choice");
                        Console.WriteLine(tomb[random_number]);
                        if ((choice == 0 && random_number == 2) || (choice == 1 && random_number == 0) || (choice == 2 && random_number == 1))
                        {
                            Console.WriteLine("You win!");
                        }
                        else if ((choice == 0 && random_number == 1) || (choice == 1 && random_number == 2) || (choice == 2 && random_number == 0))
                        {
                            Console.WriteLine("You loose");
                        }
                        else if (choice == random_number)
                        {
                            Console.WriteLine("Draw");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Give a number between 0 && 2!");
                    }
                }
                else
                {
                    Console.WriteLine("Give a number!");
                }
            }
        }
    }
}
