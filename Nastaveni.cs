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
            sw.WriteLine(num_vlajecky.Value);
            sw.WriteLine(num_max_miny.Value);
            sw.Close();
        }

        private void Nastaveni_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("./settings.txt");
            while (!sr.EndOfStream)
            {
                num_vlajecky.Value = Convert.ToInt32(sr.ReadLine());
                num_max_miny.Value = Convert.ToInt32(sr.ReadLine());
            }

            sr.Close();
        }
    }
}
