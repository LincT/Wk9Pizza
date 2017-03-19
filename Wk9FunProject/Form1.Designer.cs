namespace Wk9FunProject
{
    partial class FormMain
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
            this.btnPizza = new System.Windows.Forms.Button();
            this.btnBeverage = new System.Windows.Forms.Button();
            this.btnExtras = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // btnPizza
            // 
            this.btnPizza.Location = new System.Drawing.Point(12, 12);
            this.btnPizza.Name = "btnPizza";
            this.btnPizza.Size = new System.Drawing.Size(75, 23);
            this.btnPizza.TabIndex = 0;
            this.btnPizza.Text = "Pizzas";
            this.btnPizza.UseVisualStyleBackColor = true;
            this.btnPizza.Click += new System.EventHandler(this.btnPizza_Click);
            // 
            // btnBeverage
            // 
            this.btnBeverage.Location = new System.Drawing.Point(12, 41);
            this.btnBeverage.Name = "btnBeverage";
            this.btnBeverage.Size = new System.Drawing.Size(75, 23);
            this.btnBeverage.TabIndex = 1;
            this.btnBeverage.Text = "Beverages";
            this.btnBeverage.UseVisualStyleBackColor = true;
            // 
            // btnExtras
            // 
            this.btnExtras.Location = new System.Drawing.Point(12, 70);
            this.btnExtras.Name = "btnExtras";
            this.btnExtras.Size = new System.Drawing.Size(75, 23);
            this.btnExtras.TabIndex = 2;
            this.btnExtras.Text = "Extras";
            this.btnExtras.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Subtotal";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.BackColor = System.Drawing.Color.White;
            this.lblSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSubTotal.Location = new System.Drawing.Point(160, 229);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(100, 23);
            this.lblSubTotal.TabIndex = 5;
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(12, 231);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(75, 23);
            this.btnCheckout.TabIndex = 6;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(12, 99);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(93, 12);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(179, 214);
            this.checkedListBox1.TabIndex = 8;
            // 
            // FormMain
            // 
            this.AcceptButton = this.btnCheckout;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExtras);
            this.Controls.Add(this.btnBeverage);
            this.Controls.Add(this.btnPizza);
            this.Name = "FormMain";
            this.Text = "Pizza Order";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPizza;
        private System.Windows.Forms.Button btnBeverage;
        private System.Windows.Forms.Button btnExtras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}

