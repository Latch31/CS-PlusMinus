using System;

namespace lesson1
{
    class plusminus
    {
        static void Main(string[] args)
        {
            System.Random rand = new System.Random();
            int nbGuess = rand.Next(100);
            int nbTry = 0;
            string userEntry;
            int nbEntry;
            bool inside = false;
            //Console.WriteLine(nbGuess.Next(100));

            Console.WriteLine("Guess a number between 0 and 100");
            do
            {
                nbTry++;
                Console.WriteLine("Try : " + nbTry);

                do
                {
                    userEntry = Console.ReadLine();
                   // nbEntry = int.Parse(userEntry);
                    if (!int.TryParse(userEntry, out nbEntry))
                    {
                        Console.WriteLine("Error, your number is not between 0 and 100");
                        inside = false;
                    }
                    else if (nbEntry < 0 || nbEntry > 100)
                    {
                        Console.WriteLine("Error, your number is not between 0 and 100");
                        inside = false;
                    }
                    else
                    {
                        inside = true;
                    }
                } while (!inside);

                if (nbEntry < nbGuess)
                {
                    Console.WriteLine("your number is too low !");
                }
                else
                {
                    Console.WriteLine("your number is too high !");
                }

            } while (nbGuess != nbEntry);
            
            Console.WriteLine("You Win ! \nYou have found the number with " + nbTry + " try !!!");
        }
    }
}
