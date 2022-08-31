using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GamePracticeWF
{
    public class DefaultData
    {
        public const int maxRows = 25;
        public const int maxCols = 70;
        public const int defaultNumPrey = 150;
        public const int defaultNumPredator = 50;
        public const int defaultNumObstacle = 75;
        public const int defaultTimeToReproduce = 6;
        public const int defaultTimeToFeed = 6;

        public static int defaultNumIteration = 1000;
        public static int defaultNumCell = (maxRows * maxCols) - defaultNumPrey - defaultNumPredator - defaultNumObstacle;
        public static Bitmap defaultCharCell = new Bitmap(@"D:\uni\practice 2022\image\wave.png");
        public static Bitmap defaultCharPrey = new Bitmap(@"D:\uni\practice 2022\image\fish.png");
        public static Bitmap defaultCharPredator = new Bitmap(@"D:\uni\practice 2022\image\shark.png");
        public static Bitmap defaultCharObstacle = new Bitmap(@"D:\uni\practice 2022\image\stone.png");
        public int x = 0;
        public int y = 0;

        public static Random random = new Random(4);
    }
}
