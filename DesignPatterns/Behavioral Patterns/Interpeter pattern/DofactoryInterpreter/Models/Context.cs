namespace DofactoryInterpreter.Models
{
    public class Context
    {
        private string input;
        private int output;

        // Constructor
        public Context(string input)
        {
            this.input = input;
        }

        // Gets or sets input
        public string Input
        {
            get { return this.input; }
            set { this.input = value; }
        }

        // Gets or sets output
        public int Output
        {
            get { return this.output; }
            set { this.output = value; }
        }
    }
}
