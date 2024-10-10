using System.Collections.Generic;

namespace CharacterCreator.Models;

class Gamebreaker : IClassChoice
{
    private Dictionary<string, int> stats;

    public Gamebreaker()
    {
        this.stats = ((IClassChoice)this).SetStats(1, 1, 1, 1, 1);
    }

    string IClassChoice.ClassName => this.GetType().Name;

    public Dictionary<string, int> GetStats()
    {
        return this.stats;
    }
}