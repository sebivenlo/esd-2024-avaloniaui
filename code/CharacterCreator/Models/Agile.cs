using System.Collections.Generic;

namespace CharacterCreator.Models;

class Agile : IClassChoice
{
    private Dictionary<string, int> stats;
    public Agile()
    {
        this.stats = new Dictionary<string, int>()
        {   
            {"Vitality", 9},
            {"Endurance", 12},
            {"Strength", 9},
            {"Skill", 15},
            {"Arcane", 8},
        };
    }

    string IClassChoice.ClassName => this.GetType().Name;

    public Dictionary<string, int> GetStats()
    {
        return this.stats;
    }
}