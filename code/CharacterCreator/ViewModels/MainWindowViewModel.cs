using System.Collections.Generic;
using CharacterCreator.Models;
using System;
using System.Linq;
using System.Reflection;
using System.ComponentModel;

namespace CharacterCreator.ViewModels;

public class MainWindowViewModel : ViewModelBase, INotifyPropertyChanged
{
    private List<IClassChoice?> _classChoices;
    // private YourCharacter character;
    public List<IClassChoice?> ClassChoices
    {
        get => _classChoices;
        set
        {
            _classChoices = value;
            // OnPropertyChanged(nameof(ClassChoices));
        }
    }

    private IClassChoice _selectedClass;
    public IClassChoice SelectedClass
    {
        get => _selectedClass;
        set
        {
            _selectedClass = value;
            // OnPropertyChanged(nameof(SelectedClass));
            UpdateStats();
        }
    }

    private bool _readOnlyOn;
    public bool ReadOnlyOn
    {
        get => _readOnlyOn;
        set
        {
            _readOnlyOn = value;
            OnPropertyChanged(nameof(ReadOnlyOn));
        }
    }

    private int _vitality;
    public int Vitality
    {
        get => _vitality;
        set
        {
            _vitality = value;
            OnPropertyChanged(nameof(Vitality));
        }
    }

    private int _height;
    public int HeightCharacter
    {
        get => _height;
        set
        {
            _height = value;
            OnPropertyChanged(nameof(HeightCharacter));
        }
    }

    private int _width;
    public int WidthCharacter
    {
        get => _width;
        set
        {
            _width = value;
            OnPropertyChanged(nameof(WidthCharacter));
        }
    }

    private int _endurance;
    public int Endurance
    {
        get => _endurance;
        set
        {
            _endurance = value;
            OnPropertyChanged(nameof(Endurance));
        }
    }

    private int _strength;
    public int Strength
    {
        get => _strength;
        set
        {
            _strength = value;
            OnPropertyChanged(nameof(Strength));
        }
    }

    private int _skill;
    public int Skill
    {
        get => _skill;
        set
        {
            _skill = value;
            OnPropertyChanged(nameof(Skill));
        }
    }

    private int _arcane;
    public int Arcane
    {
        get => _arcane;
        set
        {
            _arcane = value;
            OnPropertyChanged(nameof(Arcane));
        }
    }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
    public MainWindowViewModel()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
    {
        ReadOnlyOn = true;
        LoadClassChoices();
#pragma warning disable CS8601 // Possible null reference assignment.
        SelectedClass = ClassChoices.FirstOrDefault();
#pragma warning restore CS8601 // Possible null reference assignment.
        HeightCharacter = 200;
        WidthCharacter = 80;
    }

    private void LoadClassChoices()
    {
        var classChoiceImplementations = Assembly.GetExecutingAssembly().GetTypes()
            .Where(t => typeof(IClassChoice).IsAssignableFrom(t) && t.IsClass && !t.IsAbstract)
            .ToList();

        ClassChoices = classChoiceImplementations
            .Select(type => Activator.CreateInstance(type) as IClassChoice)
            .Where(instance => instance != null)
            .ToList();
    }

    private void UpdateStats()
    {
        if (SelectedClass != null)
        {
            var stats = SelectedClass.GetStats();

            if(SelectedClass.ClassName == "Gamebreaker")
            {
                ReadOnlyOn = false;
            } 
            else 
            {
                ReadOnlyOn = true;
                ResetHeightAndWidth();
            }

            Vitality = stats.ContainsKey("Vitality") ? stats["Vitality"] : 0;
            Endurance = stats.ContainsKey("Endurance") ? stats["Endurance"] : 0;
            Strength = stats.ContainsKey("Strength") ? stats["Strength"] : 0;
            Skill = stats.ContainsKey("Skill") ? stats["Skill"] : 0;
            Arcane = stats.ContainsKey("Arcane") ? stats["Arcane"] : 0;
        }
    }

    private void ResetHeightAndWidth()
    {
        HeightCharacter = 200;
        WidthCharacter = 80;
    }

#pragma warning disable CS8612 // Nullability of reference types in type doesn't match implicitly implemented member.
    public new event PropertyChangedEventHandler PropertyChanged;
#pragma warning restore CS8612 // Nullability of reference types in type doesn't match implicitly implemented member.

    protected new virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
