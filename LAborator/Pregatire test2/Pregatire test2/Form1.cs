using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pregatire_test2
{
    public partial class Form1 : Form
    {
        List<Carte> carti = new List<Carte> { };
        public Form1()
        {
            InitializeComponent();
            comboBox1.Text = "Selecteaza...";
            for(int i=2019; i>=1300; i--)
            {
                comboBox1.Items.Add(i);
            }
            comboBox2.Text = "Selecteaza...";
            string[] autor;
            autor= new string[5] { "Eminescu", " Creanga", "Eliade", "Cojbuc", "Ioan Slavici" };
            for(int i=0; i<5; i++)
            {
                comboBox2.Items.Add(autor[i]);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label5.Text = "Warning";
            if(textBox2.Text.Length == 0 || !(Int32.TryParse(textBox2.Text, out int pagini)))
            {
                label5.Text += "\nNr pagini invalid";
            }
            else
            {
                Int32.TryParse(textBox2.Text, out pagini);
                if (pagini <7 || pagini >2000)
                {
                    label5.Text += "\nNr pagini necorespunzator";
                }
            }
            if(textBox1.Text.Length==0)
            {
                label5.Text += "\nTitlu necompletat";
            }
            if(comboBox1.Text=="Selecteaza...")
            {
                label5.Text += "\nAutor neselectat";
            }
            if(comboBox2.Text=="Selecteaza...")
            {
                label5.Text += "\nAn publicatie neselectat";
            }
            if(radioButton1.Checked==false && radioButton2.Checked==false)
            {
                label5.Text += "\nFormat neselectat";
            }
            if(label5.Text=="Warning")
            {
                if(radioButton1.Checked ==true)
                {
                    Carte c = new Carte(textBox1.Text, comboBox2.Text, Convert.ToInt32(comboBox1.Text), Convert.ToInt32(textBox2.Text), radioButton1.Text);
                    carti.Add(c);
                }
                else
                {
                    Carte c = new Carte(textBox1.Text, comboBox2.Text, Convert.ToInt32(comboBox1.Text), Convert.ToInt32(textBox2.Text), radioButton2.Text);
                    carti.Add(c);
                }
                comboBox1.Text = "Selecteaza...";
                comboBox2.Text = "Selecteaza...";
                textBox1.Text = "";
                textBox2.Text = "";
                radioButton1.Checked = false;
                radioButton2.Checked = false;
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            // for(int i=0; i < listView1.Items.Count;i++)
            //{
            //    listView1.Items[i].Remove();
            //}
            foreach (var car in carti)
            {
                var row = new string[] { car.Titlu, car.Autor, car.AnPublicatie.ToString(), car.NrPagini.ToString(), car.Format };
                var lvi = new ListViewItem(row);
                lvi.Tag = car;
                listView1.Items.Add(lvi);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label5.Text = "Warning";
            int index = -1;
            if (listView1.SelectedIndices.Count == 0)
            {
                label5.Text += "\n Alegeti cartea";
            }
            else
            {
                index = listView1.SelectedItems[0].Index;
                
                if (textBox2.Text.Length == 0 || !(Int32.TryParse(textBox2.Text, out int pagini)))
                {
                    label5.Text += "\nNr pagini invalid";
                }
                else
                {
                    Int32.TryParse(textBox2.Text, out pagini);
                    if (pagini < 7 || pagini > 2000)
                    {
                        label5.Text += "\nNr pagini necorespunzator";
                    }
                    else
                    {
                        carti[index].NrPagini = pagini;
                    }
                }
                if (comboBox1.Text != "Selecteaza...")
                {
                    if (Convert.ToInt32(comboBox1.Text) != carti[index].AnPublicatie)
                    {
                        carti[index].AnPublicatie = Convert.ToInt32(comboBox1.Text);
                    }
                    else
                    {
                        label5.Text += "\nAnul selectat este acelasi";
                    }
                }
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            // for(int i=0; i < listView1.Items.Count;i++)
            //{
            //    listView1.Items[i].Remove();
            //}
            foreach (var car in carti)
            {
                var row = new string[] { car.Titlu, car.Autor, car.AnPublicatie.ToString(), car.NrPagini.ToString(), car.Format };
                var lvi = new ListViewItem(row);
                lvi.Tag = car;
                listView1.Items.Add(lvi);
            }
        }
    }
    
}
