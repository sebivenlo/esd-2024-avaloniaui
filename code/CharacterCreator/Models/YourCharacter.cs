using System.Collections.Generic;

namespace CharacterCreator.Models;

class YourCharacter
{
  private string name;
  private int height;
  private int width;

  private Dictionary<string, int> stats =  new Dictionary<string, int>();

  public YourCharacter(string name, int height, int width, Dictionary<string, int> stats)
  {
    this.name = name;
    this.height = height;
    this.width = width;
    this.stats = stats;
  }

  public string Name
  { 
    get {return name; }
    set {name = value; }
  }

  public int Height
  { 
    get {return height; }
    set {height = value; }
  }

  public int Width
  { 
    get {return width; }
    set {width = value; }
  }

  public Dictionary<string, int> Stats
  {
    get {return stats;}
  }
}
