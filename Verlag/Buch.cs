using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Verlag
{
    public class Buch
    {
        private string autor;
        private string titel;
        private int auflage = 1;
        public Buch (string autor, string titel, int auflage)
        {
            if (this.auflage <= 0)
            {
                throw new ArgumentOutOfRangeException("Auflage darf nicht kleiner als 1 sein!");
            }
            else if (!Regex.IsMatch(autor, @"^[a-zA-Z]+$"))
            {
                throw new ArgumentOutOfRangeException("Name des Autors darf nur Buchstaben enthalten!");
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
            if (!Result)
            {
                throw new ArgumentOutOfRangeException("Name des Autors darf nur Buchstaben enthalten!");
            }
            else
            {
                this.autor = autor;
                this.titel = titel;
                auflage = auflage;
            }
        }

        public bool Result
        {

        }

        public string Autor 
        { 
            get { return autor; } 
            set { autor = value; } 
        }
        public string Titel
        {
            get { return titel; }
            set { titel = value; }
        }
        public int Auflage
        {
            get { return auflage; }
            set
            {
                if (this.auflage <= 0)
                {
                    throw new ArgumentOutOfRangeException("Auflage darf nicht kleiner als 1 sein!");
                }
                else
                { 
                     auflage = value;
                }
            }
        }
    }
}
