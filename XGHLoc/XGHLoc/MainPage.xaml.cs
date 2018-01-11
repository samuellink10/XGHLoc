using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Plugin.Geolocator;

namespace XGHLoc
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
        }

        public async void GetLoc(object send, EventArgs e)
        {
            lblLoc.Text = "";
            var p = CrossGeolocator.Current;
            var position = await p.GetPositionAsync(TimeSpan.FromSeconds(10));
            var adress = await p.GetAddressesForPositionAsync(position);
            foreach (var item in adress)
            {
                //lblLoc.Text += @"Rua: " + item.Thoroughfare + "\n" +
                //                "Numero: " + item.SubThoroughfare + "\n" +
                //                "Bairro: " + item.SubLocality + "\n" +
                //                "Cidade: " + item.Locality + "\n" +
                //                "Estado: " + item.AdminArea;
                var o = new
                {
                    Rua = item.Thoroughfare,
                    Numero = item.SubThoroughfare,
                    Bairro = item.SubLocality,
                    Cidade = item.Locality,
                    Estado = item.AdminArea,
                    Pais = item.CountryCode
                };
            }
            var i = adress.First();
            lblLoc.Text = @"Rua: " + i.Thoroughfare + "\n" +
                                "Numero: " + i.SubThoroughfare + "\n" +
                                "Bairro: " + i.SubLocality + "\n" +
                                "Cidade: " + i.Locality + "\n" +
                                "Estado: " + i.AdminArea;

        }
    }
}
