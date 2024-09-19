using Avalonia.Controls;
using Avalonia.Interactivity;
using System;
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
        //Debug.WriteLine("Glenn Verstraelen has invited you for the quest of The Holy Grail!");
        if (celsius == null)
        {

        }
        else 
        {
            if (Double.TryParse(celsius.Text, out double C))
            {
                var F = C * (9d / 5d) + 32;
                fahrenheit.Text = F.ToString("0.0");
            }
            else
            {
                celsius.Text = "0";
                fahrenheit.Text = "0";
            }
        }
        
        
    }

    private void InviteToQuest2(object? sender, Avalonia.Controls.TextChangingEventArgs e)
    {
        InviteToQuest(sender, e);
    }
}
