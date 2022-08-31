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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frm = new FormStartGame();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        private void NumberOfPrey(object sender, EventArgs e)
        {
            Ocean.numPrey = Convert.ToInt16(TBNumOfPrey.Text);
        }

        private void NumberOfObstacles(object sender, EventArgs e)
        {
            Ocean.numObstacle = Convert.ToInt16(TBNumOfObstacles.Text);
        }

        private void NumberOfPredator(object sender, EventArgs e)
        {
            Ocean.numPredator = Convert.ToInt16(TBNumOfPredators.Text);
        }
    }
}
