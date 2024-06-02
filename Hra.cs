using System.Text.Json.Serialization;

namespace Rocnikovka_Minesweeper
{
    public partial class Hra : Form
    {
        // Deklarace proměnných
        private static int pocet_boxu = 399;
        private static int radek = 0;
        private static int pocet_bodu = 0;

        public Hra()
        {
            InitializeComponent();
        }

        // Základní nastavení z čtení souboru
        public static StreamReader sr = new StreamReader("./settings.txt");
        public static int pocet_vlajecek = Convert.ToInt16(sr.ReadLine());
        public static int pocet_bomb = Convert.ToInt16(sr.ReadLine());

        // Začátek pro hrací pole
        int x = 20;
        int y = 100;

        private void Hra_Load(object sender, EventArgs e)
        {
            while (Hra.pocet_boxu > 0)
            {
                // Nastavení počtu boxů
                pocet_boxu--;
                radek++;
                PictureBox new_pic = new PictureBox();

                // Nastavení vlastností PictureBoxu
                new_pic.Width = 20;
                new_pic.Height = 20;

                // Přidání obrázku
                new_pic.BackgroundImageLayout = ImageLayout.Stretch;
                new_pic.BackgroundImage = Image.FromFile("../../../Resources/block.png");
                new_pic.Location = new Point(x, y);
                new_pic.Tag = "Field";

                // Poslouchej na kliknutí myši
                new_pic.MouseClick += new MouseEventHandler(Field_Click);

                // Generovat PictureBox do formuláře
                this.Controls.Add(new_pic);

                // Algoritmus pro vytvoření hracího pole
                x += 20;
                if (radek > 20)
                {
                    radek = 0;
                    y += 20;
                    x = 20;
                }
            }

            // Zavolání funkce pro generování min
            algorithm_bomb();
        }

