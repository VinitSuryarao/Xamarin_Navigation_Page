using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Navigation_Page
{
    public partial class MainPage 
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ClientMaster_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ClientMaster(txtFirstName.Text, txtLastName.Text));
        }
        private void ExchangeMaster_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ExchangeMaster(txtFirstName.Text, txtLastName.Text));
        }
    }
}
