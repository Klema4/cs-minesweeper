﻿using System;
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
