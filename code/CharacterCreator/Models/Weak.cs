using System.Collections.Generic;

namespace CharacterCreator.Models;

class Weak : IClassChoice
{
    private Dictionary<string, int> stats;
    public Weak()
    {
        this.stats = new Dictionary<string, int>()
        {   
            {"Vitality", 10},
            {"Endurance", 9},
            {"Strength", 10},
            {"Skill", 9},
            {"Arcane", 9},
        };
    }

    string IClassChoice.ClassName => this.GetType().Name;

    public Dictionary<string, int> GetStats()
    {
        return this.stats;
    }
}