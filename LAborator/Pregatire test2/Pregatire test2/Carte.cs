using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregatire_test2
{
    class Carte
    {
        public string Titlu { get; set; }
        public string Autor { get; set; }
        public int AnPublicatie { get; set; }
        public int NrPagini { get; set; }
        public string Format { get; set; }

        public Carte() { }

        public Carte(string titlu, string autor, int anPublic, int nrPag, string format)
        {
            Titlu = titlu;
            Autor = autor;
            AnPublicatie = anPublic;
            NrPagini = nrPag;
            Format = format;
        }

        public override string ToString()
        {
            return string.Format("\"{0}\", {1}, An publicatie: {2}, {3} NrPagini, {4}",
                Titlu, Autor, AnPublicatie, NrPagini, Format);
        }
    }
}
