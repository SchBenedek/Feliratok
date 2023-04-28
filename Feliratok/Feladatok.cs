using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Feliratok
{
    internal class Feladatok
    {
        public List<IdozitettFelirat> lista;
        public Feladatok()
        {
            lista=new List<IdozitettFelirat> ();
        }
        public bool Beolvas()
        {
            StreamReader sr = new StreamReader("feliratok.txt");
            while(!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string line2=sr.ReadLine();
                lista.Add(new IdozitettFelirat(line, line2));
            }
            if(lista.Count > 0)
            {
                return true;
            }
            else { return false; }
        }
        public string szavakSzama()
        {
            int a = 0;
            string[] b;
            string c="";
            foreach(var item in lista)
            {
                b = item.Felirat.Split(' ');
                if(b.Length > a)
                {
                    a = b.Length;
                    c = Convert.ToString(item);
                }
            }
            return c;
        }

    }
}
