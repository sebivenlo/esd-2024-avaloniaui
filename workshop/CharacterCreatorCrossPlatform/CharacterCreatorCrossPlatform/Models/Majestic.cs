using System.Collections.Generic;

namespace CharacterCreator.Models;

class Majestic : IClassChoice
{
    private Dictionary<string, int> stats;
    public Majestic()
    {
        this.stats = ((IClassChoice)this).SetStats(10, 12, 10, 9, 14);
    }

    string IClassChoice.ClassName => this.GetType().Name;

    public Dictionary<string, int> GetStats()
    {
        return this.stats;
    }
}