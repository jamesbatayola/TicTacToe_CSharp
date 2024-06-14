namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private int[,] board = new int[3, 3];
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
                {btn7, btn8, btn9 }
            };

        }

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
                for (int j = 0; j < buttons.GetLength(1); j++)
                {
                    if (buttons[i, j].Text != string.Empty)
                        num.Add(1);
                    if (num.Count == 9)
                        isFull = true;
                }
            }

            return isFull;
        }

        private void Reset()
        {
            for (int i = 0; i < buttons.GetLength(0); i++)
                for (int j = 0; j < buttons.GetLength(1); j++)
                {
                    if (buttons[i, j].Text != string.Empty)
                        buttons[i, j].Text = "";
                    buttons[i, j].Enabled = true;
                }
        }

        private void OpponentTurn()
        {
            Button button = null;

            // Defensive Horizonal
            if (btn1.Text == you && btn2.Text == you && btn3.Text == string.Empty)
                button = btn3;
            else if (btn1.Text == you && btn3.Text == you && btn2.Text == string.Empty)
                button = btn2;
            else if (btn2.Text == you && btn3.Text == you && btn1.Text == string.Empty)
                button = btn1;

            else if (btn4.Text == you && btn5.Text == you && btn6.Text == string.Empty)
                button = btn6;
            else if (btn4.Text == you && btn6.Text == you && btn5.Text == string.Empty)
                button = btn5;
            else if (btn5.Text == you && btn6.Text == you && btn4.Text == string.Empty)
                button = btn4;

            else if (btn7.Text == you && btn8.Text == you && btn9.Text == string.Empty)
                button = btn9;
            else if (btn7.Text == you && btn9.Text == you && btn8.Text == string.Empty)
                button = btn8;
            else if (btn8.Text == you && btn9.Text == you && btn7.Text == string.Empty)
                button = btn7;

            // Defensive Vertical
            else if (btn1.Text == you && btn4.Text == you && btn7.Text == string.Empty)
                button = btn7;
            else if (btn1.Text == you && btn7.Text == you && btn4.Text == string.Empty)
                button = btn4;
            else if (btn4.Text == you && btn7.Text == you && btn1.Text == string.Empty)
                button = btn1;

            else if (btn2.Text == you && btn5.Text == you && btn8.Text == string.Empty)
                button = btn8;
            else if (btn2.Text == you && btn8.Text == you && btn5.Text == string.Empty)
                button = btn5;
            else if (btn5.Text == you && btn8.Text == you && btn2.Text == string.Empty)
                button = btn2;

            else if (btn3.Text == you && btn6.Text == you && btn9.Text == string.Empty)
                button = btn9;
            else if (btn3.Text == you && btn9.Text == you && btn6.Text == string.Empty)
                button = btn6;
            else if (btn6.Text == you && btn9.Text == you && btn3.Text == string.Empty)
                button = btn3;

            // Defensive Cross
            else if (btn1.Text == you && btn5.Text == you && btn9.Text == string.Empty)
                button = btn9;
            else if (btn1.Text == you && btn9.Text == you && btn5.Text == string.Empty)
                button = btn4;
            else if (btn5.Text == you && btn9.Text == you && btn1.Text == string.Empty)
                button = btn1;

            else if (btn3.Text == you && btn5.Text == you && btn7.Text == string.Empty)
                button = btn7;
            else if (btn3.Text == you && btn7.Text == you && btn5.Text == string.Empty)
                button = btn5;
            else if (btn5.Text == you && btn7.Text == you && btn3.Text == string.Empty)
                button = btn3;

            // Random Move
            else
                OpponentRandomMove();

            if (button != null)
            {
                button.Text = ai;
                button.Enabled = false;
            }

        }

        private void OpponentRandomMove()
        {
            var random = new Random();
            var unoccupied = new List<Button>();
            random.Next();

            for (int i = 0; i < buttons.GetLength(0); i++)
                for (int j = 0; j < buttons.GetLength(1); j++)
                    if (buttons[i, j].Text == string.Empty)
                        unoccupied.Add(buttons[i, j]);

            if (unoccupied.Count > 0)
            {
                int randomNum = random.Next(unoccupied.Count);
                unoccupied[randomNum].Text = ai;
            }

        }

        private void CheckGame()
        {
            if (Winner())
            {
                MessageBox.Show("Winner");
                Reset();
            }
            else if (IsFull())
            {
                MessageBox.Show("Stop");
                Reset();
            }
            else
                return;
        }

        private void Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null)
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
