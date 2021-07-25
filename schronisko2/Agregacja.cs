using System;
using System.Collections.Generic;
using System.Text;

namespace schronisko2
{
   
    public class Address
    {
        public string ulica, miasto;
        public Address(string ulica, string miasto)
        {
            this.ulica = ulica;
            this.miasto = miasto;
            
        }
    }
    public class Pracownik
    {
        public string imie;
        
       
       public string Stanowisko;
        Address address;
        public Pracownik( string imie, Address address,string Stanowisko)
        {
            
            this.imie = imie;
            this.address = address;
            this.Stanowisko = Stanowisko;

        }
        public void display()
        {
            Console.WriteLine("Pracownik: "+ imie + " "+" Mieszka : " + address.ulica + " " + address.miasto + " " + "Na stanowisku: " + Stanowisko );
        }
    }
   
}
