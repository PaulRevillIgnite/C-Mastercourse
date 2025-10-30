using HotelAppLibary.Data;
using HotelAppLibary.Models;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
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
using System.Windows.Shapes;

namespace HotelApp.Desktop
{
    /// <summary>
    /// Interaction logic for CheckInWindown.xaml
    /// </summary>
    public partial class CheckInWindow : Window
    {
        private BookingFullModel _data = null;
        public IDatabaseData _db { get; }

        public CheckInWindow(IDatabaseData db)
        {
            InitializeComponent();
            _db = db;
        }

        public void PopulateCheckInInfo(BookingFullModel data)
        {
            _data = data;
            firstNameText.Text = data.FirstName;
            lastNameText.Text = data.LastName;
            titleText.Text = data.Title;
            roomNumberText.Text = data.RoomNumber;
            totalCostText.Text = data.TotalCost.ToString("C");
        }

        private void checkInCustomer_Click(object sender, RoutedEventArgs e)
        {
            _db.CheckInGuest(_data.Id);
            this.Close();
        }
    }
}
