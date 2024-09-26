using System;
using System.Diagnostics;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;

namespace CharacterCreator.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    public void ButtonClicked(object source, RoutedEventArgs args)
    {
        
        if(celsius == null)
        {

        }

#pragma warning disable CS8602 // Dereference of a possibly null reference.
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
#pragma warning restore CS8602 // Dereference of a possibly null reference.
    }

//         private void ToFahrenheit(object? sender, Avalonia.Controls.TextChangingEventArgs e)
//     {
// #pragma warning disable CS8604 // Possible null reference argument.
//         ButtonClicked(sender, e);
// #pragma warning restore CS8604 // Possible null reference argument.
//     }

    private void ToFahrenheit(object sender, KeyEventArgs e) {
  
        if(celsius == null)
        {

        }

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