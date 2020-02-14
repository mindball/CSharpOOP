using WikiCommandPattern.Contracts;

namespace WikiCommandPattern.Models
{
    public class Switch
    {
        private ICommand onCommmand;
        private ICommand offCommmand;
        public Switch(ICommand onCommmand, ICommand offCommmand)
        {
            this.onCommmand = onCommmand;
            this.offCommmand = offCommmand;
        }

        public void On()
        {
            this.onCommmand.Execute();
        }

        public void Off()
        {
            this.offCommmand.Execute();
        }
    }
}
