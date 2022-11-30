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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Receipt);
            this.panel1.Location = new System.Drawing.Point(-18, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1446, 82);
            this.panel1.TabIndex = 0;
            // 
            // Receipt
            // 
            this.Receipt.AutoSize = true;
            this.Receipt.BackColor = System.Drawing.Color.Black;
            this.Receipt.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Receipt.ForeColor = System.Drawing.Color.White;
            this.Receipt.Location = new System.Drawing.Point(576, 26);
            this.Receipt.Name = "Receipt";
            this.Receipt.Size = new System.Drawing.Size(154, 54);
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
            this.panel2.Location = new System.Drawing.Point(357, 87);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(571, 572);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // rTotal
            // 
            this.rTotal.AutoSize = true;
            this.rTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rTotal.Location = new System.Drawing.Point(201, 509);
            this.rTotal.Name = "rTotal";
            this.rTotal.Size = new System.Drawing.Size(0, 19);
            this.rTotal.TabIndex = 3;
            // 
            // rTax
            // 
            this.rTax.AutoSize = true;
            this.rTax.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rTax.Location = new System.Drawing.Point(201, 486);
            this.rTax.Name = "rTax";
            this.rTax.Size = new System.Drawing.Size(0, 19);
            this.rTax.TabIndex = 2;
            // 
            // rototal
            // 
            this.rototal.AutoSize = true;
            this.rototal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rototal.Location = new System.Drawing.Point(201, 460);
            this.rototal.Name = "rototal";
            this.rototal.Size = new System.Drawing.Size(0, 19);
            this.rototal.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(50, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 37);
            this.label1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(49, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Return Back to Main";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FormReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(151)))), ((int)(((byte)(126)))));
            this.ClientSize = new System.Drawing.Size(1364, 760);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
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
        private Button button1;
    }
}