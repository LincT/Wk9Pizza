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
    public partial class FormMain : Form
    {
        //Eric Holmboe
        //Joseph Martin
        //Rhandee Livingston
        /*
         * Still need to define prices for items, perhaps a jagged array referencing 
         * [string,price]?
         * output from pizza form can either be returned as a list or a string
         */
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnPizza_Click(object sender, EventArgs e)
        {
            //new FormPizza().Show();
            string pizzatag;
            Form pizzaForm = new FormPizza();
            pizzaForm.ShowDialog();
            if (pizzaForm.DialogResult == DialogResult.OK){
                pizzatag = pizzaForm.Tag.ToString();
                addItem(pizzatag);
            }
            
            
        }

        public void addItem(string itemTag)
        {
            //add the item to the text box, also add a new 
            //line with an item total maybe?
            txtItems.Text += itemTag;
        }
    }
}
