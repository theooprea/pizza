using System;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

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
            ofertazilei.Text = "Oferta zilei:\r\n";
            int day = (int)DateTime.Now.DayOfWeek;
            string oferta = "";
            if(day == 1 || day == 3 || day == 5)
            {
                oferta = "3 Pizza + 1 Gratis";
            }
            if(day == 2 || day == 4)
            {
                oferta = "2 Pizza + 1 Gratis";
            }
            if(day == 0 || day == 6)
            {
                oferta = "1 Pizza + 1 Gratis";
            }
            ofertazilei.Text = ofertazilei.Text + oferta;
            ofertazilei.Text = ofertazilei.Text + " " + ofertazilei.Text[15];
            PopupNotifier popup = new PopupNotifier();
            popup.TitleText = "Oferta zilei";
            popup.ContentText = oferta;
            popup.Popup();
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
            int i, j;
            string selection;
            string previous;
            string final;
            string previouspret = pretcurent.Text;
            string currentprice = string.Empty;
            for(i=0;i<previouspret.Length;i++)
            {
                if(Char.IsDigit(previouspret[i])||previouspret[i]=='.')
                {
                    currentprice += previouspret[i];
                }
            }
            double pret;
            pret = Convert.ToDouble(currentprice);
            previous = order.Text;
            if (pizzas.SelectedIndex != -1)
            {
                selection = pizzas.SelectedItem.ToString();
                final = "Pizza " + selection + "; ";
                order.Text = previous + final;
                if (selection == "Quatro Stagionni")
                {
                    pret += 18.5;
                }
                if (selection == "Quatro Formaggi")
                {
                    pret += 19.5;
                }
                if (selection == "Afluente")
                {
                    pret += 18.5;
                }
                if (selection == "Diavola")
                {
                    pret += 18;
                }
                if (selection == "Suprema")
                {
                    pret += 19;
                }
                if (selection == "Colosseum")
                {
                    pret += 17.5;
                }
            }
            string pretul;
            pretul = pret.ToString();
            pretcurent.Text = "Pret neredus: " + pretul + " lei";
            int pizze = 0;
            for(i = 0; i < order.Text.Length; i++)
            {
                if(order.Text[i] == ';')
                {
                    pizze++;
                }
            }
            double aux;
            int stackpizza = ofertazilei.Text[15] - '0' + 1;
            int reduceri = pizze / stackpizza;
            double[] vector = new double[50];
            string[] words = order.Text.Split(';');
            for (i = 0; i < pizze; i++)
            {
                string Value = "Pizza Quatro Stagionni";
                if (words[i].IndexOf(Value) != -1)
                {
                    vector[i] = 18.5;
                }
                Value = "Pizza Quatro Formaggi";
                if (words[i].IndexOf(Value) != -1)
                {
                    vector[i] = 19.5;
                }
                Value = "Pizza Afluente";
                if (words[i].IndexOf(Value) != -1)
                {
                    vector[i] = 18.5;
                }
                Value = "Pizza Diavola";
                if (words[i].IndexOf(Value) != -1)
                {
                    vector[i] = 18;
                }
                Value = "Pizza Suprema";
                if (words[i].IndexOf(Value) != -1)
                {
                    vector[i] = 19;
                }
                Value = "Pizza Colosseum";
                if (words[i].IndexOf(Value) != -1)
                {
                    vector[i] = 17.5;
                }
            }
            for(i = 0; i < pizze-1; i++)
            {
                for(j = i + 1; j < pizze; j++)
                {
                    if(vector[i] > vector[j])
                    {
                        aux = vector[i];
                        vector[i] = vector[j];
                        vector[j] = aux;
                    }
                }
            }
            double pretredu = pret;
            for(i = 0; i < reduceri; i++)
            {
                pretredu -= vector[i];
            }
            pretredus.Text = "Pret final: " + pretredu + " lei";
        }

        private void pretcurent_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            pretcurent.Text = "Pret neredus: 0 lei";
            pretredus.Text = "Pret final: 0 lei";
            order.Text = "";
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            PopupNotifier popup = new PopupNotifier();
            popup.TitleText = "Notification";
            popup.ContentText = "Comanda dumneavoastra a fost plasata!\r\n" + pretredus.Text;
            popup.Popup();
            pretcurent.Text = "Pret neredus: 0 lei";
            pretredus.Text = "Pret final: 0 lei";
            order.Text = "";
        }
    }
}
