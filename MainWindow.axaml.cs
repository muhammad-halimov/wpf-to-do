using Avalonia.Controls;

namespace to_do;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        MinHeight = Height - 1;
        MinWidth = Width - 1;
    }

    private static int ChangingTextSize(int canvasSize, int fontSize)
    {
        int newSize = 0;
        
        return newSize;
    }

    private void Control_OnSizeChanged(object? sender, SizeChangedEventArgs e)
    {
        
    }
}