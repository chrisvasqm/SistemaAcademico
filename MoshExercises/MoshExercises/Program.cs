using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var rightAnswer = random.Next(0, 11);
            Console.WriteLine(rightAnswer);

            Console.WriteLine("Guess what's the number I'm thinking about from 0 to 10");
            Console.WriteLine("You have 3 chances, so choose wisely!");
            Console.WriteLine("The rigth anser is {0}", rightAnswer);
            Console.WriteLine("First number: ");
            var firstAnswer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second number: ");
            var secondAnswer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Third number: ");
            var thirdAnswer = Convert.ToInt32(Console.ReadLine());

            if (firstAnswer == rightAnswer|| secondAnswer == rightAnswer || thirdAnswer == rightAnswer)
                Console.WriteLine("You win!");
            else 
                Console.WriteLine("You lose");
        }
    }
}
