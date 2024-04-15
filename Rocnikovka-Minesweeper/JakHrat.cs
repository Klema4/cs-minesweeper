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
    public partial class JakHrat : Form
    {
        public JakHrat()
        {
            InitializeComponent();
        }
        private void btn_zpet_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
