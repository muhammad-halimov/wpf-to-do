using System;
using Avalonia.Controls;
using Tmds.DBus.Protocol;

namespace to_do;

public partial class MainWindow : Window
{
    private static int _width = 700; 
    private static int _height = 700;
    private static double _oldWidth = 700; 
    private static double _oldHeight = 700; 
    public MainWindow()
    {
        InitializeComponent();

        Width = _width;
        Height = _height;
        
        MinHeight = Height - 1;
        MinWidth = Width - 1;
    }
    
    static int SizeDifference(double widht, double heght, double newWidht, double newHeght)
    {
        double difference = newWidht / widht + newHeght / heght;
        return (int)Math.Round(difference, 1);
    }

    private void WindowBase_OnResized(object? sender, WindowResizedEventArgs e)
    {
        if (Width > _oldWidth || Height > _oldHeight)
        {
            HeaderTextBlock.FontSize += SizeDifference(_width, _height, Width, Height);

        }
        else if (Width < _oldWidth || Height < _oldHeight)
        {
            HeaderTextBlock.FontSize -= SizeDifference(_width, _height, Width, Height);
        }
        else return;
        
        _oldWidth = Width;
        _oldHeight = Height;
    }
}