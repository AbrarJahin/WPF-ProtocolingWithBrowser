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

namespace Protocoling
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Environment.GetCommandLineArgs().Length > 1)    //Because 0 index is app runing location
            {
                //Do not Open WPF UI, Instead do manipulate based
                //on the arguments passed in
                string[] arguments = Environment.GetCommandLineArgs();
                MessageBox.Show("CMD Param: \n\n" + arguments[1]);
            }
            else
            {
                //Open the WPF UI
                MessageBox.Show("Clicked");
            }
            //Exit program if no error has occured
            System.Windows.Application.Current.Shutdown();
        }
    }
}
