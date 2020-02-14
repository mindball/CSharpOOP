using System;
using System.Collections.Generic;
using System.Linq;

class Player
{
    private string name; 
    private double overallSkillLevel;   

    public Player(string name, Stat endurance, Stat sprint, Stat dribble, Stat passing, Stat shooting)
    {
        this.Endurance = endurance;
        this.Name = name;
        this.Sprint = sprint;
        this.Dribble = dribble;
        this.Passing = passing;
        this.Shooting = shooting;

        CalculateAverage();
    }

    public Stat Endurance { get; private set; }
    public Stat Sprint { get; private set; }
    public Stat Dribble { get; private set; }
    public Stat Passing { get; set; }
    public Stat Shooting { get; private set; }
    

    public double OverallSkillLevel
    {
        get
        {
            return this.overallSkillLevel;
        }
        private set
        {
            this.overallSkillLevel = value;
        }
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

    public void CalculateAverage()
    {
        Type t = this.GetType();
        int count = t.GetProperties().Count(x => x.PropertyType == typeof(Stat));
        double sumOfStat = this.Endurance.Level + this.Sprint.Level + this.Dribble.Level + this.Shooting.Level + this.Passing.Level;
        
        this.OverallSkillLevel = Math.Round((sumOfStat / count), 0);
    }
    
}

