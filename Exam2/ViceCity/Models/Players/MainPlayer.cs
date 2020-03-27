using ViceCity.Models.Players.Contracts;

namespace ViceCity.Models.Players
{
    public class MainPlayer : Player, IPlayer
    {
        private const string name = "Tommy Vercetti";
        private const int lifePoints = 100;

        public MainPlayer()
            : base(name, lifePoints)
        {
        }
    }
}
