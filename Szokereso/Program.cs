using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szokereso
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.feladat
            // játék állomány beolvasása
            Jatek jatek1 = new Jatek("játék.txt");

            // teszt kiirás
            //jatek1.Kiiras();

            //3.feladat

            Orszag orszagok = new Orszag("országok.txt");

            //4.feladat
            Console.WriteLine($"4. feladat: {orszagok.orszagok.Count} db orzág szerepel az állományban");

            // 5. feladat

            Console.WriteLine("5. feladat");

            string minErtek = orszagok.orszagok[0];
            List<string> rovid = new List<string>();
            foreach (var item in orszagok.orszagok)
            {
                if (item.Length < minErtek.Length)
                {
                    minErtek = item;
                }


            }
            //rovid.Add(orszagok.orszagok.Where(x=>x.ToString().Length == minErtek.Length).ToString());

            foreach (var item in orszagok.orszagok)
            {
                if (item.Length == minErtek.Length)
                {
                    rovid.Add(item);
                }

            }
            foreach (var item in rovid)
            {
                Console.WriteLine($"\t{item}");

            }

            //6.feladat
            int kotojelSzama = 0;
            foreach (var item in jatek1.jatek)
            {
                if (item.Equals('-'))
                {
                    kotojelSzama++;
                }
            }
            Console.WriteLine($"6. feladat: Hiányzó karakterek száma: {kotojelSzama}");

            // 7. feladat

            string sor = "";
            for (int i = 0; i < 20; i++)
            {
                sor += jatek1.jatek[0, i];
            }

            string szo = "";
            foreach (var item in orszagok.orszagok)
            {
                if (sor.Contains(item))
                {
                    szo = item;
                }
            }

            Console.WriteLine($"7. feladat: Első sorban lévő ország: {szo}");

            // 8. feladat

            //List<string> nemSzerepel = new List<string>();

            //foreach (var item in jatek1.sorok)
            //{
            //    if (!orszagok.orszagok.Contains(item))
            //    {
            //        nemSzerepel.Add(item);
            //    }
            //}
             

            //foreach (var item in orszagok.orszagok)
            //{
            //    for (int i = 0; i < 20; i++)
            //    {
            //        for (int j = 0; j < 20; j++)
            //        {
            //            if (jatek1.jatek[i,j].ToString() == (item.ToCharArray))
            //            {

            //            }
            //        }
            //    }

            //}
           

            Console.ReadKey();
        }
    }
}
