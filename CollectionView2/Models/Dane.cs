using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionView2.Models
{
    public class Dane
    {
        public string name = "";
        public string lastName = "";
        public int? pesel;

        public Dane(string name, string nazwisko, int pesel)
        {
        this.name = name;
        this.lastName = nazwisko;
        this.pesel = pesel;
        }
    }
}
