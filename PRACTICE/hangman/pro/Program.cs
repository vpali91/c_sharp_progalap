using System;
using System.Collections.Generic;

namespace HangmanPro
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
            List<char> game_word_list = new List<char>();
            List<char> guessed_word_list = new List<char>();
            Random rand = new Random();

            int rand_num = rand.Next(0, word_list.Length - 1);
            String word = word_list[rand_num];

            foreach (var item in word)
            {
                game_word_list.Add(item);
                guessed_word_list.Add('_');
            }

            while (in_game)
            {
                Console.WriteLine("Adj meg egy betűt!");
                char guess = Convert.ToChar(Console.ReadLine());

                for (int i = 0; i < game_word_list.Count; i++)
                    if (guess == game_word_list[i])
                        guessed_word_list[i] = guess;

                if (!game_word_list.Contains(guess))
                    lives--;

                //kiíratás
                string kitalalando = "";
                foreach (var item in guessed_word_list)
                    kitalalando += item + " , ";

                Console.WriteLine(@$"
                        Hangman
                {stages[lives]}
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
