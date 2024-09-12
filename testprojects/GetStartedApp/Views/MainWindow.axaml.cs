using Avalonia.Controls;
using Avalonia.Interactivity;
using System;
using System.Diagnostics;

namespace GetStartedApp.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    public void ButtonClicked(object source, RoutedEventArgs args)
    {
        if (Double.TryParse(celsius.Text, out double C))
        {
            double F = C * (9d / 5d) + 32;
            fahrenheit.Text = F.ToString("0.0");
        }
        else
        {
            celsius.Text = "0";
            fahrenheit.Text = "0";

        }

        Debug.WriteLine($"Click! Celsius={celsius.Text}");
    }

    private void TextBox_TextChanging(object? sender, Avalonia.Controls.TextChangingEventArgs e)
    {
        ButtonClicked(sender, e);
    }
}