using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LakoparkProjekt
{
    class Lakopark
    {
        int[,] hazak;
        readonly int maxHazSzam;
        readonly string nev;
        readonly int utcakSzama;
        private readonly Image nevado;

        public int[,] Hazak { get => hazak; set => hazak = value; }

        public int MaxHazSzam => maxHazSzam;

        public string Nev => nev;

        public int UtcakSzama => utcakSzama;

        public Image Nevado => nevado;

        public Lakopark(string nev, int utcakSzama, int maxHazSzam, int[,] hazak)
        {
            this.Hazak = hazak;
            this.maxHazSzam = maxHazSzam;
            this.nev = nev;
            this.utcakSzama = utcakSzama;
            this.nevado = Image.FromFile(@"Kepek\" + nev + ".jpg");
        }
    }
}
