namespace CoffeePointOfSale.Forms
{
    partial class FormPayment
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
            this.BtnPayWithCredit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.osubtotal = new System.Windows.Forms.Label();
            this.taxp = new System.Windows.Forms.Label();
            this.ototalp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnPayWithCredit
            // 
            this.BtnPayWithCredit.BackColor = System.Drawing.Color.LimeGreen;
            this.BtnPayWithCredit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnPayWithCredit.Location = new System.Drawing.Point(356, 110);
            this.BtnPayWithCredit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnPayWithCredit.Name = "BtnPayWithCredit";
            this.BtnPayWithCredit.Size = new System.Drawing.Size(164, 41);
            this.BtnPayWithCredit.TabIndex = 0;
            this.BtnPayWithCredit.Text = "Pay With Credit Card";
            this.BtnPayWithCredit.UseVisualStyleBackColor = false;
            this.BtnPayWithCredit.Click += new System.EventHandler(this.BtnPayWithCredit_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 45);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(258, 23);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Card#";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(22, 77);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(258, 23);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Zip Code";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(22, 110);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(258, 23);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "CVV";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(356, 341);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 38);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(644, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(7, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(557, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "_________________________________________________________________________________" +
    "_____________________________";
            // 
            // osubtotal
            // 
            this.osubtotal.AutoSize = true;
            this.osubtotal.Location = new System.Drawing.Point(703, 246);
            this.osubtotal.Name = "osubtotal";
            this.osubtotal.Size = new System.Drawing.Size(0, 15);
            this.osubtotal.TabIndex = 8;
            // 
            // taxp
            // 
            this.taxp.AutoSize = true;
            this.taxp.Location = new System.Drawing.Point(703, 276);
            this.taxp.Name = "taxp";
            this.taxp.Size = new System.Drawing.Size(0, 15);
            this.taxp.TabIndex = 9;
            // 
            // ototalp
            // 
            this.ototalp.AutoSize = true;
            this.ototalp.Location = new System.Drawing.Point(703, 306);
            this.ototalp.Name = "ototalp";
            this.ototalp.Size = new System.Drawing.Size(0, 15);
            this.ototalp.TabIndex = 10;
            // 
            // FormPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(151)))), ((int)(((byte)(126)))));
            this.ClientSize = new System.Drawing.Size(1178, 535);
            this.Controls.Add(this.ototalp);
            this.Controls.Add(this.taxp);
            this.Controls.Add(this.osubtotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BtnPayWithCredit);
            this.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.Name = "FormPayment";
            this.Text = "FormPayment";
            this.Load += new System.EventHandler(this.FormPayment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnPayWithCredit;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private Label label2;
        private Label osubtotal;
        private Label taxp;
        private Label ototalp;
    }
}