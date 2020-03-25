namespace PlayersAndMonsters.Core
{
    using System;
    using System.Text;

    using Common;
    using Contracts;
    using Core.Factories.Contracts;
    using Models.Cards.Contracts;
    using Models.Players.Contracts;
    using Repositories.Contracts;
    using Models.BattleFields;

    public class ManagerController : IManagerController
    {
        private ICardRepository cardRepository;
        private IPlayerRepository playerRepository;
        private IPlayerFactory createPlayer;
        private ICardFactory createCard;

        public ManagerController(ICardRepository cardRepository,
            IPlayerRepository playerRepository,
            IPlayerFactory createPlayer,
            ICardFactory createCard)
        {
            this.createPlayer = createPlayer;
            this.createCard = createCard;
            this.cardRepository = cardRepository;
            this.playerRepository = playerRepository;
        }

        public string AddPlayer(string type, string username)
        {
            IPlayer newPlayer = this.createPlayer.CreatePlayer(type, username);
            this.playerRepository.Add(newPlayer);

            string message = string.Format(
                ConstantMessages.SuccessfullyAddedPlayer,
                newPlayer.GetType().Name,
                newPlayer.Username);

            return message;
        }

        public string AddCard(string type, string name)
        {
            ICard newCard = this.createCard.CreateCard(type, name);
            this.cardRepository.Add(newCard);

            string message = string.Format(
                ConstantMessages.SuccessfullyAddedCard,
                newCard.GetType().Name,
                newCard.Name);

            return message;
        }

        public string AddPlayerCard(string username, string cardName)
        {
            //TODO: test
            //this.playerRepository.Find(username)
            //    .CardRepository
            //    .Add(this.cardRepository.Find(cardName));
            var user = this.playerRepository.Find(username);
            var card = this.cardRepository.Find(cardName);

            user.CardRepository.Add(card);

            string message = string.Format(
                ConstantMessages.SuccessfullyAddedPlayerWithCards,
                cardName,
                username);

            return message;
        }

        public string Fight(string attackUser, string enemyUser)
        {
            var attacker = this.playerRepository.Find(attackUser);
            var enemy = this.playerRepository.Find(enemyUser);

            BattleField battleField = new BattleField();
            battleField.Fight(attacker, enemy);

            string message = string.Format(
                ConstantMessages.FightInfo,
                attackUser, enemyUser);

            return message;
        }

        public string Report()
        {
            StringBuilder message = new StringBuilder();
            foreach (var player in this.playerRepository.Players)
            {
                message.AppendLine(
                    string.Format(ConstantMessages.PlayerReportInfo,
                    player.Username,
                    player.Health,
                    player.CardRepository.Count));

                if (player.CardRepository.Count > 0)
                {
                    foreach (var card in player.CardRepository.Cards)
                    {
                        message.AppendLine(string.Format(ConstantMessages.CardReportInfo,
                            card.Name,
                            card.DamagePoints));
                    }
                }

                message.AppendLine();
                message.AppendLine(ConstantMessages.DefaultReportSeparator);
                message.AppendLine();
            }

            return message.ToString();
        }
    }
}
