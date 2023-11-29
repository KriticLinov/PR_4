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

namespace PR_4_task_6
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CheckButton_Click(object sender, RoutedEventArgs e)
        {
            int number;

            if (Int32.TryParse(TbN.Text, out number))
            {
                bool hasZero = CheckForZero(number);

                ResultLabel.Content = "Имеет ноль: " + hasZero.ToString();
            }
            else
            {
                ResultLabel.Content = "Неверный номер!";
            }
        }

        private bool CheckForZero(int number)
        {
            while (number != 0)
            {
                int digit = number % 10;
                if (digit == 0)
                {
                    return true;
                }
                number /= 10;
            }

            return false;
        }
    }
}
