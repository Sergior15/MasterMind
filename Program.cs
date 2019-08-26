using System;
using System.Linq;

namespace MasterMind
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int x = random.Next(1, 7);
            int y = random.Next(1, 7);
            int z = random.Next(1, 7);
            int n = random.Next(1, 7);
            int randNum = Convert.ToInt32("" + x + y + z + n);
            int guessnum = 10;
            int guess;
            bool EndGame = false;
            int[] randDigits = Array.ConvertAll(randNum.ToString().ToArray(), t => (int)t - 48);
            string[] plus = { "x", "x", "x", "x" };
            string[] minus = { "x", "x", "x", "x" };

            Console.WriteLine("Try to guess a 4 digit sequence in which each single digit ranges between 1 and 6!");
            Console.WriteLine("If you guess a number and it is in the correct position a '+' will be displayed. If you guess a number in the sequence and it is in the 4 digit number, but in the wrong position a '-' will be displayed.");


            while (EndGame == false)
            {
                guess = Convert.ToInt32(Console.ReadLine());
                guessnum--;
                int[] guessDigits = Array.ConvertAll(guess.ToString().ToArray(), t => (int)t - 48);
                Console.WriteLine($"{randNum}");
                Console.WriteLine($"{randDigits[0]}");
                Console.WriteLine($"{guessDigits[1]}");
                Console.WriteLine("If you guess a number and it is in the correct position a '+' will be displayed.");
                Console.WriteLine($"{plus[0]}");
                Console.WriteLine($"{plus[1]}");
                Console.WriteLine($"{plus[2]}");
                Console.WriteLine($"{plus[3]}");
                Console.WriteLine("If you guess a number in the sequence and it is in the random number, but in the wrong position a '-' will be displayed.");
                Console.WriteLine($"{minus[0]}");
                Console.WriteLine($"{minus[1]}");
                Console.WriteLine($"{minus[2]}");
                Console.WriteLine($"{minus[3]}");

                if (guess == randNum)
                {
                    Console.WriteLine("You Guessed the Number, WINNER!");
                }

                if (guessDigits[0].Equals(randDigits[0]))
                {
                    plus[0] = "+";
                }

                if (guessDigits[1].Equals(randDigits[1]))
                {
                    plus[1] = "+";
                }

                if (guessDigits[2].Equals(randDigits[2]))
                {
                    plus[2] = "+";
                }

                if (guessDigits[3].Equals(randDigits[3]))
                {
                    plus[3] = "+";
                }

                if (guessDigits[0] == randDigits[1] || guessDigits[0] == randDigits[2] || guessDigits[0] == randDigits[3] && guessDigits[0] != randDigits[0])
                {
                    minus[0] = "-";
                }

                if (guessDigits[1] == randDigits[0] || guessDigits[1] == randDigits[2] || guessDigits[1] == randDigits[3] && guessDigits[1] != randDigits[1])
                {
                    minus[1] = "-";
                }

                if (guessDigits[2] == randDigits[0] || guessDigits[2] == randDigits[1] || guessDigits[2] == randDigits[3] && guessDigits[2] != randDigits[2])
                {
                    minus[2] = "-";
                }

                if (guessDigits[3] == randDigits[0] || guessDigits[3] == randDigits[1] || guessDigits[3] == randDigits[2] && guessDigits[3] != randDigits[3])
                {
                    minus[3] = "-";
                }


                else if (guess != randNum && guessnum == 0)
                {
                   Console.WriteLine("Game Over, you did not guess the correct number, better luck next time!");
                   Console.ReadLine();
                   EndGame = true;
                }
                
            }
        }

    }
}
