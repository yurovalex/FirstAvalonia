using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;

using Avalonia.Markup.Xaml;
using MsBox.Avalonia.Enums;
using MsBox.Avalonia;
using Tmds.DBus.Protocol;

namespace MyApp;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        var button = this.FindControl<Button>("CloseWindowButton");
#pragma warning disable CS8602 // Dereference of a possibly null reference.
        button.Click += Button_Click;
#pragma warning restore CS8602 // Dereference of a possibly null reference.

        var button2 = this.FindControl<Button>("MessageButton");
#pragma warning disable CS8602 // Dereference of a possibly null reference.
        button2.Click += Button_Click2;
#pragma warning restore CS8602 // Dereference of a possibly null reference.

    }
    private void Button_Click(object? sender, RoutedEventArgs e)
    {
        this.Close();
    }
    private void Button_Click2(object? sender, RoutedEventArgs e)
    {
        //Package  Manager
        //
        //NuGet\Install-Package MessageBox.Avalonia -Version 3.2.0

        var box = MessageBoxManager
             .GetMessageBoxStandard("Сообщение", "Тестирование сообщения (Да/Нет)",
                 ButtonEnum.YesNo);

        var result = box.ShowAsync();

    }
}