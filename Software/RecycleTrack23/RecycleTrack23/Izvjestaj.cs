using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecycleTrack23
{
    internal class Izvjestaj
    {
        public int IdIzvjestaja { get; set; }
        public string Naziv { get; set; }
        public int Kupljeno { get; set; }
        public string CijenaPoKilogramu { get; set; }
        public int StanjeNaSkladistu { get; set; }

        public int Reciklirano { get; set; }

    }
}
