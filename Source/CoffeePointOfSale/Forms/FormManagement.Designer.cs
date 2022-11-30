namespace CoffeePointOfSale.Forms
{
    partial class FormManagement
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
            this.BtnGenCsv = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.mainmenu = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnGenCsv
            // 
            this.BtnGenCsv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(211)))), ((int)(((byte)(83)))));
            this.BtnGenCsv.Location = new System.Drawing.Point(613, 329);
            this.BtnGenCsv.Name = "BtnGenCsv";
            this.BtnGenCsv.Size = new System.Drawing.Size(136, 85);
            this.BtnGenCsv.TabIndex = 1;
            this.BtnGenCsv.Text = "Generate CSV file and open in Excel";
            this.BtnGenCsv.UseVisualStyleBackColor = false;
            this.BtnGenCsv.Click += new System.EventHandler(this.BtnGenCsv_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.mainmenu);
            this.panel1.Location = new System.Drawing.Point(-95, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1467, 72);
            this.panel1.TabIndex = 4;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(113, 16);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(143, 37);
            this.button5.TabIndex = 13;
            this.button5.Text = "Return to Main Menu";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.OnClickBtnClose);
            // 
            // mainmenu
            // 
            this.mainmenu.AutoSize = true;
            this.mainmenu.BackColor = System.Drawing.Color.Black;
            this.mainmenu.CausesValidation = false;
            this.mainmenu.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mainmenu.ForeColor = System.Drawing.Color.White;
            this.mainmenu.Location = new System.Drawing.Point(653, 9);
            this.mainmenu.Name = "mainmenu";
            this.mainmenu.Size = new System.Drawing.Size(259, 54);
            this.mainmenu.TabIndex = 0;
            this.mainmenu.Text = "Management";
            // 
            // FormManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(151)))), ((int)(((byte)(126)))));
            this.ClientSize = new System.Drawing.Size(1364, 760);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnGenCsv);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormManagement";
            this.Text = "FormManagement";
            this.Load += new System.EventHandler(this.OnLoadFormManagement);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Button BtnGenCsv;
        private Panel panel1;
        private Label mainmenu;
        private Button button5;
    }
}