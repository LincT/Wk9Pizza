using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wk9FunProject
{
    public partial class FormPizza : Form
    {
        //global variable to pass to other forms
        List<string> pizza = new List<string>();

        public List<string> addPizza
        {
            get { return pizza; }
        }
        public FormPizza()
        {
            InitializeComponent();
        }

        private void FormPizza_Load(object sender, EventArgs e)
        {
            initialize();
        }

        public void initialize()
        {
            cboSize.SelectedIndex = 0;
            cboCrust.SelectedIndex = 0;
            cboSauce.SelectedIndex = 0;
            clbToppings.ClearSelected();
            foreach (int i in clbToppings.CheckedIndices)
            {
                clbToppings.SetItemCheckState(i, CheckState.Unchecked);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            initialize();
        }

        private void clbToppings_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int toppingCount = clbToppings.CheckedIndices.Count;
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            //comment
        }
        

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            pizza.Add(cboSize.Text);
            pizza.Add(cboSauce.Text);
            pizza.Add(cboCrust.Text);
            foreach (object itemChecked in clbToppings.CheckedItems)
            {
                pizza.Add(itemChecked.ToString());
            }
            string result = "Pizza: \n";
            foreach (string item in pizza)
            {
                result += item + ", ";
            }
            MessageBox.Show(result);
            this.Tag = result;
            this.DialogResult = DialogResult.OK;
        }

    }
}
