namespace Rocnikovka_Minesweeper
{
    partial class Nastaveni
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nastaveni));
            label1 = new Label();
            btn_zpet = new Button();
            label2 = new Label();
            num_vlajecky = new NumericUpDown();
            num_max_miny = new NumericUpDown();
            label3 = new Label();
            num_sance_mina = new NumericUpDown();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)num_vlajecky).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_max_miny).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_sance_mina).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(253, 65);
            label1.TabIndex = 2;
            label1.Text = "Nastavení";
            // 
            // btn_zpet
            // 
            btn_zpet.Location = new Point(341, 387);
            btn_zpet.Name = "btn_zpet";
            btn_zpet.Size = new Size(168, 51);
            btn_zpet.TabIndex = 3;
            btn_zpet.Text = "Zpět do menu";
            btn_zpet.UseVisualStyleBackColor = true;
            btn_zpet.Click += btn_zpet_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 74);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 4;
            label2.Text = "Počet vlaječek";
            // 
            // num_vlajecky
            // 
            num_vlajecky.Location = new Point(25, 92);
            num_vlajecky.Name = "num_vlajecky";
            num_vlajecky.Size = new Size(120, 23);
            num_vlajecky.TabIndex = 5;
            num_vlajecky.Value = new decimal(new int[] { 40, 0, 0, 0 });
            // 
            // num_max_miny
            // 
            num_max_miny.Location = new Point(25, 150);
            num_max_miny.Name = "num_max_miny";
            num_max_miny.Size = new Size(120, 23);
            num_max_miny.TabIndex = 7;
            num_max_miny.Value = new decimal(new int[] { 15, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 132);
            label3.Name = "label3";
            label3.Size = new Size(152, 15);
            label3.TabIndex = 6;
            label3.Text = "Maximální počet min v poli";
            // 
            // num_sance_mina
            // 
            num_sance_mina.Location = new Point(25, 211);
            num_sance_mina.Name = "num_sance_mina";
            num_sance_mina.Size = new Size(120, 23);
            num_sance_mina.TabIndex = 9;
            num_sance_mina.Value = new decimal(new int[] { 7, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 193);
            label4.Name = "label4";
            label4.Size = new Size(154, 15);
            label4.TabIndex = 8;
            label4.Text = "Procentuální šance na minu";
            // 
            // Nastaveni
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 450);
            Controls.Add(num_sance_mina);
            Controls.Add(label4);
            Controls.Add(num_max_miny);
            Controls.Add(label3);
            Controls.Add(num_vlajecky);
            Controls.Add(label2);
            Controls.Add(btn_zpet);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Nastaveni";
            Text = "Minesweeper - Nastavení hry";
            ((System.ComponentModel.ISupportInitialize)num_vlajecky).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_max_miny).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_sance_mina).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btn_zpet;
        private Label label2;
        private NumericUpDown num_vlajecky;
        private NumericUpDown num_max_miny;
        private Label label3;
        private NumericUpDown num_sance_mina;
        private Label label4;
    }
}