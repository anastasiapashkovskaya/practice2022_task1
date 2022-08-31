using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace GamePracticeWF
{
    internal class Hero
    {
        public static void AddCell(Bitmap defaultSign, int numCells, Bitmap[,] array, int numRow, int numCol)
        {
            Random random = new Random(1);

            for (int count = 0; count < numCells; count++)
            {
                int x = random.Next(0, numRow);
                int y = random.Next(0, numCol);

                if (array[x, y] == DefaultData.defaultCharCell)
                {
                    array[x, y] = defaultSign;
                }
            }
        }
    }
}
