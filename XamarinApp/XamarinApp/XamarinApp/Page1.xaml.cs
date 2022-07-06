using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();


        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Item Tapped", "Police Eklendi", "OK");
        }
    }
}