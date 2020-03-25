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
    using Models.BattleFields.Contracts;

    public class ManagerController : IManagerController
    {
        private ICardRepository cardRepository;
        private IPlayerRepository playerRepository;
        private IPlayerFactory playerFactory;
        private ICardFactory cardFactory;
        private IBattleField battleField;

        public ManagerController(ICardRepository cardRepository,
            IPlayerRepository playerRepository,
            IPlayerFactory createPlayer,
            ICardFactory createCard,
            IBattleField battleField)
        {
            this.playerFactory = createPlayer;
            this.cardFactory = createCard;
            this.cardRepository = cardRepository;
            this.playerRepository = playerRepository;
            this.battleField = battleField;
        }

        public string AddPlayer(string type, string username)
        {
            IPlayer newPlayer = this.playerFactory.CreatePlayer(type, username);
            this.playerRepository.Add(newPlayer);

            string message = string.Format(
                ConstantMessages.SuccessfullyAddedPlayer,
                newPlayer.GetType().Name,
                newPlayer.Username);

            return message;
        }

        public string AddCard(string type, string name)
        {
            ICard newCard = this.cardFactory.CreateCard(type, name);
            this.cardRepository.Add(newCard);

            string message = string.Format(
                ConstantMessages.SuccessfullyAddedCard,
                type,
                name);

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
             
            battleField.Fight(attacker, enemy);

            string message = string.Format(
                ConstantMessages.FightInfo,
                attacker.Health, enemy.Health);

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
                message.AppendLine(ConstantMessages.DefaultReportSeparator);               
            }

            return message.ToString().TrimEnd();
        }
    }
}
