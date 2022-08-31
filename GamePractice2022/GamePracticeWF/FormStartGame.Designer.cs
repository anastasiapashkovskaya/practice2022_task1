namespace GamePracticeWF
{
    partial class FormStartGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.LabelStartGameObstacle = new System.Windows.Forms.Label();
            this.LabelStartGamePrey = new System.Windows.Forms.Label();
            this.LabelStartGamePredator = new System.Windows.Forms.Label();
            this.LabelStartGameNumOfIteration = new System.Windows.Forms.Label();
            this.LabelStartGameIteration = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(27, 25);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(489, 413);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(536, 25);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(235, 413);
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // LabelStartGameObstacle
            // 
            this.LabelStartGameObstacle.AutoSize = true;
            this.LabelStartGameObstacle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStartGameObstacle.Location = new System.Drawing.Point(547, 50);
            this.LabelStartGameObstacle.Name = "LabelStartGameObstacle";
            this.LabelStartGameObstacle.Size = new System.Drawing.Size(163, 20);
            this.LabelStartGameObstacle.TabIndex = 2;
            this.LabelStartGameObstacle.Text = "Number of obstacles: ";
            // 
            // LabelStartGamePrey
            // 
            this.LabelStartGamePrey.AutoSize = true;
            this.LabelStartGamePrey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStartGamePrey.Location = new System.Drawing.Point(547, 96);
            this.LabelStartGamePrey.Name = "LabelStartGamePrey";
            this.LabelStartGamePrey.Size = new System.Drawing.Size(137, 20);
            this.LabelStartGamePrey.TabIndex = 3;
            this.LabelStartGamePrey.Text = "Number of preys:  ";
            // 
            // LabelStartGamePredator
            // 
            this.LabelStartGamePredator.AutoSize = true;
            this.LabelStartGamePredator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStartGamePredator.Location = new System.Drawing.Point(547, 139);
            this.LabelStartGamePredator.Name = "LabelStartGamePredator";
            this.LabelStartGamePredator.Size = new System.Drawing.Size(167, 20);
            this.LabelStartGamePredator.TabIndex = 4;
            this.LabelStartGamePredator.Text = "Number of predators:  ";
            this.LabelStartGamePredator.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LabelStartGameNumOfIteration
            // 
            this.LabelStartGameNumOfIteration.AutoSize = true;
            this.LabelStartGameNumOfIteration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStartGameNumOfIteration.Location = new System.Drawing.Point(592, 246);
            this.LabelStartGameNumOfIteration.Name = "LabelStartGameNumOfIteration";
            this.LabelStartGameNumOfIteration.Size = new System.Drawing.Size(122, 16);
            this.LabelStartGameNumOfIteration.TabIndex = 5;
            this.LabelStartGameNumOfIteration.Text = "Number of iteration ";
            // 
            // LabelStartGameIteration
            // 
            this.LabelStartGameIteration.AutoSize = true;
            this.LabelStartGameIteration.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStartGameIteration.Location = new System.Drawing.Point(617, 293);
            this.LabelStartGameIteration.Name = "LabelStartGameIteration";
            this.LabelStartGameIteration.Size = new System.Drawing.Size(70, 25);
            this.LabelStartGameIteration.TabIndex = 6;
            this.LabelStartGameIteration.Text = "label1";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(184, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 55);
            this.button1.TabIndex = 7;
            this.button1.Text = "Start simulation";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormStartGame
            // 
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LabelStartGameIteration);
            this.Controls.Add(this.LabelStartGameNumOfIteration);
            this.Controls.Add(this.LabelStartGamePredator);
            this.Controls.Add(this.LabelStartGamePrey);
            this.Controls.Add(this.LabelStartGameObstacle);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Name = "FormStartGame";
            this.Load += new System.EventHandler(this.FormStartGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label LabelStartGameObstacle;
        private System.Windows.Forms.Label LabelStartGamePrey;
        private System.Windows.Forms.Label LabelStartGamePredator;
        private System.Windows.Forms.Label LabelStartGameNumOfIteration;
        public System.Windows.Forms.Label LabelStartGameIteration;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}