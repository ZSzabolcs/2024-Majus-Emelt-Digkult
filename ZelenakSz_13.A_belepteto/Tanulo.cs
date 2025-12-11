using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZelenakSz_13.A_belepteto
{
    internal class Tanulo
    {
        private string? kod;
        private TimeOnly ido;
        private int szam;

        public Tanulo(string? kod, TimeOnly ido, int szam)
        {
            this.Kod = kod;
            this.Ido = ido;
            this.Szam = szam;
        }

        public string? Kod { get => kod; set => kod = value; }
        public TimeOnly Ido { get => ido; set => ido = value; }
        public int Szam { get => szam; set => szam = value; }
    }
}
