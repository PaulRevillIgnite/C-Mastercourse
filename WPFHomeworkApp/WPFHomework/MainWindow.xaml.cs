﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFHomework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void helloButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Hello {firstNameTextBox.Text} {lastNameTextBox.Text}");
        }

        private void firstNameTextBox_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            firstNameTextBox.Text = string.Empty;
        }
    }
}