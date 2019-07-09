using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace Extensie
{
    public class WinForm : Form
    {
        static int heigh = 100;
        static int width = 300;
        static int pas = 0;
        private Label labelAfisare;
        public WinForm()
        {
            this.Size = new System.Drawing.Size(300, 900);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new System.Drawing.Point(100, 100);
            this.Text = "Agenda";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.WindowState = FormWindowState.Normal;
        }
        public void AdLabel(string text)
        {
            
            labelAfisare = new Label();
            labelAfisare.Width = width;
            labelAfisare.Height = heigh;
            this.Controls.Add(labelAfisare);
            labelAfisare.Text = text;
            labelAfisare.BackColor = System.Drawing.Color.MintCream;
            labelAfisare.ForeColor = Color.Blue;
            labelAfisare.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            labelAfisare.Location = new System.Drawing.Point(0, pas);
            pas += 110;
        }
    }
}
