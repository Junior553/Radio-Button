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

namespace Radio_Button
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

        private void buttonPushMe_Click(object sender, RoutedEventArgs e)
        {
            if (radioButtonPencil.IsChecked == true)
            {
                labelAnswer.Content = " Pencil, Very Reliable! ";
                
            }
            else if (radioButtonPen.IsChecked == true)
            {
                labelAnswer.Content = " Pen, Nice Choice ";

            }
            else if (radioButtonPhone.IsChecked == true)
            {
                labelAnswer.Content = " Phone, Must be from the future ";

            }
            else if (radioButtonPad.IsChecked == true)
            {
                labelAnswer.Content = " Pad, Welcome to 2020";
                
            }










        }
    }
}
