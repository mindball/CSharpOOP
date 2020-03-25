namespace PlayersAndMonsters.Repositories
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using Models.Players.Contracts;
    using Contracts;


    public class PlayerRepository : IPlayerRepository
    {
        private Dictionary<string, IPlayer> players;
        public PlayerRepository()
        {
            this.players = new Dictionary<string, IPlayer>();
        }

        public int Count => this.Players.Count;

        public IReadOnlyCollection<IPlayer> Players =>
            this.players.Values.ToList().AsReadOnly();

        public void Add(IPlayer player)
        {
            if(player == null)
            {
                throw new ArgumentException("Player cannot be null!");
            }

            if(this.players.ContainsKey(player.Username))                
            {
                new ArgumentException($"Player {player.Username} already exists!");
            }

            this.players.Add(player.Username, player);
        }

        public IPlayer Find(string username)
        {
            IPlayer player;

            if (!this.players.TryGetValue(username, out player))
                return null;

            return player;
        }

        public bool Remove(IPlayer player)
        {
            if (player == null)
            {
                throw new ArgumentException("Player cannot be null!");
            }

            return this.players.Remove(player.Username);
        }
    }
}
