using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metro_aplikace
{
    internal class LinkaMetra
    {
        private List<string> _nazvyStanic;

        public LinkaMetra(List<string> _vkladameStanice)
        {
           _nazvyStanic = _vkladameStanice;
            Console.WriteLine("");
        }
        public void VypisStanice()
        {
            foreach (string stanice in _nazvyStanic) //projede všechny stanice v listu_nazvy stanic
            {
                Console.WriteLine(stanice); //vypisuje současnou stanici v cyklu
            }
        }
        public void PrvniPosledníStanice()
        {
            string prvniStanice = _nazvyStanic[0];
            string posledniStanice = _nazvyStanic[_nazvyStanic.Count - 1];
            Console.WriteLine($"{prvniStanice} - {posledniStanice}");
        }
        public int ZjistiCas(string odjezdStanice, string prijezStanice)
        {
            int cas = 0;
            if (_nazvyStanic.Contains(prijezStanice) && _nazvyStanic.Contains(odjezdStanice))
            {
                int indexOdjezdu = _nazvyStanic.IndexOf(odjezdStanice);
                int indexPrijezdu = _nazvyStanic.IndexOf(prijezStanice);
                int rozdil = indexOdjezdu - indexPrijezdu;
                cas = rozdil * 2;
            }
            else
            {
                Console.WriteLine("co jeeeeeeeee");
            }
            return Math.Abs(cas);
        }
    }
}
