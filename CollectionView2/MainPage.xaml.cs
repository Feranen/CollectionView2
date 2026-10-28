using CollectionView2.Models;
using System.Collections.ObjectModel;

namespace CollectionView2
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();

            Dane strach = new Dane ("Stra","Tes",099809808);
            imie.Text = strach.name;
            nazwisko.Text = strach.lastName;
            pesel.Text = strach.pesel.ToString();

        }


    }
}
