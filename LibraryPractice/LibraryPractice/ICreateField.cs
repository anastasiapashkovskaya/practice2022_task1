using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryPractice
{
    internal interface ICreateField
    {
        void ShowArray(char[,] array);
        void DisplayBorder(int numCol);
        void DisplayStats(int numCol, int numIteration, int numObstacle, int numPrey, int numPredator);
    }
}
