using System.Diagnostics.Metrics;
using Avalonia.Controls;
using Avalonia.Input;

namespace CookieClicker_Avalonia;

public partial class MainWindow : Window
{
    private int CookieCount = 0;
    private TextBlock _CookieCounterText;
    
    public MainWindow()
    {
        InitializeComponent();
        _CookieCounterText = this.FindControl<TextBlock>("CounterText");
    }

    private void CookieClicked (object? sender, PointerPressedEventArgs e)
    {
        CookieCount++;
        _CookieCounterText.Text = "Clicks: " + (CookieCount);
        
    }
}