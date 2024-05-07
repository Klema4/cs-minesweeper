
namespace Rocnikovka_Minesweeper
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            label1 = new Label();
            label2 = new Label();
            btn_jak_hrat = new Button();
            btn_hrat = new Button();
            btn_nastaveni = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(329, 65);
            label1.TabIndex = 0;
            label1.Text = "Minesweeper";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(22, 64);
            label2.Name = "label2";
            label2.Size = new Size(210, 25);
            label2.TabIndex = 1;
            label2.Text = "Windows Forms Edition";
            // 
            // btn_jak_hrat
            // 
            btn_jak_hrat.BackColor = Color.DarkOrange;
            btn_jak_hrat.Location = new Point(12, 210);
            btn_jak_hrat.Name = "btn_jak_hrat";
            btn_jak_hrat.Size = new Size(177, 48);
            btn_jak_hrat.TabIndex = 2;
            btn_jak_hrat.Text = "Jak hrát";
            btn_jak_hrat.UseVisualStyleBackColor = false;
            btn_jak_hrat.Click += btn_jak_hrat_Click;
            // 
            // btn_hrat
            // 
            btn_hrat.BackColor = Color.Chartreuse;
            btn_hrat.Location = new Point(195, 210);
            btn_hrat.Name = "btn_hrat";
            btn_hrat.Size = new Size(187, 48);
            btn_hrat.TabIndex = 3;
            btn_hrat.Text = "Začít hrát";
            btn_hrat.UseVisualStyleBackColor = false;
            btn_hrat.Click += btn_hrat_Click;
            // 
            // btn_nastaveni
            // 
            btn_nastaveni.BackColor = Color.DodgerBlue;
            btn_nastaveni.Location = new Point(388, 210);
            btn_nastaveni.Name = "btn_nastaveni";
            btn_nastaveni.Size = new Size(181, 48);
            btn_nastaveni.TabIndex = 4;
            btn_nastaveni.Text = "Nastavení hry";
            btn_nastaveni.UseVisualStyleBackColor = false;
            btn_nastaveni.Click += btn_nastaveni_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 271);
            Controls.Add(btn_nastaveni);
            Controls.Add(btn_hrat);
            Controls.Add(btn_jak_hrat);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MaximizeBox = false;
            Name = "Menu";
            Text = "Minesweeper";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btn_jak_hrat;
        private Button btn_hrat;
        private Button btn_nastaveni;
    }
}
