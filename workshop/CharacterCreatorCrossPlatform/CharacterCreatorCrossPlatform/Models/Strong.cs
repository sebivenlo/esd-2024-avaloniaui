using System.Collections.Generic;

namespace CharacterCreator.Models;

class Strong : IClassChoice
{
    private Dictionary<string, int> stats;
    public Strong()
    {
        this.stats = ((IClassChoice)this).SetStats(12, 11, 15, 9, 7);
    }

    string IClassChoice.ClassName => this.GetType().Name;

    public Dictionary<string, int> GetStats()
    {
        return this.stats;
    }
}