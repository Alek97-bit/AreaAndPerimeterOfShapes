using System;
using System.Collections.Generic;
using System.Linq;


namespace ConsoleApp10
{

    interface IScitalka
    {
        double GetS(int[] a);
        double GetP(int[] a);
    }

    class Kalkulator
    {
        public IScitalka Scitalka { get; set; }
        public double KalkulatorFigurS(int[] a)
        {



            return Scitalka.GetS(a);


        }

        public double KalkulatorFigurP(int[] a)
        {
            return Scitalka.GetP(a);
        }

    }


    class Krug : IScitalka
    {
        public double GetS(int[] storona)
        {
            double SummaKruga = 0;
            for (int i = 0; i < storona.Length; i++)
            {
                double Skruga = storona[i] * storona[i] * Math.PI;
                Console.WriteLine("Plosiad kruga " + Skruga);
                SummaKruga = SummaKruga + Skruga;
            }
            Console.WriteLine("Summa Plosiadej kruga " + SummaKruga);
            return SummaKruga;
        }

        public double GetP(int[] storona)
        {
            double Summakruga = 0;
            for (int i = 0; i < storona.Length; i++)
            {
                double Pkruga = 2 * storona[i] * Math.PI;
                Console.WriteLine("Perimetr kruga " + Pkruga);
                Summakruga = Summakruga + Pkruga;
            }
            Console.WriteLine("Summa perimetrow kruga " + Summakruga);
            Console.WriteLine("");
            return Summakruga;
        }
    }

    class Kwadrat : IScitalka
    {
        public double GetS(int[] storona)
        {
            double Summakwadrata = 0;
            for (int i = 0; i < storona.Length; i++)
            {
                double Skwadrata = storona[i] * storona[i];
                Console.WriteLine("Plosiad kwadrata " + Skwadrata);
                Summakwadrata = Summakwadrata + Skwadrata;
            }
            Console.WriteLine("Summa Plosiadej kwadrata " + Summakwadrata);
            return Summakwadrata;
        }

        public double GetP(int[] storona)
        {
            double Summakwadrata = 0;
            for (int i = 0; i < storona.Length; i++)
            {
                double Pkwadrata = storona[i] * 4;
                Console.WriteLine("Perimetr kwadrata " + Pkwadrata);
                Summakwadrata = Summakwadrata + Pkwadrata;
            }
            Console.WriteLine("Summa perimetrow kwadrata " + Summakwadrata);
            Console.WriteLine("");
            return Summakwadrata;
        }
    }

    class Triugolnik : IScitalka
    {
        public double GetS(int[] storona)
        {
            double SummaTriugolnikow = 0;
            for (int i = 0; i < storona.Length; i++)
            {
                double STriugolnika = (Math.Abs(3) * storona[i]) / 4;
                Console.WriteLine("Plosiad triugolnika" + STriugolnika);
                SummaTriugolnikow = SummaTriugolnikow + STriugolnika;
            }

            Console.WriteLine("Summa Plosiadej kwadrata " + SummaTriugolnikow);
            return SummaTriugolnikow;

        }

        public double GetP(int[] storona)
        {
            double SummaTriugolnikow = 0;
            for (int i = 0; i < storona.Length; i++)
            {
                double PTriugolnika = storona[i] * 3;
                Console.WriteLine("Perimetr triugolnika" + PTriugolnika);
                SummaTriugolnikow = SummaTriugolnikow + PTriugolnika;
            }
            Console.WriteLine("Summa perimetrow kwadrata " + SummaTriugolnikow);
            Console.WriteLine("");
            return SummaTriugolnikow;

        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            Kalkulator kalkulator = new Kalkulator();
            int[] dlina = new int[5];
            for (int i = 0; i < dlina.Length; i++)
            {
                dlina[i] = random.Next(1, 20);
            }

            kalkulator.Scitalka = new Kwadrat();
            double SK = kalkulator.KalkulatorFigurS(dlina);
            double PK = kalkulator.KalkulatorFigurP(dlina);
            kalkulator.Scitalka = new Krug();
            double SKr = kalkulator.KalkulatorFigurS(dlina);
            double PKr = kalkulator.KalkulatorFigurP(dlina);
            kalkulator.Scitalka = new Triugolnik();
            double ST = kalkulator.KalkulatorFigurS(dlina);
            double PT = kalkulator.KalkulatorFigurP(dlina);
            Console.WriteLine("Summa plosiadej figur" + (SK + ST + SKr));
            Console.WriteLine("Summa perimetrow figur" + (PK + PT + PKr));
        }
    }
}
