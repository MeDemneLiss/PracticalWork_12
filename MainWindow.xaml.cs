using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace PracticalWork_12
{
    public partial class MainWindow : Window
    {
        DispatcherTimer timer;
        public MainWindow()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Tick += Timer_Tick;
            timer.Interval = new TimeSpan(0, 0, 0, 1, 0);
            timer.IsEnabled = true;
        }

        private void ThreeDigitNumber_Click(object sender, RoutedEventArgs e)
        {
            threeDigitNumber.Focus();
            if (int.TryParse(threeDigitNumber.Text, out int variable) && variable< 1000 && variable >= 100)
            {
                int unitsValue = variable % 10;
                int dozensValue = variable / 10 % 10;
                units.Text = Convert.ToString(unitsValue);
                dozens.Text = Convert.ToString(dozensValue);
            }
            else
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void SideSquare_Click(object sender, RoutedEventArgs e)
        {
            sideOfSquare.Focus();
            if (double.TryParse(sideOfSquare.Text, out double variable))
            {
                double perimeter = variable * 4;
                double area = variable * variable;
                squareArea.Text = Convert.ToString(area);
                perimetrSquare.Text = Convert.ToString(perimeter);
            }
            else
            {
                MessageBox.Show("Введены неверные даные", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;
            time.Text = d.ToString("HH:mm");
            date.Text = d.ToString("dd.MM.yyyy");
        }
        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            squareArea.Clear();
            perimetrSquare.Clear();
            units.Clear();
            dozens.Clear();
            threeDigitNumber.Clear();
            sideOfSquare.Clear();
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Самсаков Андрей Александрович ИСП-31\nПрактическая работа №12\nВариант 1\nРеализовать расчет задачи:\n * Дана сторона квадрата a.Найти его площадь и периметр.\n * Дано трехзначное число.Вывести вначале его последнюю цифру(единицы), а затем — его среднюю цифру(десятки). ", "Информация о программе", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void SideOfSquare_TextChanged(object sender, TextChangedEventArgs e)
        {
            squareArea.Clear();
            perimetrSquare.Clear();
        }

        private void threeDigitNumber_TextChanged(object sender, TextChangedEventArgs e)
        {
            units.Clear();
            dozens.Clear();
        }
    }
}
