using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinLearn.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LabelAndButtonPage : ContentPage
    {
        public LabelAndButtonPage()
        {
            InitializeComponent();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("提醒", "点击了以下按钮", "确定");
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            underlinde.Text = "文本修改了";
        }
    }
}