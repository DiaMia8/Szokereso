using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Szokereso
{
    class Jatek
    {
        public char[,] jatek= new char[20,20];
        public List<string> sorok = new List<string>();
        
        public Jatek(string file)
        {
            string[] adat = File.ReadAllLines(file);
            for (int i = 0; i < adat.Length; i++)
            {
                string sor = adat[i];
                sorok.Add(adat[i]);
                for (int j = 0; j < adat.Length; j++)
                {
                    char[] egy = sor.ToCharArray();
                    jatek[i, j] = Convert.ToChar(egy[j]);
                }
            }
            
        }

        public void Kiiras()
        {
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    string sor = jatek[i,j].ToString();
                    Console.Write(sor);
                }
                Console.WriteLine();
            }
        }

       
        
    }
}
