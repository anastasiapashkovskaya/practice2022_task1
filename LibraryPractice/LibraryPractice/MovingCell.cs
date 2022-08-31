using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace LibraryPractice
{
    public class MovingCell
    {
        public void MoveFrom(char[,] array, char signPrey, char signPredator, char signObstacle,
            char signCell, int timeToReproduce, int defaultTimeToReproduce, int timeToFeed)
        {
            Random randomX = new Random();
            Random randomY = new Random();

            int x = 0;
            int y = 0;

            x = randomX.Next(-2, 2);
            y = randomY.Next(-2, 2);

            Console.CursorVisible = false;

            for (int row = 0; row < array.GetLength(0); row++)
            {
                for (int col = 0; col < array.GetLength(1); col++)
                {
                    bool checkCorrectCondition = (row + x < array.GetLength(0) && row + x >= 0 && col + y < array.GetLength(1) && col + y >= 0);

                    if (checkCorrectCondition && array[row, col] != signObstacle)
                    {
                        char currentKey = array[row, col];
                        char nextKey = array[row + x, col + y];

                        bool IsCanMove = (currentKey != signObstacle && nextKey == signCell);

                        bool IsCanEat = (currentKey == signPredator
                            && nextKey == signPrey);

                        bool IsCanReproduce = (currentKey == signPrey && timeToReproduce < 0);

                        if (IsCanMove)
                        {
                            Console.SetCursorPosition(col + y, row + x);
                            Console.Write(currentKey);

                            if (IsCanEat)
                            {
                                Console.Write(currentKey);

                                --timeToFeed;

                                if (timeToFeed < 0)
                                {
                                    Console.Write(signCell);
                                }
                            }

                            else if (IsCanReproduce)
                            {
                                Console.SetCursorPosition(col, row);
                                Console.Write(currentKey);

                                timeToReproduce = defaultTimeToReproduce;
                            }
                        }

                    }
                }
            }
        }
    }
}
