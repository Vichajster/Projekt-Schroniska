using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace schronisko2
{

    public class PrzekazDatki
    {

        private string _fileName = "datki.txt";
        private bool _datkiLoaded = false;
        private int _Sum = 0;
        private int _Count = 0;
        public void Datki(int datek)
        {
            if (datek < 1)
            {
                throw new ArgumentException("Wartosc powinna byc nie mniejsza niz 1zl");
            }
            else {
                using (StreamWriter sw = File.AppendText(_fileName))
                {
                    sw.WriteLine($"{datek}");
                }

                _Sum = +datek;
                _Count++;
            }
        }
        public double GetDatki()
        {
            if (_datkiLoaded == false)
            {
                LoadDatki();
            }
            Console.WriteLine($"Hura Zgromadzilismy juz {_Sum} zl  ");
            Console.Write("Oraz mamy tylu darczyncow: ");
            return _Count ;
        }
        private void LoadDatki()
        {
            string[] lines = File.ReadAllLines(_fileName);
            foreach (string line in lines)
            {
                string[] parts = line.Split(";");
                int datek = int.Parse(parts[0]);
                _Sum += datek;
            }
            _Count += lines.Length;
            _datkiLoaded = true;
        }
    }
}
