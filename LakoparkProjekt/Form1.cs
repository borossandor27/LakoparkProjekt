using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LakoparkProjekt
{
    public partial class Form1 : Form
    {
        HappyLiving happyLiving = new HappyLiving(@"..\..\lakoparkok.txt");
        readonly int buttonSize = 50;
        int aktPark = 0;
        List<Image> szintek = new List<Image>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            szintek.Add(Image.FromFile(@"Kepek\kereszt.jpg"));
            szintek.Add(Image.FromFile(@"Kepek\Haz1.jpg"));
            szintek.Add(Image.FromFile(@"Kepek\Haz2.jpg"));
            szintek.Add(Image.FromFile(@"Kepek\Haz3.jpg"));
            PanelUpdate();

        }

        void PanelUpdate()
        {
            this.Text = happyLiving.Lakoparkok[aktPark].Nev + " lakópark";
            if (aktPark==0)
            {
                button_Balra.Enabled = false;
                button_Balra.Hide();
            }
            else if (aktPark == happyLiving.Lakoparkok.Count-1)
            {
                button_Jobbra.Enabled = false;
                button_Jobbra.Hide();
            }
            else
            {
                button_Balra.Enabled = true;
                button_Balra.Show();
                button_Jobbra.Enabled = true;
                button_Jobbra.Show();

            }
            pictureBox1.BackgroundImage = happyLiving.Lakoparkok[aktPark].Nevado;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            panel_Utcakep.Controls.Clear();
            for (int i = 0; i < happyLiving.Lakoparkok[aktPark].Hazak.GetLength(1); i++)
            {
                for (int j = 0; j < happyLiving.Lakoparkok[aktPark].Hazak.GetLength(0); j++)
                {
                    //-- Létrehozás ----------------------------------
                    Button g = new Button();
                    g.BackgroundImage = szintek[happyLiving.Lakoparkok[aktPark].Hazak[j, i]];
                    g.BackgroundImageLayout = ImageLayout.Stretch;
                    g.SetBounds(i * buttonSize, j * buttonSize, buttonSize, buttonSize);
                    //-- eseménykezelés ------------------------------
                    int utca = j;
                    int haz = i;
                    g.Click += (o, e) =>
                    {
                        happyLiving.Lakoparkok[aktPark].UjSzint(utca, haz);
                        PanelUpdate();
                    };
                    panel_Utcakep.Controls.Add(g);
                }
            }
        }

        private void button_Balra_Click(object sender, EventArgs e)
        {
            aktPark--;
            PanelUpdate();
        }

        private void button_Jobbra_Click(object sender, EventArgs e)
        {
            aktPark++;
            PanelUpdate();
        }

        private void button_Mentes_Click(object sender, EventArgs e)
        {
            if (happyLiving.Mentes())
            {
                MessageBox.Show("Sikeres Mentés");
            }
            else
            {
                MessageBox.Show("Adatok mentése nem sikerült!");
            }
        }
    }
}
