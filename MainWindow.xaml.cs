using System;
using System.Windows;
using System.Windows.Controls;

namespace TurkmenCalculator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            Display.Text += btn.Content.ToString();
        }

        private void Equals_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var result = new System.Data.DataTable().Compute(Display.Text, null);
                Display.Text = result.ToString();
            }
            catch
            {
                Display.Text = "Ýalňyşlyk";
            }
        }
    }
}
