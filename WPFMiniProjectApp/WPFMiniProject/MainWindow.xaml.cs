using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPFMiniProject.DemoLibrary;

namespace WPFMiniProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BindingList<AddressModel> addresses = new BindingList<AddressModel>();

        public MainWindow()
        {
            InitializeComponent();

            addressListBox.ItemsSource = addresses;

            addresses.Add(new AddressModel
            {
                HouseNumber = "52",
                Postcode = "SK5 6XQ"
            });
        }

        private void addAddress_Click(object sender, RoutedEventArgs e)
        {
            AddressWindow addressWindow = new AddressWindow();
            addressWindow.Show();
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            PersonModel person = new PersonModel();

            person.FirstName = firstNameTextBox.Text;
            person.LastName = lastNameTextBox.Text;
        }
    }
}