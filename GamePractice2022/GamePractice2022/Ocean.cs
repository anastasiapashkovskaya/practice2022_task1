using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePractice2022
{
    internal class Ocean
    {
        public static int numRow = DefaultData.maxRows;
        public static int numCol = DefaultData.maxCols;
        public static int numPrey = DefaultData.defaultNumPrey;
        public static int numPredator = DefaultData.defaultNumPredator;
        public static int numObstacle = DefaultData.defaultNumObstacle;
        public static int numIteration = DefaultData.defaultNumIteration;
        public static int timeToReproduce = DefaultData.defaultTimeToReproduce;
        public static int timeToFeed = DefaultData.defaultTimeToFeed;
        public static int size = numRow * numCol;
        public static char[,]? cells;

        static public void Run()
        {

            QuestionGuest.QuestToTheGuest();
            CreatingGame.CreateArray();
            CreatingGame.Process();

        }

    }
}
