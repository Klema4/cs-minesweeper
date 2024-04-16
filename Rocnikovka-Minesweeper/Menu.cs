namespace Rocnikovka_Minesweeper
{
    public partial class Menu : Form
    {
        int pocet_vlajecek, pocet_max_min, sance_mina;
        public Menu()
        {
            InitializeComponent();
            if (!File.Exists("./settings.txt"))
            {
                StreamWriter sw = new StreamWriter("./settings.txt", false);
                sw.WriteLine("40");
                sw.WriteLine("15");
                sw.WriteLine("7");

                sw.Close();

                pocet_vlajecek = 40;
                pocet_max_min = 15;
                sance_mina = 7;
            }
        }

        private void btn_jak_hrat_Click(object sender, EventArgs e)
        {
            new JakHrat().ShowDialog();
        }

        private void btn_nastaveni_Click(object sender, EventArgs e)
        {
            new Nastaveni().ShowDialog();
        }

        private void btn_hrat_Click(object sender, EventArgs e)
        {
            new Hra().ShowDialog();
        }
    }
}
