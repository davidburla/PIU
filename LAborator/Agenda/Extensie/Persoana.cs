using System;


namespace Extensie
{

    [Flags]
    enum Grup
        {
            familie=0,
            prieteni,
            serviciu,
            echipa,
            nedefinit
        }
    public class Persoana
    {
        string nume;
        string prenume;
        public string Nume
        {
            get => nume;
            set => nume = value;
        }
        public string Prenume
        {
            get => prenume;
            set => prenume = value;
        }
        public string Email { get; set; }
        public string NR_telefon { get; set; }
         
        public int Id_Pers { get; set; }

        public static int nextID;
        DateTime Data_Nastere;
        Grup Status;
        public Persoana()
        {
            Nume = Prenume = Email = NR_telefon = string.Empty;
            Id_Pers = ++nextID;
            Data_Nastere = new DateTime();
            Status = Grup.nedefinit;
        }
        public Persoana(string _nume, string _prenume, string _email, string _nrTelefon, string _datan, int _status)
        {
            Nume = _nume;
            Prenume = _prenume;
            Email = _email;
            NR_telefon = _nrTelefon;
            Id_Pers = ++nextID;
            if (DateTime.TryParse(_datan, out Data_Nastere)){ }

            Enum.TryParse<Grup>(_status.ToString(), out Status);
        }
        public Persoana(string _nume, string _prenume, string _email, string _nrTelefon, string _datan, int _status, int _status2)
        {
            Nume = _nume;
            Prenume = _prenume;
            Email = _email;
            NR_telefon = _nrTelefon;
            Id_Pers = ++nextID;
            if (DateTime.TryParse(_datan, out Data_Nastere)) { }

            Enum.TryParse<Grup>(_status.ToString(), out Status);
            Grup status_opt;
            Enum.TryParse<Grup>(_status2.ToString(), out status_opt);
            Status = Status & status_opt;
        }

        public Persoana(string _info)
        {
            string[] info = _info.Split(' ');
            Nume = info[0];
            Prenume = info[1];
            Email = info[2];
            NR_telefon = info[3];
            Id_Pers = ++nextID;
            if (DateTime.TryParse(info[4], out Data_Nastere)) { }

            Enum.TryParse<Grup>(info[5].ToString(), out Status);
        }
        public string ConversieLaSir()
        {
            //string sNume = "Nu exista ( nu e valid)";
            string s = string.Format("{0} {1} are: \nnr. telefon: {2}, \nadresa de email: {3} \nnascut in data de: {4}; \napartine grupului : {5}.\n", (Nume ?? "NECUNOSCUT"), (Prenume ?? "NECUNOSCUT"), (NR_telefon ?? "NECUNOSCUT"), (Email ?? "NECUNOSCUT"), Data_Nastere.ToString("dd/MM/yyyy"), Status);
            return s;
        }
        public int Compare(Persoana p)
        {
            if (this.NR_telefon == p.NR_telefon)
            {
                return 0;
            }  
            else if(this.Email == p.Email)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}
