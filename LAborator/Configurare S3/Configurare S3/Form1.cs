using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Configurare_S3
{
    public partial class Form1 : Form
    {
        List<Configurare> Config = new List<Configurare>();
        string fig= string.Empty;
        public Form1()
        {
            InitializeComponent();
            string[] gros = new string[] { "1", "5", "7", "8" };
            comboBox1.Text = "Selecteaza...";
            foreach(var g in gros)
            {
                comboBox1.Items.Add(g);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void figuraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Black;
            label5.Text = "Warning";
            if (String.IsNullOrEmpty(textBox1.Text)||textBox1.Text.Length<10)
            {
               label5.Text += "\nDenumire invalida";
               label5.ForeColor = Color.Red;
            }
            if(radioButton1.Checked==false && radioButton2.Checked == false && radioButton3.Checked == false && radioButton4.Checked == false)
            {
                label5.Text += "\nCuloare neselectata";
            }
            if(comboBox1.Text=="Selecteaza...")
            {
                label5.Text += "\nGrosime invalida";
            }
            if(fig==String.Empty)
            {
                label5.Text += "\nForma neselectata";
            }
            if(label5.Text=="Warning")
            {
                Color color=Color.Black;
                if (radioButton1.Checked == true)
                    color = Color.Blue;
                if (radioButton2.Checked == true)
                    color = Color.Black;
                if (radioButton3.Checked == true)
                    color = Color.Red;
                if (radioButton3.Checked == true)
                    color = Color.Green;
                Configurare c = new Configurare(textBox1.Text, color, Convert.ToInt32(comboBox1.Text), fig);
                Config.Add(c);
                treeView1.Nodes.Add(c.ToString());
            }
            reset();
        }

        private void patratToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fig = "patrat";
        }

        private void cercToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fig = "cerc";
        }

        private void triunghiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fig = "triunghi";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            foreach(Configurare var in Config)
            {
                comboBox2.Items.Add(var);
            }
            reset();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int index = comboBox2.SelectedIndex;
            label5.Text += index.ToString();
            Config.RemoveAt(index);
            comboBox2.Items.Clear();
            foreach (Configurare var in Config)
            {
                comboBox2.Items.Add(var);
            }
            reset();
            label5.Text += dateTimePicker1.Text;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
        public void reset()
        {
            string fig = string.Empty;
            textBox1.Text = String.Empty;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            comboBox1.Text = "Selecteaza...";
            comboBox2.Text = String.Empty;
        }
    }
}
