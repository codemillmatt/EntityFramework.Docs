using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace EFGetStarted
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }

        async void DeleteMenuItem_Clicked(System.Object sender, System.EventArgs e)
        {
            await Shell.Current.DisplayAlert("Heyo", "Implement the delete","OK");
        }
    }
}
