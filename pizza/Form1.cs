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
                final = "Pizza" + selection + "\r\n";
                if(selection == "Quatro Stagionni")
                {
                    final = final + "sos de rosii, mozzarella, sunca, salam uscat, ciuperci,masline\r\n500g\r\n18.5lei";
                }
                if(selection == "Quatro Formaggi")
                {
                    final = final + "sos de rosii, mozzarella, ementhaler, gorgonzola, parmezan\r\n550g\r\n19.5lei";
                }
                if(selection == "Afluente")
                {
                    final = final + "sos de rosii, mozzarella, pui, rosii, ardei, curry, chilli, ceapa\r\n550g\r\n18.5lei";
                }
                if(selection == "Diavola")
                {
                    final = final + "sos de rosii, mozzarella, chorizo, ciuperci, ardei iute, chilli\r\n450g\r\n18lei";
                }
                if (selection == "Suprema")
                {
                    final = final + "sos de rosii, mozzarella, sunca, bacon, carnaciori, ceapa, sos BBQ\r\n600g\r\n19lei";
                }
                if (selection == "Colosseum")
                {
                    final = final + "sos de rosii, mozzarella, pui, ardei, rosii, branza feta\r\n500g\r\n17.5lei";
                }
                pizzacurenta.Text = final;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string selection;
            string final;
            float pret = 0;
            if(pizzas.SelectedIndex != -1)
            {
                selection = pizzas.SelectedItem.ToString();
                final = "Order:" + "\r\n";
                final = final + "Pizza " + selection + ", ";
                if (selection == "Quatro Stagionni")
                {
                    
                }
                if (selection == "Quatro Formaggi")
                {
                    final = final + "sos de rosii, mozzarella, ementhaler, gorgonzola, parmezan\r\n550g\r\n19.5lei";
                }
                if (selection == "Afluente")
                {
                    final = final + "sos de rosii, mozzarella, pui, rosii, ardei, curry, chilli, ceapa\r\n550g\r\n18.5lei";
                }
                if (selection == "Diavola")
                {
                    final = final + "sos de rosii, mozzarella, chorizo, ciuperci, ardei iute, chilli\r\n450g\r\n18lei";
                }
                if (selection == "Suprema")
                {
                    final = final + "sos de rosii, mozzarella, sunca, bacon, carnaciori, ceapa, sos BBQ\r\n600g\r\n19lei";
                }
                if (selection == "Colosseum")
                {
                    final = final + "sos de rosii, mozzarella, pui, ardei, rosii, branza feta\r\n500g\r\n17.5lei";
                }
            }
    }
}
