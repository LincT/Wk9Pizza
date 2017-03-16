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
        List<string> addItem = new List<string>();
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnPizza_Click(object sender, EventArgs e)
        {
            new FormPizza().Show();
        }
    }
}
