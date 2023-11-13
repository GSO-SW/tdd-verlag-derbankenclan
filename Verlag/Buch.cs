using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verlag
{
    public class Buch
    {
        private string autor;
        private string titel;
        private int auflage;
        public Buch (string autor, string titel, int auflage)
        {
            this.autor = autor;
            this.titel = titel;
            this.auflage = auflage;
        }


    }
}
