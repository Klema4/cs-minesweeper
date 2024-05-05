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
        }

        public static StreamReader sr = new StreamReader("./settings.txt");
        public static int pocet_vlajecek = Convert.ToInt16(sr.ReadLine());
        public static int pocet_bomb = Convert.ToInt16(sr.ReadLine());
        public static int sance = Convert.ToInt16(sr.ReadLine());

        int x = 20;
        int y = 100;

        private void Hra_Load(object sender, EventArgs e) {
            while (Hra.pocet_boxu > 0)
            {
                pocet_boxu--;
                radek++;
                PictureBox new_pic = new PictureBox();
                new_pic.Width = 20;
                new_pic.Height = 20;
                new_pic.BackColor = Color.Gray;
                new_pic.Location = new Point(x, y);
                new_pic.Tag = "Field";
                this.Controls.Add(new_pic);

                x += 22;
                if (radek > 20)
                {
                    radek = 0;
                    y += 22;
                    x = 20;
                }
            }

            algorithm_bomb();
        }

        public void algorithm_bomb()
        {
            int[] bomby_cisla = new int[Hra.pocet_bomb];
            int picture_box = 0;
            for (int i = 0; i < Hra.pocet_bomb; i++) {
                bomby_cisla[i] = Random.Shared.Next(0, 400);
            }

            foreach (Control prvek in Controls)
            {
                if (prvek.Tag == "Field")
                {
                    if (bomby_cisla.Contains(picture_box))
                    {
                        prvek.BackColor = Color.Black;
                        prvek.Tag += "Bomb";
                    } else
                    {
                        // prvek.Tag += "1";
                    }
                    picture_box++;
                }
            }

            picture_box = -4;

            foreach(Control prvek in Controls)
            {
                if (prvek.Tag == "Field")
                {
                    int pocet_bomb_okolo = 0;

                    for (int i = picture_box - 2 ; i <= picture_box + 1; i++)
                    {
                        if (bomby_cisla.Contains(i) && picture_box % 21 != 0)
                        {
                            pocet_bomb_okolo++;
                        }
                    }

                    for (int i = (picture_box - 21) - 2; i <= (picture_box - 21) + 1; i++)
                    {
                        if (bomby_cisla.Contains(i) && picture_box % 21 != 0)
                        {
                            pocet_bomb_okolo++;
                        }
                    }

                    for (int i = (picture_box + 21) - 2; i <= (picture_box + 21) + 1; i++)
                    {
                        if (bomby_cisla.Contains(i) && picture_box % 21 != 0)
                        {
                            pocet_bomb_okolo++;
                        }
                    }

                    // Nastavení počtu bomb okolo jako tagu pro PictureBox
                    prvek.Tag = pocet_bomb_okolo.ToString();
                    switch (pocet_bomb_okolo)
                    {
                        case 0: prvek.BackColor = Color.Green; break;
                        case 1: prvek.BackColor = Color.Yellow; break;
                        case 2: prvek.BackColor = Color.Orange; break;
                        case 3: prvek.BackColor = Color.Red; break;
                    }
                }
                picture_box++;
            }
            label1.Text = picture_box.ToString();
        }
    }
}
