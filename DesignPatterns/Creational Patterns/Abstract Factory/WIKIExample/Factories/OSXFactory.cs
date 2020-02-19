using WIKIExample.Contracts;
using WIKIExample.Models;

namespace WIKIExample.Factories
{
    public class OSXFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new OSXButton();
        }
    }
}
