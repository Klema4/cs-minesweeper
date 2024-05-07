namespace Rocnikovka_Minesweeper
{
    partial class JakHrat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JakHrat));
            label1 = new Label();
            btn_zpet = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(227, 65);
            label1.TabIndex = 0;
            label1.Text = "Jak hrát?";
            // 
            // btn_zpet
            // 
            btn_zpet.Location = new Point(369, 387);
            btn_zpet.Name = "btn_zpet";
            btn_zpet.Size = new Size(168, 51);
            btn_zpet.TabIndex = 1;
            btn_zpet.Text = "Zpět do menu";
            btn_zpet.UseVisualStyleBackColor = true;
            btn_zpet.Click += btn_zpet_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 74);
            label2.Name = "label2";
            label2.Size = new Size(218, 15);
            label2.TabIndex = 2;
            label2.Text = "Zcela jednoduše! awdawdawdawwdawd";
            // 
            // JakHrat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 450);
            Controls.Add(label2);
            Controls.Add(btn_zpet);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "JakHrat";
            Text = "Minesweeper - Jak hrát";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_zpet;
        private Label label2;
    }
}