namespace PlayersAndMonsters.Models.Players.Models
{
    using System;

    using PlayersAndMonsters.Models.Players.Contracts;
    using PlayersAndMonsters.Repositories.Contracts;

    public abstract class Player : IPlayer
    {
        private string userName;
        private int health;
        private bool isDead;

        public Player(ICardRepository cardRepository, string username, int health)
        {
            this.CardRepository = cardRepository;
            this.Username = username;
            this.Health = health;
        }

        public ICardRepository CardRepository { get; }
        public string Username
        {
            get => this.userName;
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Player's username cannot be null or an empty string.");
                }

                this.userName = value;
            }
        }
        public int Health
        {
            get => this.health;
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Player's health bonus cannot be less than zero.");
                }

                this.health = value;
            }
        }
        public bool IsDead
        {
            get => this.isDead;
            set
            {
                this.isDead = value;
            }                
        }

        public void TakeDamage(int damagePoints)
        {
            if(damagePoints < 0)
            {
                throw new ArgumentException("Damage points cannot be less than zero.");
            }

            int result = this.Health - damagePoints;
            if (result < 0)
            {
                this.IsDead = true;
                this.Health = 0;
            }
            else
            {
                this.Health -= damagePoints;
            }
        }
    }
}
