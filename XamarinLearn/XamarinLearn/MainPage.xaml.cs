using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinLearn.View;

namespace XamarinLearn
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void hello_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HelloWorldPage());
        }

        async void label_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LabelAndButtonPage());
        }
    }
}
