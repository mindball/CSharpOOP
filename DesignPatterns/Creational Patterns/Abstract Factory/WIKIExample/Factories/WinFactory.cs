using WIKIExample.Contracts;
using WIKIExample.Models;


namespace WIKIExample.Factories
{
    public class WinFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new WinButton();
        }
    }
}
