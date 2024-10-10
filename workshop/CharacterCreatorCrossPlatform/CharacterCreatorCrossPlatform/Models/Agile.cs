using System.Collections.Generic;

namespace CharacterCreator.Models;

class Agile : IClassChoice
{
    private Dictionary<string, int> stats;
    public Agile()
    {
        this.stats = ((IClassChoice)this).SetStats(9, 12, 9, 15, 8);
    }

    string IClassChoice.ClassName => this.GetType().Name;

    public Dictionary<string, int> GetStats()
    {
        return this.stats;
    }
}