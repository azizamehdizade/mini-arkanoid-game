namespace mini_arkanoid_game
{
    public partial class miniArkanoidGame : Form
    {
        public miniArkanoidGame()
        {
            InitializeComponent();
        }
        int dx = 5;
        int dy = -5;
        int score = 0;
        bool gameover = false;
        private void miniArkanoidGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && panel1.Left > 0)
            {
              
                panel1.Left -= 20;
            }
            if (e.KeyCode == Keys.Right && panel1.Right < ClientSize.Width)
            {
               
                panel1.Left += 20;
            }
            if (e.KeyCode == Keys.Enter && gameover)
            {
                restartgame();
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (gameover) return;
            ball.Top += dy;
            ball.Left += dx;

            if (ball.Left <= 0 || ball.Right >= this.ClientSize.Width)
            {
                dx = -dx;
            }
            if (ball.Top <= 0)
            {
                dy = -dy;
            }
            if (dy > 0 && ball.Bounds.IntersectsWith(panel1.Bounds))
            {
                score++;
                ball.Top = panel1.Top - ball.Height; 
                dy = -(dy + 1);
            }
            if (ball.Bottom >= ClientSize.Height)
            {
                gameover = true;
                timer1.Stop();
                MessageBox.Show("Game Over! Your score: " + score);
            }
        }



        private void restartgame()
        {
            ball.Location = new Point(66, 60);
            panel1.Location = new Point(369, 747);
            dx = 5;
            dy = -5;
            score = 0;
            gameover = false;
            timer1.Start();
            timer1.Interval = 30;
        }

        private void miniArkanoidGame_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}