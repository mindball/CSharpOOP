using System;
using System.Collections.Generic;
using System.Linq;

class FootballTeamGenerator
{
    static Dictionary<string, Team> teamCollection = new Dictionary<string, Team>();    

    static void Main()
    {
        string line = Console.ReadLine();
        Team newTeam;
        while (!line.Equals("END"))
        {
            string[] tokes = line.Split(';');
            string command = tokes[0];
                        
            try
            {
                ProcessCommand(command, tokes);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            line = Console.ReadLine();
        }
    }

    private static void PrintRatting(string teamName)
    {
        if (CheckExistTeam(teamName))
        {
            Console.WriteLine(teamCollection[teamName]);
        }
    }

    private static void RemovePlayerFromTeam(string existTeam, string playerName)
    {
        if(CheckExistTeam(existTeam))
        {
            Team team = teamCollection[existTeam];
            team.RemovePlayer(playerName);
        }
    }

    private static bool CheckExistTeam(string existTeam)
    {       
        if (!teamCollection.ContainsKey(existTeam))
            throw new InvalidOperationException($"Team {existTeam} does not exist.");

        return true;
    }

    private static void AddPlayerToTeam(string teamName, string playerName, int endurance, int sprint, int dribble, int passing, int shooting)
    {
        if(CheckExistTeam(teamName))
        {
            Player newPlayer = new Player(playerName,
            new Stat(nameof(endurance).First().ToString().ToUpper() + String.Join("", nameof(endurance).Skip(1)), endurance),
            new Stat(nameof(sprint).First().ToString().ToUpper() + String.Join("", nameof(sprint).Skip(1)), sprint),
            new Stat(nameof(dribble).First().ToString().ToUpper() + String.Join("", nameof(dribble).Skip(1)), dribble),
            new Stat(nameof(passing).First().ToString().ToUpper() + String.Join("", nameof(passing).Skip(1)), passing),
            new Stat(nameof(shooting).First().ToString().ToUpper() + String.Join("", nameof(shooting).Skip(1)), shooting));

            teamCollection[teamName].AddPlayer(newPlayer);
        }
        
    }

    private static void CreateTeam(string nameOfTeam)
    {
        Team newTeam = new Team(nameOfTeam);
        teamCollection.Add(nameOfTeam, newTeam);
    }

    public static void ProcessCommand(string command, string[] tokens)
    {
        switch (command)
        {
            case "Team":
                CreateTeam(tokens[1]);
                break;
            case "Add":
                AddPlayerToTeam(
                    tokens[1],
                    tokens[2],
                    int.Parse(tokens[3]),
                    int.Parse(tokens[4]),
                    int.Parse(tokens[5]),
                    int.Parse(tokens[6]),
                    int.Parse(tokens[7])
                    );
                break;
            case "Remove":
                RemovePlayerFromTeam(tokens[1], tokens[2]);
                break;
            case "Rating":
                PrintRatting(tokens[1]);
                break;
            default:
                break;
        }
    }
}

