using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace Курсовой_проект_WPF_Климов
{
    public partial class MainWindow : Window
    {
        private Random random = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void SpinButtonClick(object sender, RoutedEventArgs e)
        {
            // Получаем случайные индексы для каждого изображения
            int index1 = random.Next(1, 4);
            int index2 = random.Next(1, 4);
            int index3 = random.Next(1, 4);

            // Устанавливаем изображения в соответствии с индексами
            SetImage(image1, index1);
            SetImage(image2, index2);
            SetImage(image3, index3);
        }

        private void SetImage(Image image, int index)
        {
            // Получаем текущую директорию выполнения
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // Формируем путь к изображению
            string imagePath = System.IO.Path.Combine(currentDirectory, $"Images\\Image{index}.png");

            // Устанавливаем изображение
            image.Source = new BitmapImage(new Uri(imagePath));
        }


    }
}