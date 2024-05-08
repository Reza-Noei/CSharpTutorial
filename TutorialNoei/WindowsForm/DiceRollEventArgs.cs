namespace WindowsForm
{
    public class DiceRollEventArgs : EventArgs
    {
        public DiceRollEventArgs(int value)
        {
            Value = value;
        }
        
        public int Value { get; set; }
    }  
}
