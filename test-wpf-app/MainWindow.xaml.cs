using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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

namespace test_wpf_app
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        int counter = 0;

        
        public MainWindow()
        {
            InitializeComponent();

            Uri iconUri = new Uri("https://cdn.pixabay.com/photo/2016/05/31/12/42/red-button-1426817_1280.png", UriKind.RelativeOrAbsolute);

            this.Icon = BitmapFrame.Create(iconUri);

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            counter++;
            @out.Text = counter.ToString();

            if (counter == 10)
            {
                MessageBox.Show("You've hit " + counter + " clicks");
            }

            if (counter == 50)
            {
                MessageBox.Show("You've hit " + counter + " clicks");
            }

            if (counter == 100)
            {
                MessageBox.Show("You've hit " + counter + " clicks");
            }

            if (counter == 200)
            {
                MessageBox.Show("You've hit " + counter + " clicks");
            }

            if (counter == 300)
            {
                MessageBox.Show("You've hit " + counter + " clicks");
            }

            if (counter == 400)
            {
                MessageBox.Show("You've hit " + counter + " clicks");
            }

            if (counter == 500)
            {
                MessageBox.Show("You've hit " + counter + " clicks");
            }

            if (counter == 1000)
            {
                MessageBox.Show("You've hit " + counter + " clicks");
            }

            if (counter == 5000)
            {
                MessageBox.Show("You've hit " + counter + " clicks");
            }

            if (counter == 10000)
            {
                MessageBox.Show("Wow you have alot of dediction i like you you've hit " + counter + " clicks");
            }
        }

        
    }
}
