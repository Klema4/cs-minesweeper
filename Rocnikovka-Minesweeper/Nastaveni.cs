namespace Rocnikovka_Minesweeper
{
    public partial class Nastaveni : Form
    {
        public Nastaveni()
        {
            InitializeComponent();
        }
        private void btn_zpet_Click(object sender, EventArgs e)
        {
            this.Close();
            StreamWriter sw = new StreamWriter("./settings.txt", false);
            sw.WriteLine(num_vlajecky.Value.ToString());
            sw.WriteLine(num_max_miny.Value.ToString());
            sw.WriteLine(num_sance_mina.Value.ToString());
            sw.Close();
        }
    }
}
