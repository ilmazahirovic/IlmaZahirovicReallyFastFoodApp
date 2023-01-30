using IlmaZahirovicReallyFastFoodApp.NewFolder;
using System.Diagnostics;
using System.Security.Cryptography;

namespace IlmaZahirovicReallyFastFoodApp 
{
    public partial class MainPage : ContentPage
    {
        Jelo jelo1 = new Jelo() { Id = 1, Slika = "jelo1.png", Ime = "Burger", Cijena = 15, Kalorije = 266 };
        Jelo jelo2 = new Jelo() { Id = 2, Slika = "jelo2.png", Ime = "Pizza", Cijena = 18, Kalorije = 266 };
        Jelo jelo3 = new Jelo() { Id = 3, Slika = "jelo3.png", Ime = "RollsSoup", Cijena = 12, Kalorije = 266 };
        Jelo jelo4 = new Jelo() { Id = 4, Slika = "jelo4.png", Ime = "Soup", Cijena = 20, Kalorije = 266 };

        private List<Naselja> MjestaLista { get; set; }




        public MainPage()
        {

            MjestaLista = new List<Naselja> {
            new Naselja() { Id = 1, Naziv = "Centar", Udaljenost = 1 },
            new Naselja() { Id = 2, Naziv = "Blatuša", Udaljenost = 2 },
            new Naselja() { Id = 3, Naziv = "Crkvice", Udaljenost = 3 },
            new Naselja() { Id = 4, Naziv = "Radakovo", Udaljenost = 4 }
    };

            InitializeComponent();

            BindingContext = this;

            //Burger
            Slika1.Source = jelo1.Slika;
            Naziv1.Text = jelo1.Ime;
            Cijena1.Text = jelo1.Cijena.ToString();
            Kalorije1.Text = jelo1.Kalorije.ToString();

            //Pizza
            Slika2.Source = jelo2.Slika;
            Naziv2.Text = jelo2.Ime;
            Cijena2.Text = jelo2.Cijena.ToString();
            Kalorije2.Text = jelo2.Kalorije.ToString();

            //Rolls
            Slika3.Source = jelo3.Slika;
            Naziv3.Text = jelo3.Ime;
            Cijena3.Text = jelo3.Cijena.ToString();
            Kalorije3.Text = jelo3.Kalorije.ToString();

            //Soup
            Slika4.Source = jelo4.Slika;
            Naziv4.Text = jelo4.Ime;
            Cijena4.Text = jelo4.Cijena.ToString();
            Kalorije4.Text = jelo4.Kalorije.ToString();


            odabirMjesta.ItemsSource = MjestaLista;

        }



        private void Button_Clicked(object sender, EventArgs e)
        {
            if (Odabir1.IsChecked == true)
            {
                if (Kolicina1.Text is null)
                    jelo1.Kolicina = 1;
                else
                    jelo1.Kolicina = int.Parse(Kolicina1.Text);
            }
            DisplayAlert("Vaša narudžba", KalkulatorNarudzbe(), "Ok");

            if (Odabir2.IsChecked == true)
            {
                if (Kolicina2.Text is null)
                    jelo2.Kolicina = 1;
                else
                    jelo2.Kolicina = int.Parse(Kolicina2.Text);
            }
            DisplayAlert("Vaša narudžba", KalkulatorNarudzbe(), "Ok");

            if (Odabir3.IsChecked == true)
            {
                if (Kolicina3.Text is null)
                    jelo3.Kolicina = 1;
                else
                    jelo3.Kolicina = int.Parse(Kolicina3.Text);
            }
            DisplayAlert("Vaša narudžba", KalkulatorNarudzbe(), "Ok");

            if (Odabir4.IsChecked == true)
            {
                if (Kolicina4.Text is null)
                    jelo4.Kolicina = 1;
                else
                    jelo4.Kolicina = int.Parse(Kolicina4.Text);
            }
            DisplayAlert("Vaša narudžba", KalkulatorNarudzbe(), "Ok");

            string KalkulatorNarudzbe()

            {
            decimal CijenaNarudzbe = 0;
            int UkupnoKalorija = 0;


            CijenaNarudzbe = CijenaNarudzbe + jelo1.Kolicina * jelo1.Cijena;
                UkupnoKalorija = UkupnoKalorija + jelo1.Kolicina * jelo1.Kalorije;


                CijenaNarudzbe = CijenaNarudzbe + jelo2.Kolicina * jelo2.Cijena;
                UkupnoKalorija = UkupnoKalorija + jelo2.Kolicina * jelo2.Kalorije;

                CijenaNarudzbe = CijenaNarudzbe + jelo3.Kolicina * jelo3.Cijena;
                UkupnoKalorija = UkupnoKalorija + jelo3.Kolicina * jelo3.Kalorije;


                CijenaNarudzbe = CijenaNarudzbe + jelo4.Kolicina * jelo4.Cijena;
                UkupnoKalorija = UkupnoKalorija + jelo4.Kolicina * jelo4.Kalorije;
                
                string Poruka = "Ukupna vrijednost vaše narudžbe: " + CijenaNarudzbe + ", sadrži ukupno " + UkupnoKalorija + " kalorija!";
                return Poruka;
            }


        }
    }
}
