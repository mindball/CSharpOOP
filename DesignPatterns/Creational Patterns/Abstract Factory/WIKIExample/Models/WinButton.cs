using WIKIExample.Contracts;

namespace WIKIExample.Models
{
    public class WinButton : IButton
    {
        public void Paint()
        {
            //Render a button in a Windows style
            System.Console.WriteLine("Win button render!!");
        }
    }
}
