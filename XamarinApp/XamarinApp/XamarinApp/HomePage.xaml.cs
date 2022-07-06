using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]


    public partial class HomePage : ContentPage
    {

        public ObservableCollection<string> Items { get; set; }

        List<Police> liste = new List<Police>();
        public HomePage()
        {
            InitializeComponent();

            ListeDoldur(liste);
            listPolice.BindingContext = liste;

        }



        public void ListeDoldur(List<Police> list)
        {
            list.Add(new Police
            {
                Sigorta = "Axa Sigorta",
                Tur = "Saglik",

            });
            list.Add(new Police
            {
                Sigorta = "Axa Sigorta",
                Tur = "Kasko",


            });
            list.Add(new Police
            {
                Sigorta = "Anadolu Sigorta",
                Tur = "Deprem",
            });

            list.Add(new Police
            {
                Sigorta="Anadolu Sigorta",
                Tur="Bireysel Emeklilik"
            });

            list.Add(new Police
            {
                Sigorta = "Axa Sigorta",
                Tur = "Kasko"
            }) ;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await DisplayAlert("Item Tapped", "Police Detay Sayfasi", "OK");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page1());
        }


    }
}