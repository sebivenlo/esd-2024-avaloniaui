using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Diagnostics;

namespace GetStartedApp2.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();
    }

    public void InviteToQuest(object source, RoutedEventArgs args)
    {
        Debug.WriteLine("Glenn Verstraelen has invited you for the quest of The Holy Grail!");
    }
}
