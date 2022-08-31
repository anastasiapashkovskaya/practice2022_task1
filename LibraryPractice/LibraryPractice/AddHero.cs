using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryPractice
{
    public class AddHero
    {
        public static void AddCell(char defaultSign, int numCells, char [,] array, int numRow, int numCol)
        {
            Random random = new Random(1);

            for (int count = 0; count < numCells; count++)
            {
                int x = random.Next(0, numRow);
                int y = random.Next(0, numCol);

                if (array[x, y] == '-')
                {
                    array[x, y] = defaultSign;
                }
            }
        }
    }
}
