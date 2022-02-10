namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] stages = new String[] {
@"
  +---+
  |   |
  O   |
 /|\  |
 / \  |
      |
=========
", @"
  +---+
  |   |
  O   |
 /|\  |
 /    |
      |
=========
", @"
  +---+
  |   |
  O   |
 /|\  |
      |
      |
=========
", @"
  +---+
  |   |
  O   |
 /|   |
      |
      |
=========",
@"
  +---+
  |   |
  O   |
  |   |
      |
      |
=========
", @"
  +---+
  |   |
  O   |
      |
      |
      |
=========
", @"
  +---+
  |   |
      |
      |
      |
      |
=========
"};
            int lives = 6;
            bool in_game = true;

            String[] word_list = new string[] { "hal", "majom", "banán" };
            Random rand = new Random();
            int rand_num = rand.Next(0, word_list.Length - 1);
            String word = word_list[rand_num];
            List<char> game_word_list = new List<char>();

            foreach (var item in word)
            {
                game_word_list.Add(item);
            }

            List<char> guessed_word_list = new List<char>();
            foreach (var item in word)
            {
                guessed_word_list.Add('_');
            }

            while (in_game)
            {
                Console.WriteLine("Adj meg egy betűt!");
                char guess = Convert.ToChar(Console.ReadLine());

                int a = 0;

                foreach (var letter in game_word_list)
                {
                    if (guess == letter)
                    {
                        guessed_word_list[a] = guess;
                        a++;
                    }
                    else
                    {
                        a++;
                    }
                }
                if (!game_word_list.Contains(guess))
                {
                    lives--;

                }
                //kiíratás
                string kitalalando = "";
                foreach (var item in guessed_word_list)
                {
                    kitalalando += item + " , ";
                }

                Console.WriteLine(@$"
                        Hangman
                {kitalalando}
                {lives}
                ");
                if (lives == 0)
                {
                    in_game = false;
                    Console.WriteLine("Lúzer!");
                }
                if (!guessed_word_list.Contains('_'))
                {
                    in_game = false;
                    Console.WriteLine("Nyertél!");
                }

            }

        }
    }
}
