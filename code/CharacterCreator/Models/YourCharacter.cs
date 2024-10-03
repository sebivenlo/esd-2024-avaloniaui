using System.Collections.Generic;

namespace CharacterCreator.Models;

class YourCharacter
{
  private string name;
  private string gender;
  private string quote;
  private int height;
  private int width;

  private IClassChoice chosenClass;

  public YourCharacter(string name, string gender, string quote, int height, int width, IClassChoice _class)
  {
    this.name = name;
    this.gender = gender;
    this.quote = quote;
    this.height = height;
    this.width = width;
    this.chosenClass = _class;
  }

  public string Name
  { 
    get {return name; }
    set {name = value; }
  }

  public string Gender
  {
    get {return gender;}
    set {gender = value;}
  }

  public string Quote
  { 
    get {return quote; }
    set {quote = value; }
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

  public IClassChoice ChosenClass
  {
    get {return chosenClass; }
    set {chosenClass = value; }
  }
}
