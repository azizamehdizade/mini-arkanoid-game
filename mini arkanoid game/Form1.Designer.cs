namespace mini_arkanoid_game
{
    partial class miniArkanoidGame
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(miniArkanoidGame));
            ball = new PictureBox();
            panel1 = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)ball).BeginInit();
            SuspendLayout();
            // 
            // ball
            // 
            ball.Image = (Image)resources.GetObject("ball.Image");
            ball.Location = new Point(66, 60);
            ball.Name = "ball";
            ball.Size = new Size(70, 70);
            ball.SizeMode = PictureBoxSizeMode.Zoom;
            ball.TabIndex = 0;
            ball.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(185, 423);
            panel1.Name = "panel1";
            panel1.Size = new Size(443, 45);
            panel1.TabIndex = 1;
            // 
            // timer1
            // 
            timer1.Interval = 15;
            timer1.Tick += timer1_Tick;
            // 
            // miniArkanoidGame
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(831, 564);
            Controls.Add(panel1);
            Controls.Add(ball);
            Name = "miniArkanoidGame";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += miniArkanoidGame_Load;
            KeyDown += miniArkanoidGame_KeyDown;
            ((System.ComponentModel.ISupportInitialize)ball).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox ball;
        private Panel panel1;
        private System.Windows.Forms.Timer timer1;
    }
}
