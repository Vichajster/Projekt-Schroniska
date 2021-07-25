using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace schronisko2
{
    public class Pies : Baza, IZwierzeta

    {

        private string _fileName = "schroniskopsy.txt";



        protected override void dajglos()
        {
            string komunikat = " hau";
            Console.WriteLine(komunikat);

        }
        public void Adoptuj(int value)
        {
            
            var file = new List<string>(System.IO.File.ReadAllLines(_fileName));
            file.RemoveAt(value);
            File.WriteAllLines(_fileName, file.ToArray());
            Console.WriteLine($"Adopcja pieska nr:{value+1} ");
            

        }
        public void Oddaj(string name, string rasa, int wiek)
        {
            using (StreamWriter sw = File.AppendText(_fileName))
            {
                sw.WriteLine(name +" , " + rasa + " , " + wiek);

            }
        }
        public void Wyswietl()
        {
            if (File.Exists(_fileName))
            {
                string[] lines = System.IO.File.ReadAllLines(_fileName);

           
            
            foreach (string line in lines)
            {
               
                Console.WriteLine("\t" + line);
            }
        }
            else
            {
                Console.WriteLine("Nie ma schroniska psow");
            }
        }
            
}
}
