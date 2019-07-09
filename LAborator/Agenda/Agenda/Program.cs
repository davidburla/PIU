using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Extensie;
using System.Windows.Forms;
using System.Drawing;

namespace Agenda
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {

            List<Persoana> Agenda = new List<Persoana>();

            //Console.Out.WriteLine("Aplicatie agenda");
            Persoana p1 = new Persoana();
            Persoana p2 = new Persoana("Popescu", "Ion", "pop_ion@gmail.com", "0745675342", "18/10/1998", 2);
            Persoana p5 = new Persoana("Popescu", "Ion", "pop_ion@gmail.com", "0745675342", "18/10/1998", 2);
           
            Persoana p3 = new Persoana("Ionescu Vasile iion_vasile@yahoo.com 0767654343 12/04/1987 3");
            Persoana p4 = new Persoana("Popescu", "Ion", "pop_ion@gmail.com", "0745675342", "18/10/1998", 2,0);
            Agenda.Add(p1);
            Agenda.Add(p2);
            Agenda.Add(p3);
            Agenda.Add(p4);
            WinForm form1 = new WinForm();
            for (int i = 0; i< Agenda.Count; i++)
            {
                form1.Show();
                form1.AdLabel(Agenda[i].ConversieLaSir());
            }


            int heigh = 100;
            int width = 300;
            int pas = 0;
            form1.Show();
            Label labelAfisare;
            
            labelAfisare = new Label();
            labelAfisare.Width = width;
            labelAfisare.Height = heigh;
            form1.Controls.Add(labelAfisare);

            pas += 110*5;

            labelAfisare.Text = Agenda[1].ConversieLaSir();
            labelAfisare.BackColor = System.Drawing.Color.Aquamarine;
            labelAfisare.ForeColor = Color.Red;
            labelAfisare.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            labelAfisare.Location = new System.Drawing.Point(0, pas);
      
            Agenda[0].Nume = "Burla";
            Agenda[0].Prenume = "David";
            form1.AdLabel(Agenda[0].ConversieLaSir());
            AppForm1 form2 = new AppForm1();
            form2.Show();
            Application.Run();
        }
    }
    public class AppForm1 : Form
    {
        private Label lblNume;
        private TextBox txtNume;

        private Label lblPrenume;
        private TextBox txtPrenume;

        private Label lblnrTelefon;
        private TextBox txtnrTelefon;

        private Label lblEmail;
        private TextBox txtEmail;

        private Label lblGrup;
        private TextBox txtGrup;

        private Label Info;


        private Button btnAdauga;
        private const int LATIME_CONTROL = 120;
        private const int DIMENSIUNE_PAS_Y = 30;
        private const int DIMENSIUNE_PAS_X = 150;
        //extindere
        

        public AppForm1()
        {
            //setare proprietati
            this.Size = new System.Drawing.Size(600, 350);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new System.Drawing.Point(100, 100);
            this.Text = "Agenda";

            //adaugare control de tip Label pentru 'Lungime';
            lblNume = new Label();
            lblNume.Width = LATIME_CONTROL;
            lblNume.Text = "Nume:";
            this.Controls.Add(lblNume);

            //adaugare control de tip TextBox pentru 'Lungime';
            txtNume = new TextBox();
            txtNume.Width = LATIME_CONTROL;
            txtNume.Left = DIMENSIUNE_PAS_X;
            this.Controls.Add(txtNume);


            //adaugare control de tip Label pentru 'Latime';
            lblPrenume = new Label();
            lblPrenume.Width = LATIME_CONTROL;
            lblPrenume.Text = "Prenume:";
            lblPrenume.Top = DIMENSIUNE_PAS_Y;
            this.Controls.Add(lblPrenume);

            //adaugare control de tip TextBox pentru 'Latime'
            txtPrenume = new TextBox();
            txtPrenume.Width = LATIME_CONTROL;
            txtPrenume.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X, DIMENSIUNE_PAS_Y);
            this.Controls.Add(txtPrenume);

            lblnrTelefon = new Label();
            lblnrTelefon.Width = LATIME_CONTROL;
            lblnrTelefon.Text = "Telefon:";
            lblnrTelefon.Top = 2*DIMENSIUNE_PAS_Y;
            this.Controls.Add(lblnrTelefon);

            //adaugare control de tip TextBox pentru 'Latime'
            txtnrTelefon = new TextBox();
            txtnrTelefon.Width = LATIME_CONTROL;
            txtnrTelefon.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X, 2*DIMENSIUNE_PAS_Y);
            this.Controls.Add(txtnrTelefon);

            lblEmail = new Label();
            lblEmail.Width = LATIME_CONTROL;
            lblEmail.Text = "Email:";
            lblEmail.Top = 3 * DIMENSIUNE_PAS_Y;
            this.Controls.Add(lblEmail);

            //adaugare control de tip TextBox pentru 'Latime'
            txtEmail = new TextBox();
            txtEmail.Width = LATIME_CONTROL;
            txtEmail.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X, 3 * DIMENSIUNE_PAS_Y);
            this.Controls.Add(txtEmail);

            lblGrup = new Label();
            lblGrup.Width = LATIME_CONTROL;
            lblGrup.Text = "Grup:";
            lblGrup.Top = 4 * DIMENSIUNE_PAS_Y;
            this.Controls.Add(lblGrup);

            //adaugare control de tip TextBox pentru 'Latime'
            txtGrup = new TextBox();
            txtGrup.Width = LATIME_CONTROL;
            txtGrup.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X, 4 * DIMENSIUNE_PAS_Y);
            this.Controls.Add(txtGrup);

            //adaugare control de tip Button
            btnAdauga = new Button();
            btnAdauga.Width = LATIME_CONTROL;
            btnAdauga.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X, 5 * DIMENSIUNE_PAS_Y);
            btnAdauga.Text = "Salveaza";
            //"Click" este un *event* in clasa Button si poate avea atasat unul sau mai multe handlere de eveniment (adrese de functii)
            //acesta este motivul utilizarii operatorului +=
            btnAdauga.Click += OnButtonClicked; //numele metodei este utilizat fara () pentru a indica ca se transmite adresa functiei si nu este un apel de functie
            this.Controls.Add(btnAdauga);

            Info = new Label();
            Info.Width = LATIME_CONTROL;
            Info.Text = "Informatii:";
            Info.Top = 6 * DIMENSIUNE_PAS_Y;
            Info.BackColor = Color.AliceBlue;
            Info.Height = 100;
            Info.Width = 200;
            this.Controls.Add(Info);

            //adaugare handlere pentru evenimentele SizeChanged si FormClosed ale formei
            this.SizeChanged += OnFormSizeChanged;
            this.FormClosed += OnFormClosed;

            

        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            //obiectul *sender* este butonul btnCalculeaza
            //*e* reprezinta o lista de valori care se transmit la invocarea evenimentului Click al clasei Button catre subscriber-ul curent care este forma AppForm1 
            string _nume=txtNume.Text, _prenume=txtPrenume.Text, _nrTel=txtnrTelefon.Text, _Email=txtEmail.Text;
            int stat;
            if(Verificare())
            {
                Int32.TryParse(txtGrup.Text, out stat);
                if(stat>=0 && stat<=4)
                {
                    Persoana px = new Persoana(_nume, _prenume, _Email, _nrTel, "12/03/1988", stat);
                    Info.Text = px.ConversieLaSir();
                }
                else
                {
                    Persoana px = new Persoana(_nume, _prenume, _Email, _nrTel, "12/03/1988", 4);
                    Info.Text = px.ConversieLaSir();

                }
            }
            else
            {
                Info.Text = "Informatii gresite";
            }
            

        }
        public bool Verificare()
        {
            if(txtNume.Text.Length == 0 || txtPrenume.Text.Length == 0 || txtnrTelefon.Text.Length == 0)
            {
                return false;
            }
            if(txtNume.Text.Any(c=>char.IsDigit(c)) || txtPrenume.Text.Any(c => char.IsDigit(c)))
            {
                return false;
            }
            if(!double.TryParse(txtnrTelefon.Text, out double nr))
            {
                 return false;
            }
            return true;
        }
        
        private void OnFormSizeChanged(object sender, EventArgs e)
        {
            //obiectul *sender* este AppForm1
            //*e* reprezinta o lista de valori care se transmit la invocarea evenimentului SizeChanged al clasei AppForm1 catre subscriber-ul curent care este tot forma AppForm1 
            this.Text = "Latime=" + this.Width + " Inaltime= " + this.Height;
        }

        private void OnFormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
