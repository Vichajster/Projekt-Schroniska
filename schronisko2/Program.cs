using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace schronisko2
{
    class Program
    {
        private static Kot _kotki = new Kot();
        private static Pies _pieski = new Pies();
        private static PrzekazDatki _datki = new PrzekazDatki();
        static void Main(string[] args)
        {
            var actions = new Dictionary<int, Action>
        {
                  {1, Pieski },
                
                  {2, Kotki },
                {3,PokazPracownikow },
                {4,PrzekazDatki},
                {5,ShowDatki }
                
            };
            while (true)
            {
                Console.WriteLine("Wybierz opcję w schronisku: ");
                Console.WriteLine("1. Pieski ");
                Console.WriteLine("2.Kotki  ");
                Console.WriteLine("3.Pokaz Pracownikow schroniska ");
                Console.WriteLine("4.Przekaz datki na schronisko  ");
                Console.WriteLine("5.Pokaz ile pieniazkow udalo sie zebrac dla zwierzaczków  ");

                Console.WriteLine("10.EXIT");

                var opcja = int.Parse(Console.ReadLine());
                if (actions.ContainsKey(opcja))
                {
                    actions[opcja]();
                    Console.WriteLine("Wcisnij cokolweik by kontynuowac");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (opcja == 10)
                { break; }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Wybrano zla opcje");
                }
            }
        }
        private static void PokazPracownikow()
        {
            Address a = new Address("Bohaterow Wojennych 26", "Pomiechowek");
            Pracownik s = new Pracownik("Sebastian", a, "Opiekun Zwierzat");
            s.display();
        }

            private static void Pieski()
            {
            
            Console.WriteLine("Wybierz opcję ");
            Console.WriteLine("1.- Adopcja ");
            Console.WriteLine("2.-Oddanie ");
            Console.WriteLine("3 wyswietlenie listy piesków");
            int opcja = int.Parse(Console.ReadLine());
            switch (opcja)
            {
                case 1:
                    {
                        Console.WriteLine("Którego zwierzaczka chcesz adoptować");
                        int wartosc = int.Parse(Console.ReadLine());

                        _pieski.Adoptuj(wartosc-1);
                    } break;
                case 2:
                    {
                        Console.WriteLine("Podaj imie zwierzaczka: ");
                        string nazwa = Console.ReadLine();
                        Console.WriteLine("Podaj rase zwierzaczka: ");
                        string rasa = Console.ReadLine();
                        Console.WriteLine("Podaj wiek");
                        int wiek = int.Parse(Console.ReadLine());

                        _pieski.Oddaj(nazwa, rasa, wiek);
                    }break;
                case 3:
                    {
                        _pieski.Wyswietl();
                    }break;
                default:
                    Console.WriteLine("Nie ma takiej opcji w menu");
                    break;
            }

      
            

            }
          private static  void Kotki()
        {
            
            Console.WriteLine("Wybierz opcję ");
            Console.WriteLine("1.- Adopcja ");
            Console.WriteLine("2.-Oddanie ");
            Console.WriteLine("3 wyswietlenie listy kotków");
            int opcja = int.Parse(Console.ReadLine());
            switch (opcja)
            {
                case 1:
                    {
                        Console.WriteLine("Którego zwierzaczka chcesz adoptować");
                        int wartosc = int.Parse(Console.ReadLine());

                        _kotki.Adoptuj(wartosc-1);
                        
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("Podaj imie zwierzaczka: ");
                        string nazwa = Console.ReadLine();
                        Console.WriteLine("Podaj rase zwierzaczka: ");
                        string rasa = Console.ReadLine();
                        Console.WriteLine("Podaj wiek");
                        int wiek = int.Parse(Console.ReadLine());

                        _kotki.Oddaj(nazwa, rasa, wiek);
                    }
                    break;
                case 3:
                    {
                        _kotki.Wyswietl();
                    }
                    break;
                default:
                    Console.WriteLine("Nie ma takiej opcji w menu");
                    break;
            }




        }
        private static void PrzekazDatki()
        {
            Console.WriteLine("Ile chcesz przekazac dla schroniska pieniazkow ");
            int datkiValue = int.Parse(Console.ReadLine());


            _datki.Datki(datkiValue);
        }
        private static void ShowDatki()
        {
            Console.WriteLine($"{_datki.GetDatki()}");
        }
    }
}
