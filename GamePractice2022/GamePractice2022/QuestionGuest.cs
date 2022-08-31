using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePractice2022
{
    internal class QuestionGuest
    {
        static public void QuestToTheGuest()
        {
            Console.WriteLine("If you want to use default equals press [Y]\nPress any other key if no");

            if (Console.ReadKey().KeyChar != 'Y')
            {
                Console.WriteLine("\nEnter width of field: ");
                Ocean.numRow = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter height of field: ");
                Ocean.numCol = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter number of obstacles: ");
                Ocean.numObstacle = Convert.ToInt32(Console.ReadLine());

                if (Ocean.numObstacle == Ocean.size)
                {
                    Ocean.numObstacle = Ocean.size;
                }

                Console.WriteLine("Enter number of predators: ");
                Ocean.numPredator = Convert.ToInt32(Console.ReadLine());

                if (Ocean.numPredator == (Ocean.size - Ocean.numObstacle))
                {
                    Ocean.numPredator = Ocean.size - Ocean.numObstacle;
                }

                Console.WriteLine("Enter number of prey: ");
                Ocean.numPrey = Convert.ToInt32(Console.ReadLine());

                if (Ocean.numPrey == (Ocean.size - Ocean.numObstacle - Ocean.numPredator))
                {
                    Ocean.numPrey = Ocean.size - Ocean.numObstacle - Ocean.numPredator;
                }

                Console.WriteLine("Enter number iteration: (default [Y])");
                Ocean.numIteration = Convert.ToInt32(Console.ReadLine());

                if (Ocean.numIteration > 1000)
                {
                    Ocean.numIteration = 1000;
                }
            }

            Console.WriteLine();
        }
    }
}
