using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Semana4
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Item1.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new Page1());
            };

            Item2.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new TabbedPage1());
            };

            Item3.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new CarouselPage());
            };

            Item4.Clicked += async (sender, e) =>
            {
                await Navigation.PushModalAsync(new ModalPage1());
            };

            Item5.Clicked += async (sender, e) =>
            {
                //call popup
                var answer = await DisplayAlert("Pregunta?");
                Debug.WriteLine("Anwer: "+ answer);
            };
        }

        private Task<string> DisplayAlert(string v)
        {
            throw new NotImplementedException();
        }
    }
}
