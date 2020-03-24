namespace PlayersAndMonsters.Models.Cards
{
    public class MagicCard : Card
    {
        private const int damagePointsInitial = 5;
        private const int healthPointsInitial = 80;

        public MagicCard(string name) 
            : base(name, damagePointsInitial, healthPointsInitial)
        {
        }
    }
}
