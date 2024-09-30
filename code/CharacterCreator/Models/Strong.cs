using System.Collections.Generic;

namespace CharacterCreator.Models;

class Strong : IClassChoice
{
    private Dictionary<string, int> stats;
    public Strong()
    {
        this.stats = new Dictionary<string, int>()
        {   
            {"Vitality", 12},
            {"Endurance", 11},
            {"Strength", 15},
            {"Skill", 9},
            {"Arcane", 7},
        };
    }

    string IClassChoice.ClassName => this.GetType().Name;

    public Dictionary<string, int> GetStats()
    {
        return this.stats;
    }
}