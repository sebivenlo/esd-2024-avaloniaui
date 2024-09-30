using Avalonia.Controls;
using ReactiveUI;
using System.Reactive;
using CharacterCreator.Views;

namespace CharacterCreator.ViewModels;

public class MainWindowViewModel : ReactiveObject
{
// #pragma warning disable CA1822 // Mark members as static
    // public string Greeting => "Welcome to Avalonia!";
// #pragma warning restore CA1822 // Mark members as static

    private object _currentPage = new MainWindow();
    public object CurrentPage
    {
        get => _currentPage;
        set => this.RaiseAndSetIfChanged(ref _currentPage, value);
    }

    public ReactiveCommand<Unit, Unit> SwapToCharacterView { get; }

    public MainWindowViewModel()
        {
            // Initially set the CurrentPage to the character creator page
            CurrentPage = new MainWindow();

            // Command to swap to the blank page
            SwapToCharacterView = ReactiveCommand.Create(() => {
                CurrentPage = new CharacterView();
            });
        }
}
