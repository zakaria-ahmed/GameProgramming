﻿using Minutes.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace Minutes
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        bool flashLightOnAndOff = true;
        public MainPage()
        {
            InitializeComponent();
            entries.ItemTapped += OnItemTapped;
            newEntry.Completed += OnAddNewEntry;
        }

        private async void OnAddNewEntry(object sender, EventArgs e)
        {
            string text = newEntry.Text;
            if (!string.IsNullOrWhiteSpace(text))
            {
                NoteEntry item = new NoteEntry { Title = text };
                await App.Entries.AddAsync(item);
                await Navigation.PushAsync(new NoteEntryEditPage(item));
                newEntry.Text = string.Empty;
            }
        }



        private async void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            NoteEntry item = e.Item as NoteEntry;
            await Navigation.PushAsync(new NoteEntryEditPage(item));
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            entries.ItemsSource = await App.Entries.GetAllAsync();
        }

        private async void FlashLight(object sender, EventArgs e)
        {
            if (flashLightOnAndOff)
            {

                // Turn On
                await Flashlight.TurnOnAsync();


                flashLightOnAndOff = false;
            }
            else
            {
                // Turn Off
                await Flashlight.TurnOffAsync();

                flashLightOnAndOff = true;
            }
        }

        private void Vib(object sender, EventArgs e)
        {
           
            Vibration.Vibrate();
        }

        private async void LocationMap(object sender, EventArgs e)
        {

            var location = new Location(55.770146, 12.512141);

            await Map.OpenAsync(location);
        }
    }
}
