using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZelenakSz_13.A_belepteto
{
    internal class Tanulo
    {
        private string kod;
        private int ora;
        private int perc;
        private int szam;

        public Tanulo(string kod, int ora, int perc, int szam)
        {
            this.Kod = kod;
            this.Ora = ora;
            this.Perc = perc;
            this.Szam = szam;
        }

        public string Kod { get => kod; set => kod = value; }
        public int Ora { get => ora; set => ora = value; }
        public int Perc { get => perc; set => perc = value; }
        public int Szam { get => szam; set => szam = value; }
    }
}
