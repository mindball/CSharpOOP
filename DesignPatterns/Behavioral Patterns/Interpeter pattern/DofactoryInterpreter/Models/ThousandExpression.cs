namespace DofactoryInterpreter.Models
{
    /// <summary>
    /// A 'TerminalExpression' class
    /// <remarks>
    /// Thousand checks for the Roman Numeral M 
    /// </remarks>
    /// </summary>
    public class ThousandExpression : Expression
    {
        public override string One() => "M";
        public override string Four() => " ";
        public override string Five() => " ";
        public override string Nine() => " ";
        public override int Multiplier() => 1000;
    }
}
