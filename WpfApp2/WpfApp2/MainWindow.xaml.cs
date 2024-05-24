using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var hour = TextBox1.Text;

            if(TextBox1.Text.Length != 0 )
            {
                if (Regex.IsMatch(TextBox1.Text, @"^\d+$"))
                {
                    if (RadioButton1.IsChecked == true)
                    {
                        var price = 150;
                        var cost = price * int.Parse(hour);
                        if (myCheckBox.IsChecked == true)
                        {
                            var deduction = (cost * 13) / 100;
                            TextBlock1.Text = $"{cost}";
                            TextBlock2.Text = $"{deduction}";
                        }
                        else
                        {
                            TextBlock1.Text = $"{cost}";
                            TextBlock2.Text = "";
                        }
                    }
                    else if (RadioButton2.IsChecked == true)
                    {
                        var price = 250;
                        var cost = price * int.Parse(hour);
                        if (myCheckBox.IsChecked == true)
                        {
                            var deduction = (cost * 13) / 100;
                            TextBlock1.Text = $"{cost}";
                            TextBlock2.Text = $"{deduction}";
                        }
                        else
                        {
                            TextBlock1.Text = $"{cost}";
                            TextBlock2.Text = "";
                        }
                    }
                    else if (RadioButton3.IsChecked == true)
                    {
                        var price = 350;
                        var cost = price * int.Parse(hour);
                        if (myCheckBox.IsChecked == true)
                        {
                            var deduction = (cost * 13) / 100;
                            TextBlock1.Text = $"{cost}";
                            TextBlock2.Text = $"{deduction}";
                        }
                        else
                        {
                            TextBlock1.Text = $"{cost}";
                            TextBlock2.Text = "";
                        }
                    }
                }
                else
                {
                    MessageBox.Show("В поле колличество часов должны быть только числа!", "Ошибка");
                }
            }
            else
            {
                TextBlock1.Text = "";
                TextBlock2.Text = "";
                MessageBox.Show("Впешите колличество часов!", "Ошибка");
            }
            
        }
    }
}
