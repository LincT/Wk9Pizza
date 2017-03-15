namespace Wk9FunProject
{
    partial class FormPizza
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.cboSize = new System.Windows.Forms.ComboBox();
            this.cboCrust = new System.Windows.Forms.ComboBox();
            this.clbToppings = new System.Windows.Forms.CheckedListBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cboSauce = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // cboSize
            // 
            this.cboSize.FormattingEnabled = true;
            this.cboSize.Items.AddRange(new object[] {
            "Choose a Size",
            "Personal",
            "Medium",
            "Large",
            "Extra Large",
            "Party Size"});
            this.cboSize.Location = new System.Drawing.Point(12, 12);
            this.cboSize.Name = "cboSize";
            this.cboSize.Size = new System.Drawing.Size(121, 21);
            this.cboSize.TabIndex = 0;
            // 
            // cboCrust
            // 
            this.cboCrust.FormattingEnabled = true;
            this.cboCrust.Items.AddRange(new object[] {
            "Choose a Crust Style",
            "Classic",
            "Hand Tossed",
            "Stuffed Crust",
            "Thin Crust",
            "Deep Dish"});
            this.cboCrust.Location = new System.Drawing.Point(12, 39);
            this.cboCrust.Name = "cboCrust";
            this.cboCrust.Size = new System.Drawing.Size(121, 21);
            this.cboCrust.TabIndex = 1;
            // 
            // clbToppings
            // 
            this.clbToppings.AllowDrop = true;
            this.clbToppings.CheckOnClick = true;
            this.clbToppings.FormattingEnabled = true;
            this.clbToppings.Items.AddRange(new object[] {
            "Chicken",
            "Hamburger",
            "Pepperoni",
            "Black Olives",
            "Green Olives",
            "Spinach",
            "Mushrooms",
            "Garlic",
            "Anchovies",
            "Bell Pepper",
            "Onions"});
            this.clbToppings.Location = new System.Drawing.Point(12, 93);
            this.clbToppings.Name = "clbToppings";
            this.clbToppings.Size = new System.Drawing.Size(120, 109);
            this.clbToppings.TabIndex = 4;
            this.clbToppings.SelectedIndexChanged += new System.EventHandler(this.clbToppings_SelectedIndexChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(12, 226);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // cboSauce
            // 
            this.cboSauce.FormattingEnabled = true;
            this.cboSauce.Items.AddRange(new object[] {
            "Choose a Sauce",
            "None",
            "Tomato",
            "Alfredo",
            "Barbecue",
            "Marinara"});
            this.cboSauce.Location = new System.Drawing.Point(12, 66);
            this.cboSauce.Name = "cboSauce";
            this.cboSauce.Size = new System.Drawing.Size(121, 21);
            this.cboSauce.TabIndex = 6;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(93, 226);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear Form";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(174, 226);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormPizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.cboSauce);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.clbToppings);
            this.Controls.Add(this.cboCrust);
            this.Controls.Add(this.cboSize);
            this.Name = "FormPizza";
            this.Text = "Pizza Designer";
            this.Load += new System.EventHandler(this.FormPizza_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.ComboBox cboSauce;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.CheckedListBox clbToppings;
        private System.Windows.Forms.ComboBox cboCrust;
        private System.Windows.Forms.ComboBox cboSize;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClear;
    }
}