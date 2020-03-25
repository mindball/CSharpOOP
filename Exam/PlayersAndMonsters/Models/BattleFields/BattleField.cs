namespace PlayersAndMonsters.Models.BattleFields
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Contracts;
    using Players;
    using Players.Contracts;    

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
            if (enemyPlayer is Beginner)
            {
                //TODO check return
                AssingBeginnerBonus(enemyPlayer);
            }

            attackPlayer = this.BoostPlayer(attackPlayer);
            enemyPlayer = this.BoostPlayer(enemyPlayer);

            //TODO check result of damage points of cards
            while(!attackPlayer.IsDead && !enemyPlayer.IsDead)
            {
                int attackPlayerSummaryDamagePoints =
                PlayerSumDamagePoints(attackPlayer);
                enemyPlayer.TakeDamage(attackPlayerSummaryDamagePoints);

                if (enemyPlayer.IsDead)
                    break;

                int enemyPlayerSummaryDamagePoints =
                PlayerSumDamagePoints(enemyPlayer);
                attackPlayer.TakeDamage(enemyPlayerSummaryDamagePoints);

                //there is no point because while condition check player is alive
                //if (attackPlayer.IsDead)
                //    return;
            }            
        }
        private void AssingBeginnerBonus(IPlayer player)
        {
            player.Health += beginnerHealthBonus;
            foreach (var card in player.CardRepository.Cards)
            {
                card.DamagePoints += damagePointsOfCardsBonus;
            }
        }

        private  IPlayer BoostPlayer(IPlayer player)
        {
            player.Health += player.CardRepository
                             .Cards.Select(x => x.HealthPoints).Sum();

            return player;
        }


        private int PlayerSumDamagePoints(IPlayer player)
        {
            return player.CardRepository.Cards.Sum(d => d.DamagePoints);
        }
    }
}
