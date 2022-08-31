using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamePracticeWF
{
    public partial class FormStartGame : Form
    {
        Bitmap [,] field = new Bitmap[Ocean.numRow, Ocean.numCol];

        public FormStartGame()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Hide();

            LabelStartGameObstacle.Text += Convert.ToString(Ocean.numObstacle);
            LabelStartGamePrey.Text += Convert.ToString(Ocean.numPrey);
            LabelStartGamePredator.Text += Convert.ToString(Ocean.numPredator);
/*
            CreatingGame.CreateArray();*/

            timer1.Enabled = true;


        }

        public void OnPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            for (int row = 0; row < Ocean.numRow; row++)
            {
                for (int col = 0; col < Ocean.numCol; col++)
                {
                    g.DrawImage(Ocean.cells[row, col], new PointF(row, col));
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void FormStartGame_Load(object sender, EventArgs e)
        {
            CreateArray(field);
        }

        public static void CreateArray(Bitmap[,] array)
        {
            Random random = new Random();

            for (int row = 0; row < array.GetLength(0); row++)
            {
                for (int col = 0; col < array.GetLength(1); col++)
                {
                    if (array[row, col] == null)
                    {
                        array[row, col] = DefaultData.defaultCharCell;
                    }
                }
            }

            Hero.AddCell(DefaultData.defaultCharPrey, Ocean.numPrey, array, Ocean.numRow, Ocean.numCol);
            Hero.AddCell(DefaultData.defaultCharPredator, Ocean.numPredator, Ocean.cells, Ocean.numRow, Ocean.numCol);
            Hero.AddCell(DefaultData.defaultCharObstacle, Ocean.numObstacle, Ocean.cells, Ocean.numRow, Ocean.numCol);

            
        }
    }
}
