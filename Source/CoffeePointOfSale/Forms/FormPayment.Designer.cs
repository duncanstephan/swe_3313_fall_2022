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
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBoxCardNum = new System.Windows.Forms.TextBox();
            this.textBoxZip = new System.Windows.Forms.TextBox();
            this.textBoxCVV = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(356, 88);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Pay With Credit Card";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnPayWithCredit_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(701, 18);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(322, 484);
            this.listBox1.TabIndex = 1;
            // 
            // textBoxCardNum
            // 
            this.textBoxCardNum.Location = new System.Drawing.Point(22, 45);
            this.textBoxCardNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCardNum.Name = "textBoxCardNum";
            this.textBoxCardNum.Size = new System.Drawing.Size(258, 23);
            this.textBoxCardNum.TabIndex = 2;
            this.textBoxCardNum.Text = "Card#";
            // 
            // textBoxZip
            // 
            this.textBoxZip.Location = new System.Drawing.Point(22, 77);
            this.textBoxZip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxZip.Name = "textBoxZip";
            this.textBoxZip.Size = new System.Drawing.Size(258, 23);
            this.textBoxZip.TabIndex = 3;
            this.textBoxZip.Text = "Zip Code";
            // 
            // textBoxCVV
            // 
            this.textBoxCVV.Location = new System.Drawing.Point(22, 110);
            this.textBoxCVV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCVV.Name = "textBoxCVV";
            this.textBoxCVV.Size = new System.Drawing.Size(258, 23);
            this.textBoxCVV.TabIndex = 4;
            this.textBoxCVV.Text = "CVV";
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
            // FormPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 510);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxCVV);
            this.Controls.Add(this.textBoxZip);
            this.Controls.Add(this.textBoxCardNum);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormPayment";
            this.Text = "FormPayment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private ListBox listBox1;
        private TextBox textBoxCardNum;
        private TextBox textBoxZip;
        private TextBox textBoxCVV;
        private Button button2;
    }
}