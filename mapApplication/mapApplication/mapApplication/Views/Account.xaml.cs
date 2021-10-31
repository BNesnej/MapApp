﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace mapApplication
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Account : ContentPage
    {
        
        public Account()
        {
            InitializeComponent();            
        }                    

        #region Navigation
        private async void HomeClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Home());
        }
        private async void AccountClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Account());
        }
        private async void MapClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Map());
        }
        private async void NotificationsClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Notifications());
        }
        #endregion

        private void EditProfile_Clicked(object sender, EventArgs e)
        {

        }

        private async void Settings_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Settings());
        }
    }
}