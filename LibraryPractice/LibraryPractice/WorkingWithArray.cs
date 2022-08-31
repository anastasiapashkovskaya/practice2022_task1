using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryPractice
{
    public class WorkingWithArray : ICreateField
    {
        public void ShowArray(char [,] array)
        {
            for (int row = 0; row < array.GetLength(0); row++)
            {
                for (int col = 0; col < array.GetLength(1); col++)
                {
                    Console.Write(array[row, col]);
                }

                Console.WriteLine();
            }
        }

        public void DisplayBorder(int numCol)
        {
            Console.WriteLine();

            for (int count = 0; count < numCol; count++)
            {
                Console.Write('*');
            }

            Console.WriteLine();
        }


        public void DisplayStats(int numCol, int numIteration, int numObstacle, int numPrey, int numPredator)
        {
            WorkingWithArray array = new WorkingWithArray();
            array.DisplayBorder(numCol);

            Console.WriteLine("Iteration number: " + numIteration);
            Console.WriteLine("Obstacles: " + numObstacle);
            Console.WriteLine("Prey: " + numPrey);
            Console.WriteLine("Predator: " + numPredator);

            DisplayBorder(numCol);
        }
    }
}
