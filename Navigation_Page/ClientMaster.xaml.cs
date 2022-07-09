using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Navigation_Page
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ClientMaster 
    {
        public ClientMaster(string firstName, string lastName)
        {
            InitializeComponent();
            txtMessage.Text = "Welcome " + firstName + " " + lastName+" in Client Master";
        }
    }
}