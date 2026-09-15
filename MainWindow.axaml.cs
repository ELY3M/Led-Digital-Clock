using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;
using Avalonia.Threading;
using System;
using System.Timers;

namespace LEDDigitalClock;


public partial class MainWindow : Window
{

    // Make clock a field so other methods can access it
    private TextBlock clock;

    public MainWindow()
    {
        Title = "Led Digital Clock";
        Width = 600;
        Height = 150;
        Background = new SolidColorBrush(Colors.Black);
        Foreground = new SolidColorBrush(Colors.Aqua);
        FontFamily = "{StaticResource LCD}";

        var stackPanel = new StackPanel
        {
            Margin = new Thickness(10),
            Spacing = 10
        };

        clock = new TextBlock
        {
            Text = "",
            Foreground = new SolidColorBrush(Colors.Aqua),
            FontFamily = "avares://LEDDigitalClock/Assets/Fonts/lcd.ttf#LCD",
            FontSize = 75,
            HorizontalAlignment = Avalonia.Layout.HorizontalAlignment.Center,
            VerticalAlignment = Avalonia.Layout.VerticalAlignment.Center

        };

        stackPanel.Children.Add(clock);
        System.Timers.Timer timer = new System.Timers.Timer();
        timer.Interval = 1000;
        timer.Elapsed += Timer_Elapsed;
        timer.Start();

        Content = stackPanel;
    }

    private void Timer_Elapsed(object? sender, ElapsedEventArgs e)
    {
        // Use Avalonia's Dispatcher to update UI from the timer thread
        Dispatcher.UIThread.Post(() =>
        {
            clock.Text = DateTime.Now.ToString("hh:mm:ss tt");
        });
    }

}

