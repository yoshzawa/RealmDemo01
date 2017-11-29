using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Realms;

namespace RealmDemo01
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            try
            {
                Realm realm = Realm.GetInstance();
            }catch(System.InvalidOperationException ex)
            {
                DisplayAlert(ex.Message, ex.StackTrace, "cancel");
            }

        }
    }
}
