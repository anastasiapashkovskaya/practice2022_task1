using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePractice2022
{
    internal class AddObstacle : Ocean
    {
        public static void AddObstacles()
        {
            Random random = new Random(1);

            for (int count = 0; count < numObstacle; count++)
            {
                int x = random.Next(0, numRow);
                int y = random.Next(0, numCol);

                cells[x, y] = DefaultData.defaultCharObstacle;
            }
        }
    }
}
