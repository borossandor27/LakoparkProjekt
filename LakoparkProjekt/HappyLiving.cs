using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace LakoparkProjekt
{
    class HappyLiving
    {
        List<Lakopark> lakoparkok = new List<Lakopark>();

        internal List<Lakopark> Lakoparkok { get => lakoparkok; set => lakoparkok = value; }

        public HappyLiving(string filenev)
        {
            try
            {
                using (StreamReader sr = new StreamReader(filenev))
                {
                    while (!sr.EndOfStream)
                    {
                        string LakoparkNev = sr.ReadLine();
                        string[] sor = sr.ReadLine().Split(';');
                        int utcakSzama = int.Parse(sor[0]);
                        int hazakSzama = int.Parse(sor[1]);
                        int[,] hazak = new int[utcakSzama, hazakSzama];
                        string ujSor = string.Empty;
                        while ((ujSor = sr.ReadLine()) != "")
                        {
                            sor = ujSor.Split(';');
                            hazak[int.Parse(sor[0]) - 1, int.Parse(sor[1]) - 1] = int.Parse(sor[2]);
                        }
                        lakoparkok.Add(new Lakopark(LakoparkNev, utcakSzama, hazakSzama, hazak));
                    }
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
                Environment.Exit(0);
            }
        }

        public bool Mentes()
        {
            bool sikeres = false;
            try
            {
                File.Copy("lakoparkok.txt", "lakoparkok_" + DateTime.Now.ToString("yyyyMMdd_hhmm") + ".txt");
                using (StreamWriter sw = new StreamWriter("lakoparkok.txt"))
                {
                    foreach (Lakopark item in lakoparkok)
                    {
                        sw.WriteLine(item.Nev);
                        sw.WriteLine(string.Join(";", item.UtcakSzama, item.MaxHazSzam));
                        for (int i = 0; i < item.Hazak.GetLength(0); i++)
                        {
                            for (int j = 0; j < item.Hazak.GetLength(1); j++)
                            {
                                sw.WriteLine(string.Join(";", i, j, item.Hazak[i, j]));
                            }
                        }
                        sw.WriteLine();
                    }
                }
                sikeres = true;
            }
            catch (Exception ex)
            {
                return false;
            }
            return sikeres;
        }
    }
}
