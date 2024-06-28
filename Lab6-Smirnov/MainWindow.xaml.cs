using System;
using System.Linq;
using System.Windows;

namespace ReverseArrayApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ReverseArray_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Получаем строку из InputMemo
                string input = InputMemo.Text;

                // Преобразуем строку в массив вещественных чисел
                double[] array = input.Split(new char[] { ' ', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                                      .Select(double.Parse)
                                      .ToArray();

                // Переставляем элементы массива в обратном порядке
                Array.Reverse(array);

                // Преобразуем массив обратно в строку
                string output = string.Join(" ", array);

                // Отображаем результат в OutputMemo
                OutputMemo.Text = output;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
