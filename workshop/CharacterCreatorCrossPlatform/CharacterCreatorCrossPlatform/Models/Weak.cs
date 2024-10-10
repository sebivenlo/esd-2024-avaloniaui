using System.Collections.Generic;

namespace CharacterCreator.Models;

class Weak : IClassChoice
{
    private Dictionary<string, int> stats;
    public Weak()
    {
        this.stats = ((IClassChoice)this).SetStats(10, 9, 10, 9, 9);
    }

    string IClassChoice.ClassName => this.GetType().Name;

    public Dictionary<string, int> GetStats()
    {
        return this.stats;
    }
}