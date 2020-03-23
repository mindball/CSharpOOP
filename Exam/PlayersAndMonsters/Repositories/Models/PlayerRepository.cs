using PlayersAndMonsters.Models.Players.Contracts;
using PlayersAndMonsters.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayersAndMonsters.Repositories.Models
{
    public class PlayerRepository : IPlayerRepository
    {
        private List<IPlayer> players = new List<IPlayer>();

        public int Count => this.players.Count;

        public IReadOnlyCollection<IPlayer> Players => players.AsReadOnly();

        public void Add(IPlayer player)
        {
            if(player is null)
            {
                throw new ArgumentException("Player cannot be null");
            }

            if(players.Any(
                x => x.Username.Equals(player.Username)))
            {
                new ArgumentException($"Player {player.Username} already exists!");
            }

            this.players.Add(player);
        }

        public IPlayer Find(string username)
        {
            return this.players.FirstOrDefault(x => x.Username.Equals(username));
        }

        public bool Remove(IPlayer player)
        {
            if (player is null)
            {
                throw new ArgumentException("Player cannot be null");
            }

            this.players.Remove(player);
            return true;
        }
    }
}
