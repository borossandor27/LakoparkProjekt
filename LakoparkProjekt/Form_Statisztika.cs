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
    public partial class Form_Statisztika : Form
    {
        public Form_Statisztika()
        {
            InitializeComponent();
        }

        private void Form_Statisztika_Load(object sender, EventArgs e)
        {
            try
            {
                DirectoryInfo directory = new DirectoryInfo(Directory.GetCurrentDirectory());
                FileInfo legutolso = directory.GetFiles("statisztika_*.txt").OrderByDescending(f => f.LastWriteTime).First();
                textBox_Stat.Text = File.ReadAllText(legutolso.Name);
                textBox_Stat.Select(0, 0);
            }
            catch (IOException ex)
            {
                textBox_Stat.Text = "Statisztika fájl nem jeleníthető meg!";
                throw;
            }
        }

        private void Form_Statisztika_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}
