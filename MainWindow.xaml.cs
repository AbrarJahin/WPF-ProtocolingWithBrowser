using RestSharp;
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

                //######################################################################################//
                //Documentation can be found in here- http://restsharp.org/
                //And here- https://stackoverflow.com/questions/6999598/how-to-perform-a-get-request-with-restsharp

                RestClient client = new RestClient("http://dummy.restapiexample.com/api/v1/employees");
                var request = new RestRequest(Method.GET);

                client.ExecuteAsync(request, response => {
                    // do something with the response
                    var a = response;

                    if (response.ResponseStatus == ResponseStatus.Error)
                    {
                        //failure(response.ErrorMessage);
                        MessageBox.Show("Failed to connect");
                    }
                    else
                    {
                        MessageBox.Show(response.Content);

                        //If done, then exit the client
                        Environment.Exit(0);
                    }
                });
                //######################################################################################//
            }
            else
            {
                //Open the WPF UI
                MessageBox.Show("Clicked");
            }
        }
    }
}
