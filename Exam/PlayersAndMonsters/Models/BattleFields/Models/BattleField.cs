namespace PlayersAndMonsters.Models.BattleFields.Models
{
    using PlayersAndMonsters.Models.BattleFields.Contracts;
    using PlayersAndMonsters.Models.Cards.Contracts;
    using PlayersAndMonsters.Models.Players.Contracts;
    using PlayersAndMonsters.Models.Players.Models;
    using PlayersAndMonsters.Repositories.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BattleField : IBattleField
    {
        private const int beginnerHealthBonus = 40;
        private const int damagePointsOfCardsBonus = 30;

        public void Fight(IPlayer attackPlayer, IPlayer enemyPlayer)
        {
            if (attackPlayer.IsDead || enemyPlayer.IsDead)
                throw new ArgumentException("Player is dead!");

            if (attackPlayer is Beginner)
            {
                //TODO check return
                AssingBeginnerBonus(attackPlayer);
            }
           if(enemyPlayer is Beginner)
            {
                //TODO check return
                AssingBeginnerBonus(enemyPlayer);
            }

            //TODO check result of damage points of cards
            int attackPlayerSummaryDamagePoints =
                PlayerSumDamagePoints(attackPlayer.CardRepository.Cards);
            enemyPlayer.TakeDamage(attackPlayerSummaryDamagePoints);
           

            if (enemyPlayer.IsDead)
                return;

            int enemyPlayerSummaryDamagePoints =
                PlayerSumDamagePoints(enemyPlayer.CardRepository.Cards);
            attackPlayer.TakeDamage(enemyPlayerSummaryDamagePoints);

            if (attackPlayer.IsDead)
                return;

        }

       

        private void AssingBeginnerBonus(IPlayer player)
        {
            player.Health += beginnerHealthBonus;
            foreach (var card in player.CardRepository.Cards)
            {
                card.DamagePoints += damagePointsOfCardsBonus;
            }
        }

        private int PlayerSumDamagePoints(IReadOnlyCollection<ICard> cards)
        {
            return cards.Sum(x => x.DamagePoints);
        }
    }
}
