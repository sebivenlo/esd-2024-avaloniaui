using System.Collections.Generic;
using CharacterCreator.Models;
using System;
using System.Linq;
using System.Reflection;
using System.ComponentModel;

namespace CharacterCreator.ViewModels;

public class MainWindowViewModel : ViewModelBase, INotifyPropertyChanged
{
// #pragma warning disable CA1822 // Mark members as static
    // public string Greeting => "Welcome to Avalonia!";
// #pragma warning restore CA1822 // Mark members as static
    
    private List<IClassChoice?> _classChoices;

    public List<IClassChoice?> ClassChoices
    {
        get => _classChoices;
        set
        {
            _classChoices = value;
            OnPropertyChanged(nameof(ClassChoices));
        }
    }

    private IClassChoice _selectedClass;
    public IClassChoice SelectedClass
    {
        get => _selectedClass;
        set
        {
            _selectedClass = value;
            OnPropertyChanged(nameof(SelectedClass));
        }
    }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
    public MainWindowViewModel()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
    {
        LoadClassChoices();
#pragma warning disable CS8601 // Possible null reference assignment.
        SelectedClass = ClassChoices.First();
#pragma warning restore CS8601 // Possible null reference assignment.
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

#pragma warning disable CS8612 // Nullability of reference types in type doesn't match implicitly implemented member.
    public new event PropertyChangedEventHandler PropertyChanged;
#pragma warning restore CS8612 // Nullability of reference types in type doesn't match implicitly implemented member.
    protected new virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
