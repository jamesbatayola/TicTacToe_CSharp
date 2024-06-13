
namespace TicTacToe
{
    public partial class Form2 : Form
    {
        public string userSelected { get; set; }
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Select(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Select(sender, e);
        }

        private void Select(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null)
                userSelected = button.Text.ToLower();

            var form1 = new Form1(this);
            form1.ShowDialog();
        }

    }

}
