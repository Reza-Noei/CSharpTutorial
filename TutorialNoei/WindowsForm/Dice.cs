using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class Dice : Form
    {
        public event EventHandler<DiceRollEventArgs> DiceRollCompleted;

        public Dice()
        {
            InitializeComponent();

            System.Timers.Timer Timer = new System.Timers.Timer();

            Timer.Elapsed += Timer_Elapsed;
            Timer.Interval = 300;
            Timer.Start();
        }

        private void Timer_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
        {
            if (rollCounter == 15)
            {
                (sender as System.Timers.Timer).Stop();
                OnDiceRollCompleted(currentValue);
            }

            TimerLabel.Invoke(() =>
            {
                currentValue = random.Next(1, 6);
                TimerLabel.Text = currentValue.ToString();
            });

            rollCounter++;
        }

        protected virtual void OnDiceRollCompleted(int value)
        {
            DiceRollCompleted?.Invoke(this, new DiceRollEventArgs(value));
        }


        private Random random = new Random();
        private int rollCounter = 0;
        private int currentValue = 0;
    }
}
