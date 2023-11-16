using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verlag
{
    public class Buch
    {
        private string autor;
        private string titel;
        private int auflage = 1;
        private string isbn;
        public Buch(string autor, string titel, int auflage, string isbn)
        {
            this.autor = autor;
            this.titel = titel;
            this.auflage = auflage;
            this.isbn = isbn;
        }

        public Buch (string autor, string titel, int auflage)
        {
            if (auflage < 1)
            {
                throw new ArgumentOutOfRangeException();
            }
            else if (1 <1)
            {

            }
            else 
            {
                this.autor = autor;
                this.titel = titel;
                this.auflage = auflage;
            }
        }
        
        public Buch (string autor, string titel)
        {
            this.autor= autor;
            this.titel = titel;
        }

        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }
        public string Titel
        { 
            get {  return titel; } 
            set {  titel = value; } 
        }
        public int Auflage
        {
            get { return auflage; }
            set 
            {
                if (auflage < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    auflage = value;
                }
            }
        }
        
        public string ISBN
        {
            get { return isbn; }
            set { isbn = value; }



        }
    }
}
