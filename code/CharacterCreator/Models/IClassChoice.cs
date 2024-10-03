using System.Collections.Generic;

namespace CharacterCreator.Models;

public interface IClassChoice
{
    string ClassName { get; }
    Dictionary<string, int> GetStats();

    Dictionary<string, int> SetStats(int vit, int end, int str, int ski, int arc, int hei, int wid)
    {
        return new Dictionary<string, int>()
        {
            {"Vitality", vit},
            {"Endurance", end},
            {"Strength", str},
            {"Skill", ski},
            {"Arcane", arc},
            {"Height", hei},
            {"Width", wid}
        };
    }
}