using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePractice2022
{
    internal class AddPredator : Ocean
    {
        public static void AddPredators()
        {
            Random random = new Random(1);

            for (int count = 0; count < numObstacle; count++)
            {
                int x = random.Next(0, numRow);
                int y = random.Next(0, numCol);

                cells[x, y] = DefaultData.defaultCharPredator;
            }
        }
    }
}
