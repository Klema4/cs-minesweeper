using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rocnikovka_Minesweeper
{
    public partial class Hra : Form
    {
        private static int pocet_boxu = 399;
        private static int radek = 0;
        private static bool prvotni_nacteni = false;
        private static bool bomby = false;
        private static bool generace = false;

        public Hra()
        {
            InitializeComponent();
            StreamReader sr = new StreamReader("./settings.txt");
            int pocet_vlajecek = Convert.ToInt16(sr.ReadLine());
            int pocet_bomb = Convert.ToInt16(sr.ReadLine());
            int sance = Convert.ToInt16(sr.ReadLine());
            bool prvotni_nacteni, bomby, generace;
            prvotni_nacteni = true;
        }

        private void Hra_Load(object sender, EventArgs e) { }

        int x = 20;
        int y = 100;

        private void nacteni_Tick(object sender, EventArgs e)
        {
            while (Hra.pocet_boxu > 0)
            {
                pocet_boxu--;
                radek++;
                PictureBox new_pic = new PictureBox();
                new_pic.Width = 20;
                new_pic.Height = 20;
                new_pic.BackColor = Color.FromArgb(Random.Shared.Next(0, 256), Random.Shared.Next(0, 256), Random.Shared.Next(0, 256));
                new_pic.Location = new Point(x, y);
                this.Controls.Add(new_pic);

                x += 20;
                if (radek > 20)
                {
                    radek = 0;
                    y += 20;
                    x = 20;
                }
            }
        }
    }
}
