using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryPractice;

namespace GamePractice2022
{
    internal class CreatingGame : Ocean
    {
        public static void Process()
        {
            MovingCell movingCell = new MovingCell();
            WorkingWithArray workingWithArray = new WorkingWithArray();

            Console.Clear();
            CreateArray();
            workingWithArray.ShowArray(Ocean.cells);
            workingWithArray.DisplayStats(Ocean.numCol, Ocean.numIteration, Ocean.numObstacle, Ocean.numPrey, Ocean.numPredator);
            CreateArray();

            for (int count = 0; count < Ocean.numIteration; count++)
            {
                if (Ocean.numPrey != 0 && Ocean.numPredator != 0)
                {/*
                    movingCell.MoveFrom(Ocean.cells, DefaultData.defaultCharPrey, DefaultData.defaultCharPredator, DefaultData.defaultCharObstacle,
                        DefaultData.defaultCharCell, Ocean.timeToReproduce, DefaultData.defaultTimeToReproduce, DefaultData.defaultTimeToFeed);
                    Thread.Sleep(60);*/
                }
                else
                {
                    Console.WriteLine("END GAME");
                    break;
                }
            }

        }

        public static void CreateArray()
        {
            Ocean.cells = new char[Ocean.numRow, Ocean.numCol];

            for (int row = 0; row < Ocean.cells.GetLength(0); row++)
            {
                for (int col = 0; col < Ocean.cells.GetLength(1); col++)
                {
                    Ocean.cells[row, col] = DefaultData.defaultCharCell;
                }
            }

            AddObstacle.AddObstacles();
            AddPredator.AddPredators();
            AddPrey.AddPreys();
        }
    }
}
