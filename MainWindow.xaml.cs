using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace pr18afela
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void otvet_Click(object sender, RoutedEventArgs e)
        {
            // Составить программу, которая бы выдавала название месяца, ъ
            // следующего за введенным месяцем 
            // (с учетом того, что за декабрем идет январь).
            if (January.IsChecked.Value) Otvet.Text = "Февраль";
            if (February.IsChecked.Value) Otvet.Text = "Март";
            if (March.IsChecked.Value) Otvet.Text = "Апрель";
            if (April.IsChecked.Value) Otvet.Text = "Май";
            if (May.IsChecked.Value) Otvet.Text = "Июнь";
            if (June.IsChecked.Value) Otvet.Text = "Июль";
            if (July.IsChecked.Value) Otvet.Text = "Август";
            if (August.IsChecked.Value) Otvet.Text = "Сентябрь";
            if (September.IsChecked.Value) Otvet.Text = "Октябрь";
            if (October.IsChecked.Value) Otvet.Text = "Ноябрь";
            if (November.IsChecked.Value) Otvet.Text = "Декабрь";
            if (December.IsChecked.Value) Otvet.Text = "Январь";

        }


        private void avtomot_Click(object sender, RoutedEventArgs e)
        {
            if (avtomat.IsChecked.Value) Avtomat.IsEnabled = true;  // Если стоит галочка, то панель включена
            else Avtomat.IsEnabled = false;  // Иначе панель выключена
        }
        private void ruchnoy_Click (object sender, RoutedEventArgs e)
        {
            if (ruchnoy.IsChecked.Value) Ruchnoy.IsEnabled = true;  // Если стоит галочка, то панель включенаЫ
            else Ruchnoy.IsEnabled = false;  // Иначе панель выключена
        }

        private void January1_Checked(object sender, RoutedEventArgs e)
        {
            Otvet1.Text = "Февраль";  // Вывод месяца "февраль"

        }

        private void February1_Checked(object sender, RoutedEventArgs e)
        {
            Otvet1.Text = "Март";   // Вывод месяца "март"
        }

        private void March1_Checked(object sender, RoutedEventArgs e)
        {
            Otvet1.Text = "Апрель";   // Вывод месяца "апрель"
        }

        private void April1_Checked(object sender, RoutedEventArgs e)
        {
            Otvet1.Text = "Май";   // Вывод месяца "май"
        }

        private void May1_Checked(object sender, RoutedEventArgs e)
        {
            Otvet1.Text = "Июнь";  // Вывод месяца "июнь"
        }

        private void June1_Checked(object sender, RoutedEventArgs e)
        {
            Otvet1.Text = "Июль";   // Вывод месяца "июль"
        }

        private void July1_Checked(object sender, RoutedEventArgs e)
        {
            Otvet1.Text = "Август";  // Вывод месяца "август"
        }

        private void August1_Checked(object sender, RoutedEventArgs e)
        {
            Otvet1.Text = "Сентябрь";  // Вывод месяца "сентябрь"
        }

        private void September1_Checked(object sender, RoutedEventArgs e)
        {
            Otvet1.Text = "Октябрь";  // Вывод месяца "октябрь"
        }

        private void October1_Checked(object sender, RoutedEventArgs e)
        {
            Otvet1.Text = "Ноябрь";  // Вывод месяца "ноябрь"
        }

        private void November1_Checked(object sender, RoutedEventArgs e)
        {
            Otvet1.Text = "Декабрь";  // Вывод месяца "декабрь"
        }

        private void December1_Checked(object sender, RoutedEventArgs e)
        {
            Otvet1.Text = "Январь";  // Вывод месяца "январь"
        }
    }
}
