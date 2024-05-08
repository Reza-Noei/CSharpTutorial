namespace WindowsForm
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dice Dice = new Dice();
            Dice.DiceRollCompleted += Dice_DiceRollCompleted;
            Dice.Show(this);
        }

        private void Dice_DiceRollCompleted(object? sender, DiceRollEventArgs e)
        {
            MessageBox.Show(e.Value.ToString());
        }
    }
}
