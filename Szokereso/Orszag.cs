using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Szokereso
{
    
    class Orszag
    {
        public List<string>orszagok = new List<string>();

        public Orszag(string file)
        {
            string[] seged = File.ReadAllLines(file);
            for (int i = 0; i < seged.Length; i++)
            {
                orszagok.Add(seged[i]);
            }
        }
    }
}
