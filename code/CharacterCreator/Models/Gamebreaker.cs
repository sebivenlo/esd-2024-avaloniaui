using System.Collections.Generic;

namespace CharacterCreator.Models;

class Gamebreaker : IClassChoice
{
    private Dictionary<string, int> stats;

    public Gamebreaker()
    {
        this.stats = new Dictionary<string, int>()
        {
            {"Vitality", 1},
            {"Endurance", 1},
            {"Strength", 1},
            {"Skill", 1},
            {"Arcane", 1},
        };
    }

    string IClassChoice.ClassName => this.GetType().Name;

    public Dictionary<string, int> GetStats()
    {
        return this.stats;
    }
}