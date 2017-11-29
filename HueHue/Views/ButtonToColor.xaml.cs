﻿using HueHue.Helpers;
using System.Windows;
using System.Windows.Controls;
using Media = System.Windows.Media;

namespace HueHue.Views
{
    /// <summary>
    /// Interaction logic for ButtonToColor.xaml
    /// </summary>
    public partial class ButtonToColor : UserControl
    {
        bool expanded = false;

        public ButtonToColor(JoystickButtonToColor buttonColor)
        {
            InitializeComponent();

            this.colorPanel.InitialColorBrush = new Media.SolidColorBrush(Media.Color.FromArgb(0, buttonColor.Color.R, buttonColor.Color.G, buttonColor.Color.B));
            this.colorPanel.SelectedColorBrush = new Media.SolidColorBrush(Media.Color.FromArgb(0, buttonColor.Color.R, buttonColor.Color.G, buttonColor.Color.B));
            this.labelBindedButton.DataContext = buttonColor.Button;
        }

        private void Button_Expand_Click(object sender, RoutedEventArgs e)
        {
            expanded = !expanded;

            if (expanded)
            {
                colorPanel.Visibility = Visibility.Visible;
            }
            else
            {
                colorPanel.Visibility = Visibility.Collapsed;
            }
        }
    }
}
