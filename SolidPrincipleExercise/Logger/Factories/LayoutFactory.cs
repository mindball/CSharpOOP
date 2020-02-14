using Logger.Exceptions;
using Logger.Models.Layout;
using Logger.Models.Contracts;

namespace Logger.Factories
{
    class LayoutFactory
    {
        public ILayout GetLayout(string type)
        {
            ILayout layout;
            if(type.Equals("SimpleLayout"))
            {
                layout = new SimpleLayout();
            }
            else if (type.Equals("XmlLayout"))
            {
                layout = new XmlLayout();
            }
            else
            {
                throw new InvalidLayoutTypeException();
            }

            return layout;
        }
    }
}
