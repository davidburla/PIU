using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Configurare_S3
{
    class Configurare
    {
        public string DenumireStil { get; set; }
        public Color Culoare { get; set; }
        public int Grosime { get; set; }
        public string Figura { get; set; }
        public Configurare() { }
        public Configurare(string denumireStil, Color culoare, int grosime, string figura)
        {
            DenumireStil = denumireStil;
            Culoare = culoare;
            Grosime = grosime;
            Figura = figura;

        }
        public override string ToString()
        {
            return string.Format("Still:{0},Culoare: {1},Grosime: {2}, Figura: {3}", DenumireStil, Culoare.Name, Grosime, Figura);
        }
    }
}
