namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private int[,] board = new int[3,3];
        private Button[,] buttons;
        
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

            buttons = new Button[3, 3]
            {
                {btn1, btn2, btn3 },
                {btn4, btn5, btn6 },
                {btn7, btn7, btn9 }
            };

        }

        // Check if someone wins
        //private bool Winner()
        //{
        //    bool userWins = false;
        //    // Horizontal
        //    if (board[0, 0] == 1 && board[0, 1] == 1 && board[0, 2] == 1)
        //        userWins = true;
        //    if (board[1, 0] == 1 && board[1, 1] == 1 && board[1, 2] == 1)
        //        userWins = true;
        //    if (board[2, 0] == 1 && board[2, 1] == 1 && board[2, 2] == 1)
        //        userWins = true;
        //    //Vertical
        //    if (board[0, 0] == 1 && board[1, 0] == 1 && board[2, 0] == 1)
        //        userWins = true;
        //    if (board[0, 1] == 1 && board[1, 1] == 1 && board[2, 1] == 1)
        //        userWins = true;
        //    if (board[0, 2] == 1 && board[1, 2] == 1 && board[2, 2] == 1)
        //        userWins = true;

        //    return userWins;
        //}

        private bool Winner()
        {
            bool isWin = false;

            // Horizontal
            if (btn1.Text == you && btn2.Text == you && btn3.Text == you)
                isWin = true;
            if (btn4.Text == you && btn5.Text == you && btn6.Text == you)
                isWin = true;
            if (btn7.Text == you && btn8.Text == you && btn9.Text == you)
                isWin = true;
            // Vertical
            if (btn1.Text == you && btn4.Text == you && btn7.Text == you)
                isWin = true;
            if (btn2.Text == you && btn5.Text == you && btn8.Text == you)
                isWin = true;
            if (btn3.Text == you && btn6.Text == you && btn9.Text == you)
                isWin = true;
            // Cross
            if (btn1.Text == you && btn5.Text == you && btn9.Text == you)
                isWin = true;
            if (btn3.Text == you && btn5.Text == you && btn7.Text == you)
                isWin = true;

            return isWin;
        }

        // Check the board if full
        private bool IsFull()
        {
            bool isFull = false;
            var num = new List<int>();
            for (int i = 0; i < buttons.GetLength(0); i++)
            {
                for(int j = 0; j < buttons.GetLength(1); j++)
                {
                    if (buttons[i, j].Text != string.Empty)
                        num.Add(1);
                    if (num.Count == 9)
                        isFull = true;
                }
            }
            
            return isFull;
        }

        private void OpponentTurn()
        {
            // Defensive Horizonal
            if (btn1.Text == you && btn2.Text == you && btn3.Text == string.Empty)
                btn3.Text = ai;
            else if (btn1.Text == you && btn3.Text == you && btn2.Text == string.Empty)
                btn2.Text = ai;
            else if (btn2.Text == you && btn3.Text == you && btn1.Text == string.Empty)
                btn1.Text = ai;

            else if (btn4.Text == you && btn5.Text == you && btn6.Text == string.Empty)
                btn6.Text = ai;
            else if (btn4.Text == you && btn6.Text == you && btn5.Text == string.Empty)
                btn5.Text = ai;
            else if (btn5.Text == you && btn6.Text == you && btn4.Text == string.Empty)
                btn4.Text = ai;

            else if (btn7.Text == you && btn8.Text == you && btn9.Text == string.Empty)
                btn9.Text = ai;
            else if (btn7.Text == you && btn9.Text == you && btn8.Text == string.Empty)
                btn8.Text = ai;
            else if (btn8.Text == you && btn9.Text == you && btn7.Text == string.Empty)
                btn7.Text = ai;

            // Defensive Vertical
            else if (btn1.Text == you && btn4.Text == you && btn7.Text == string.Empty)
                btn7.Text = ai;
            else if (btn1.Text == you && btn7.Text == you && btn4.Text == string.Empty)
                btn4.Text = ai;
            else if (btn4.Text == you && btn7.Text == you && btn1.Text == string.Empty)
                btn1.Text = ai;

            else if (btn2.Text == you && btn5.Text == you && btn8.Text == string.Empty)
                btn8.Text = ai;
            else if(btn2.Text == you && btn8.Text == you && btn5.Text == string.Empty)
                btn5.Text = ai;
            else if(btn5.Text == you && btn8.Text == you && btn2.Text == string.Empty)
                btn2.Text = ai;

            else if (btn3.Text == you && btn6.Text == you && btn9.Text == string.Empty)
                btn9.Text = ai;
            else if(btn3.Text == you && btn9.Text == you && btn6.Text == string.Empty)
                btn6.Text = ai;
            else if(btn6.Text == you && btn9.Text == you && btn3.Text == string.Empty)
                btn3.Text = ai;

            // Defensive Cross
            else if (btn1.Text == you && btn5.Text == you && btn9.Text == string.Empty)
                btn9.Text = ai;
            else if(btn1.Text == you && btn9.Text == you && btn5.Text == string.Empty)
                btn4.Text = ai;
            else if(btn5.Text == you && btn9.Text == you && btn1.Text == string.Empty)
                btn1.Text = ai;

            else if (btn3.Text == you && btn5.Text == you && btn7.Text == string.Empty)
                btn7.Text = ai;
            else if(btn3.Text == you && btn7.Text == you && btn5.Text == string.Empty)
                btn5.Text = ai;
            else if(btn5.Text == you && btn7.Text == you && btn3.Text == string.Empty)
                btn3.Text = ai;

            else 


            aiLabel.ForeColor = Color.Black;
            userLabel.ForeColor = Color.Red;
        }

        private void OpponentRandomMove()
        {

        }

        private void CheckGame()
        {
            if (Winner())
                MessageBox.Show("Winner");
            else if (IsFull())
                MessageBox.Show("Stop");
            else
                return;
        }

        private void Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if(button != null)
            {
                button.Text = you;
                button.Enabled = false;
            }
            OpponentTurn();
            CheckGame();
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            board[0, 0] = 1;
            Click(sender, e);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            board[0, 1] = 1;
            Click(sender, e);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            board[0, 2] = 1;
            Click(sender, e);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            board[1, 0] = 1;
            Click(sender, e);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            board[1, 1] = 1;
            Click(sender, e);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            board[1, 2] = 1;
            Click(sender, e);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            board[2, 0] = 1;
            Click(sender, e);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            board[2, 1] = 1;
            Click(sender, e);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            board[2, 2] = 1;
            Click(sender, e);
        }

    }

}
