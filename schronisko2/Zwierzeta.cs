using System;
using System.Collections.Generic;
using System.Text;

namespace schronisko2
{
    public interface IZwierzeta
    {
        public void Adoptuj(int value);
        public void Oddaj(string name,string rasa,int wiek);
        public void Wyswietl();

    }
}
