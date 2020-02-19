using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selection;
            string final;
            if(pizzas.SelectedIndex != -1)
            {
                selection = pizzas.SelectedItem.ToString();
                final = "Pizza" + " " + selection + "\n";
                if(selection == "Quatro Stagionni")
                {
                    //cazul asta
                }
                if(selection == "Quatro Formaggi")
                {

                }
                if(selection == "Hawaii")
                {

                }
                if(selection == "Diavola")
                {

                }
                pizzacurenta.Text = final;
            }
        }
    }
}
