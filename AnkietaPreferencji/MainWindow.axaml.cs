using System;
using System.Diagnostics;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace AnkietaPreferencji;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        Button_Submit.Click += Submit_Clicked;
    }
    
    private void Submit_Clicked(object sender, RoutedEventArgs e)
    {
        try
        {
            int counter = 0;
            if (CheckBox_Question1.IsChecked == true)
            {
                counter++;
            }
            if (CheckBox_Question2.IsChecked == true)
            {
                counter++;
            }
            if (CheckBox_Question3.IsChecked == true)
            {
                counter++;
            }
            
            var zainteresowanie = (ComboBox_Intrest.SelectedItem as ComboBoxItem)?.Content?.ToString() ?? "Nie wybrano";
                
            TextBlock_Summary.Text = $"Imię: {TextBox_InputName.Text}\nZainteresowanie: {zainteresowanie}\nOdpowiedziałeś TAK {counter} razy.";

        }
        catch (Exception ex)
        {
            TextBlock_Summary.Text = ex.Message;
        }
    }
    
}