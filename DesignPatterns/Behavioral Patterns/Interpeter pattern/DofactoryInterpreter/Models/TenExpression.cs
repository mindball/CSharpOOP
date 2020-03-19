namespace DofactoryInterpreter.Models
{
    // <summary>
    /// A 'TerminalExpression' class
    /// <remarks>
    /// Ten checks for X, XL, L and XC
    /// </remarks>
    /// </summary>

    public class TenExpression : Expression
    {
        public override string One() => "X";
        public override string Four() => "XL";
        public override string Five() => "L";
        public override string Nine() => "XC";
        public override int Multiplier() => 10;
    }
}

