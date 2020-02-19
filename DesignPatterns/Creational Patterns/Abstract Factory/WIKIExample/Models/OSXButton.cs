using WIKIExample.Contracts;

namespace WIKIExample.Models
{
    public class OSXButton : IButton
    {
        public void Paint()
        {
            //Render a button in a Mac OS X style
            System.Console.WriteLine("OSXButton render!!");
        }
    }
}
