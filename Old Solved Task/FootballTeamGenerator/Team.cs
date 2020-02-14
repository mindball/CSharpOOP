using System;
using System.Collections.Generic;
using System.Linq;

class Team
{
    private string name;
    private Dictionary<string, Player> players;
    private double rating;

    public Team(string name)
    {
        this.Name = name;
        this.players = new Dictionary<string, Player>();
        this.rating = 0.0;
    }

    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            if (string.IsNullOrEmpty(value) &&
                string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("A name should not be emtpy");
            this.name = value;
        }
    }    

    public void AddPlayer(Player player)
    {
        this.rating += player.OverallSkillLevel;
        this.players.Add(player.Name, player);
    }

    public void RemovePlayer(string playerName)
    {
        if (!this.players.ContainsKey(playerName))
            throw new InvalidOperationException($"Player {playerName} is not in {this.Name} team.");

        Player player = players[playerName];

        this.rating -= player.OverallSkillLevel;
        this.players.Remove(playerName);
    }

    public override string ToString()
    {
        return $"{this.Name} - {this.rating}";
    }
}

