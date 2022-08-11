using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwitchExercise;

namespace SwitchExercise
{
    internal class Methods
    {
        public static void Winner()
        {

            Random r = new Random();
            int favNumber = r.Next(1, 100);
            var guess = int.Parse(Console.ReadLine());

            if (guess > favNumber)
            {
                Console.WriteLine($"Your guess of {guess} is too high!\n" +
                    $"You Lose!");


            }
            else if (guess < favNumber)
            {
                Console.WriteLine($"Your guess of {guess} is too low \n" +
                    $"You Lose!");

            }
            else 
            {
                Console.WriteLine($"Your guess of {guess} is correct! \n" +
                    $"WINNER!");
                
            }
        }

        public static void SchoolSubjects()
        {
            Console.WriteLine("Hey! What is your favorite subject in school!");
            string favSubject = Console.ReadLine();
            favSubject.ToLower();

            switch(favSubject)
            {
                case "math":
                    Console.WriteLine("Math is essential! keep up the good work!");
                    break;
                case "science":
                    Console.WriteLine("Science is the secret to life!");
                    break;
                case "english":
                    Console.WriteLine("Why do we have to take this for so long?");
                    break;
                case "art":
                    Console.WriteLine("My momma always told me i was artistic!");
                    break;
                case "history":
                    Console.WriteLine("Remember kids, History always repeats itself!");
                    break;
                    default:
                    break;

                    Console.WriteLine("Is that REALLY your favorite subject? \n" +
                        "Mine too!");
            }









        }






























        



        
    


    }

}
