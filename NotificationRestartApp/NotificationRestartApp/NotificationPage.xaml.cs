using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace NotificationRestartApp
{
    public partial class NotificationPage : ContentPage
    {
        public NotificationPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked_ON(object sender, EventArgs e)
        {
            (App.Current as App).DialogServices.ShowNotification("Notification", "Please, don't restart my app...");
        }

        private void Button_Clicked_OFF(object sender, EventArgs e)
        {
            (App.Current as App).DialogServices.CancelNotification();
        }
    }
}
