namespace Rocnikovka_Minesweeper
{
    partial class Hra
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hra));
            label1 = new Label();
            label2 = new Label();
            lb_skore = new Label();
            lb_vlajecky = new Label();
            nacteni = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 0;
            label1.Text = "Počet vlaječek";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(130, 9);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 1;
            label2.Text = "Skóre";
            // 
            // lb_skore
            // 
            lb_skore.AutoSize = true;
            lb_skore.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lb_skore.Location = new Point(128, 24);
            lb_skore.Name = "lb_skore";
            lb_skore.RightToLeft = RightToLeft.Yes;
            lb_skore.Size = new Size(38, 45);
            lb_skore.TabIndex = 2;
            lb_skore.Text = "0";
            // 
            // lb_vlajecky
            // 
            lb_vlajecky.AutoSize = true;
            lb_vlajecky.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lb_vlajecky.Location = new Point(12, 24);
            lb_vlajecky.Name = "lb_vlajecky";
            lb_vlajecky.Size = new Size(56, 45);
            lb_vlajecky.TabIndex = 3;
            lb_vlajecky.Text = "40";
            // 
            // nacteni
            // 
            nacteni.Enabled = true;
            nacteni.Interval = 50;
            nacteni.Tick += nacteni_Tick;
            // 
            // Hra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 563);
            Controls.Add(lb_vlajecky);
            Controls.Add(lb_skore);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Hra";
            Text = "Minesweeper - Herní okno";
            Load += Hra_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lb_skore;
        private Label lb_vlajecky;
        private System.Windows.Forms.Timer nacteni;
    }
}