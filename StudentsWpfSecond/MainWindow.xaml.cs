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

namespace StudentsWpfSecond
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string _right1;

        private string _right2;
        
        public string Answer1 { get; set; }
        
        public string Answer2 { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            _right1 = "Десять";
            _right2 = "Двенадцать";
            DataContext = this;
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            int counter = 0;
            if (Answer1 == _right1)
                counter++;
            if (Answer2 == _right2)
                counter++;

            MessageBox.Show("Правильных ответов: " + counter);
        }
    }
}