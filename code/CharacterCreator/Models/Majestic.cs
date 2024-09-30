using System.Collections.Generic;

namespace CharacterCreator.Models;

class Majestic : IClassChoice
{
    private Dictionary<string, int> stats;
    public Majestic()
    {
        this.stats = new Dictionary<string, int>()
        {   
            {"Vitality", 10},
            {"Endurance", 12},
            {"Strength", 10},
            {"Skill", 9},
            {"Arcane", 14},
        };
    }

    string IClassChoice.ClassName => this.GetType().Name;

    public Dictionary<string, int> GetStats()
    {
        return this.stats;
    }
}