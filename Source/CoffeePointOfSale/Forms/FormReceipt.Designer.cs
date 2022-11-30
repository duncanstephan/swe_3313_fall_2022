namespace CoffeePointOfSale.Forms
{
    partial class FormReceipt
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Receipt = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rTotal = new System.Windows.Forms.Label();
            this.rTax = new System.Windows.Forms.Label();
            this.rototal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.Receipt);
            this.panel1.Location = new System.Drawing.Point(-21, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1661, 85);
            this.panel1.TabIndex = 0;
            // 
            // Receipt
            // 
            this.Receipt.AutoSize = true;
            this.Receipt.BackColor = System.Drawing.Color.Black;
            this.Receipt.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Receipt.ForeColor = System.Drawing.Color.White;
            this.Receipt.Location = new System.Drawing.Point(760, 19);
            this.Receipt.Name = "Receipt";
            this.Receipt.Size = new System.Drawing.Size(131, 46);
            this.Receipt.TabIndex = 0;
            this.Receipt.Text = "Receipt";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.rTotal);
            this.panel2.Controls.Add(this.rTax);
            this.panel2.Controls.Add(this.rototal);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(499, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(651, 925);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // rTotal
            // 
            this.rTotal.AutoSize = true;
            this.rTotal.Location = new System.Drawing.Point(252, 732);
            this.rTotal.Name = "rTotal";
            this.rTotal.Size = new System.Drawing.Size(0, 20);
            this.rTotal.TabIndex = 3;
            // 
            // rTax
            // 
            this.rTax.AutoSize = true;
            this.rTax.Location = new System.Drawing.Point(252, 701);
            this.rTax.Name = "rTax";
            this.rTax.Size = new System.Drawing.Size(0, 20);
            this.rTax.TabIndex = 2;
            // 
            // rototal
            // 
            this.rototal.AutoSize = true;
            this.rototal.Location = new System.Drawing.Point(252, 667);
            this.rototal.Name = "rototal";
            this.rototal.Size = new System.Drawing.Size(0, 20);
            this.rototal.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(57, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 46);
            this.label1.TabIndex = 0;
            // 
            // FormReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(151)))), ((int)(((byte)(126)))));
            this.ClientSize = new System.Drawing.Size(1541, 961);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.Name = "FormReceipt";
            this.Text = "FormReceipt";
            this.Load += new System.EventHandler(this.FormReceipt_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label Receipt;
        private Panel panel2;
        private Label label1;
        private Label rTotal;
        private Label rTax;
        private Label rototal;
    }
}