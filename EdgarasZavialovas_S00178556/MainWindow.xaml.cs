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

namespace EdgarasZavialovas_S00178556
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PhoneDescription db = new PhoneDescription();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //code for window loaded
            var query = from t in db.Phones
                        select t.Name;

            lbxPhones.ItemsSource = query.ToList();

            


        }

        private void lbxPhones_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Phone selected = lbxPhones.SelectedItem as Phone;

            if (selected != null)
            {

                //display tblk Price

                tblkPrice.Text = selected.Name;

                //Displays the image in this listbox
                string imagePath = $"\\Images\\{selected.Phone_Image}.jpg";
                imgPhone.Source = new BitmapImage(new Uri(imagePath, UriKind.Relative));

            }
        }
    }
}
