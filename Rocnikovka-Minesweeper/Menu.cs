namespace Rocnikovka_Minesweeper
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
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
