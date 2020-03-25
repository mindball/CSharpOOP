namespace PlayersAndMonsters.Models.Players
{
    using System;

    using Contracts;
    using PlayersAndMonsters.Common;
    using Repositories.Contracts;

    public abstract class Player : IPlayer
    {
        private string userName;
        private int health;       

        protected Player(ICardRepository cardRepository, string username, int health)
        {
            this.CardRepository = cardRepository;
            this.Username = username;
            this.Health = health;
        }

        public ICardRepository CardRepository { get; }
        public string Username
        {
            get => this.userName;
            private set
            {               
                Validator.ThrowIfStringIsNullOrEmpty(value,
                    "Player's username cannot be null or an empty string.");

                this.userName = value;
            }
        }
        public int Health
        {
            get => this.health;
            set
            {               
                Validator.ThrowIfNumberIsOrNegative(value,
                    "Player's health bonus cannot be less than zero.");

                this.health = value;
            }
        }
        public bool IsDead => this.Health <= 0;

        public void TakeDamage(int damagePoints)
        {
            if (damagePoints < 0)
            {
                throw new ArgumentException("Damage points cannot be less than zero.");
            }

            this.Health = Math.Max(this.Health - damagePoints, 0);
        }
    }
}
