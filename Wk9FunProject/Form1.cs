﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace Wk9FunProject
{
    public partial class FormMain : Form
    {
        //Eric Holmboe
        //Joseph Martin
        //Rhandee Livingston
        /*
         * Still need to define prices for items, done in sorted list.
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
                
                string pizzaTag;
                
                Form pizzaForm = new FormPizza();
                pizzaForm.ShowDialog();
                if (pizzaForm.DialogResult == DialogResult.OK)
                {
                    pizzaTag = pizzaForm.Tag.ToString();
                    /*
                     //commented out list handling
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            SortedList<string, decimal> priceList = new SortedList<string, decimal>
            { { "default", 0.00m },
                { "Soda-2l",1.99m },
                { "Dessert", 1.21m},
                { "Fibonacci", 1123.58m }
            };
            
        }
        public decimal priceCheck(string item)
        {
            SortedList<string, decimal> priceList = new SortedList<string, decimal>
            { { "default", 0.00m },
                { "Soda-2l",1.99m },
                { "Dessert", 1.21m},
                {"Fibonacci", 1123.58m }
            };
            try
            {
                decimal price = priceList[item];
                return price;
            }
            catch(KeyNotFoundException)
            {
                Debug.Write("Price missing:" + item + "returned 0.00m");
                decimal price = 0.00m;
                return price;

            }
            catch(Exception ex)
            {
                //the program should be friendly towards customers, 
                //"honest" with programmers
                Debug.Write(ex.Message);
                throw;
            }
            
        }
    }
}
