using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SafeHealth
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

       async void DuringPregnancy(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new healthDuring());
        }
        async void DangerDuringPregnancy(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DangerDuringPregnancy());
        }
        async void DuringBirth(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DangerDuringBirth());
        }
        async void AfterBirth(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DangerAfterBirth());
        }
    }
}