        private void Field_Click(object? sender, MouseEventArgs e)
        {
            // Pokud je kliknuto pravým tlačítkem myšie.Button == MouseButtons.Right)
            if (e.Button == MouseButtons.Right)
            {
                // Získání PictureBoxu
                PictureBox pb = (PictureBox)sender;

                // Pokud je vlaječka
                if (pb.Tag.ToString().Contains("FieldFlag"))
                {
                    // Odebrání vlaječky
                    pb.BackgroundImage = Image.FromFile("../../../Resources/block.png");
                    string[] tags = pb.Tag.ToString().Split(";");
                    pb.Tag = tags[1];
                    pocet_vlajecek++;
                    lb_vlajecky.Text = pocet_vlajecek.ToString();
                }
                else
                {
                    // Přidání podmínky, aby nešla přidat vlaječka na již otevřené místo
                    if (pb.Tag.ToString().Contains("Unlocked"))
                    {
                        return;
                    }
                    else
                    {
                        // Přidání vlaječky
                        pb.BackgroundImage = Image.FromFile("../../../Resources/flag.png");
                        pb.Tag = "FieldFlag;" + pb.Tag;
                        pocet_vlajecek--;
                        lb_vlajecky.Text = pocet_vlajecek.ToString();
                    }
                }
            }
            else
            {
                // Získání PictureBoxu
                PictureBox pb = (PictureBox)sender;

                // Pokud je vlaječka, tak se nic nestane
                if (pb.Tag.ToString().Contains("FieldFlag") || pb.Tag.ToString().Contains("Unlocked"))
                {
                    return;
                }

                if (pb.Tag.ToString().Contains("Bomb"))
                {
                    // Zobrazení všech bomb
                    foreach (Control prvek in Controls)
                    {
                        if (prvek.Tag != null && prvek.Tag.ToString().Contains("Bomb"))
                        {
                            prvek.BackgroundImage = Image.FromFile("../../../Resources/bomb.png");
                        }
                    }

                    // Zobrazení MessageBoxu
                    MessageBox.Show($"Šlápl jsi na minu...\nTvé skóre je: {pocet_bodu}", "Konec hry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Restart();
                }
                else
                {
                    // Zobrazení kostičky
                    pb.BackgroundImageLayout = ImageLayout.Stretch;
                    switch (pb.Tag.ToString())
                    {
                        case "01":
                            pb.BackgroundImage = Image.FromFile("../../../Resources/block_unlocked.png");
                            if (!pb.Tag.ToString().Contains("Unlocked"))
                            {
                                pb.Tag += "Unlocked";
                                pocet_bodu += 1;
                            }
                            break;
                        case "12":
                            pb.BackgroundImage = Image.FromFile("../../../Resources/num_1.png");
                            if (!pb.Tag.ToString().Contains("Unlocked"))
                            {
                                pb.Tag += "Unlocked";
                                pocet_bodu += 2;
                            }
                            break;
                        case "23":
                            pb.BackgroundImage = Image.FromFile("../../../Resources/num_2.png");
                            if (!pb.Tag.ToString().Contains("Unlocked"))
                            {
                                pb.Tag += "Unlocked";
                                pocet_bodu += 3;
                            }
                            break;
                        case "34":
                            pb.BackgroundImage = Image.FromFile("../../../Resources/num_3.png");
                            if (!pb.Tag.ToString().Contains("Unlocked"))
                            {
                                pb.Tag += "Unlocked";
                                pocet_bodu += 4;
                            }
                            break;
                        default:
                            pb.BackgroundImage = Image.FromFile("../../../Resources/block_unlocked.png");
                            if (!pb.Tag.ToString().Contains("Unlocked"))
                            {
                                pb.Tag += "Unlocked";
                                pocet_bodu += 1;
                            }
                            break;

                    }
                    lb_skore.Text = pocet_bodu.ToString();
                }
            }
        }

        public void algorithm_bomb()
        {
            // Vytvoření HashSetu pro uložení čísel políček, ve kterých se nachází mina
            HashSet<int> bomby_cisla = new HashSet<int>();
            int picture_box = 0;
            for (int i = 0; i <= Hra.pocet_bomb; i++)
            {
                // Přidání náhodného čísla do HashSetu
                bomby_cisla.Add(Random.Shared.Next(0, 400));
            }

            // Projetí každého prvku a kontrola, jestli má tag Field
            foreach (Control prvek in Controls)
            {
                if (prvek.Tag == "Field")
                {
                    // Pokud PictureBox má stejné číslo jako je uloženo v bomby_cisla, přidá se mu tag "Bomb" se středníkem pro oddělení tagů
                    if (bomby_cisla.Contains(picture_box))
                    {
                        prvek.Tag += "Bomb;";
                    }
                    picture_box++;
                }
            }

            // Základní nastavení počítadla (-4 z důvodu počítání labelů jako součást prvků)
            picture_box = -4;

            // Nastavení počtu bomb okolo polí
            foreach (Control prvek in Controls)
            {
                if (prvek.Tag == "Field")
                {
                    int pocet_bomb_okolo = 0;

                    // Kontrola, zda se v okolí nachází bomba
                    for (int i = picture_box - 1; i <= picture_box + 1; i++)
                    {
                        if (bomby_cisla.Contains(i))
                        {
                            pocet_bomb_okolo++;
                        }
                    }

                    for (int i = picture_box - 22; i <= picture_box - 20; i++)
                    {
                        if (bomby_cisla.Contains(i))
                        {
                            pocet_bomb_okolo++;
                        }
                    }

                    for (int i = picture_box + 20; i <= picture_box + 22; i++)
                    {
                        if (bomby_cisla.Contains(i))
                        {
                            pocet_bomb_okolo++;
                        }
                    }

                    // Přidání počtu min okolo do Tagu
                    prvek.Tag = pocet_bomb_okolo.ToString();
                    prvek.BackgroundImageLayout = ImageLayout.Stretch;

                    switch (pocet_bomb_okolo)
                    {
                        case 0: prvek.Tag += "1"; break;
                        case 1: prvek.Tag += "2"; break;
                        case 2: prvek.Tag += "3"; break;
                        case 3: prvek.Tag += "4"; break;
                    }
                }
                picture_box++;
            }
        }
    }
}
