namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private int[,] board = new int[3,3];

        private string you;
        private string ai;
        private bool isGameOver = false;

        public Form1(Form2 form2)
        {
            InitializeComponent();

            switch (form2.userSelected)
            {
                case "x":
                    userLabel.Text = "User = x";
                    aiLabel.Text = "Ai = o";
                    you = "x";
                    ai = "o";
                    break;
                case "o":
                    userLabel.Text = "User = o";
                    aiLabel.Text = "Ai = x";
                    you = "o";
                    ai = "x";
                    break;
            }
            
        }

        private void CheckGame()
        {
            if (isGameOver)
                MessageBox.Show("Stop");
            else
                return;
        }

        private void Click(object sender, EventArgs e)
        {
            CheckGame();
            var button = sender as Button;
            if(button != null)
                button.Text = you;
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            Click(sender, e);
            board[0, 0] = 1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Click(sender, e);
            board[0, 1] = 1;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Click(sender, e);
            board[0, 2] = 1;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Click(sender, e);
            board[1, 0] = 1;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Click(sender, e);
            board[1, 1] = 1;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Click(sender, e);
            board[1, 2] = 1;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Click(sender, e);
            board[2, 0] = 1;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Click(sender, e);
            board[2, 1] = 1;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Click(sender, e);
            board[2, 2] = 1;
        }

    }

}
