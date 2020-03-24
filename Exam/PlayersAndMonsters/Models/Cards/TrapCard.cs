namespace PlayersAndMonsters.Models.Cards
{
    public class TrapCard : Card
    {
        private const int damagePointsInitial = 120;
        private const int healthPointsInitial = 5;

        public TrapCard(string name)
            : base(name, damagePointsInitial, healthPointsInitial)
        {
        }       
    }
}
