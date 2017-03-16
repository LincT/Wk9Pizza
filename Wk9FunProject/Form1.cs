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
            try
            {
                //new FormPizza().Show();
                string pizzaTag;
                //string message = "Item: \n";
                Form pizzaForm = new FormPizza();
                pizzaForm.ShowDialog();
                if (pizzaForm.DialogResult == DialogResult.OK)
                {
                    pizzaTag = pizzaForm.Tag.ToString();
                    /*
                    foreach (string item in pizzatag)
                    {
                        message += item;
                    }
                    */

                    //MessageBox.Show(pizzaTag);
                    //pizzaTag = pizzaForm.Tag.ToString();
                    addItem(pizzaTag);
                }


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

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
