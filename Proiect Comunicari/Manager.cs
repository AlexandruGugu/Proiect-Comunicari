using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_Comunicari
{
    class Manager
    {
        static public List<OpForm> opForms = new List<OpForm>();
        static public List<ConturiForm> contForms = new List<ConturiForm>();
        static public MenuForm menuForm = null;
        static public LoginForm loginForm = null;

        static public Dictionary<double, string> conturiDic = new Dictionary<double, string>();
        static public List<Cont> conturiLst = new List<Cont>();
        static public List<Proiect> proiecte = new List<Proiect>();
        //private LoginInfo loginInfo;

        public Manager()
        {           
            LoadConturi();
            LoadFiles();
            loginForm = new LoginForm();
            loginForm.Show();           
        }

        private void LoadFiles()
        {
            foreach (string file in System.IO.Directory.EnumerateFiles(Application.StartupPath + "\\Saved"))
            {
                proiecte.Add(BinarySerialization.ReadFromBinaryFile<Proiect>(file));
            }
        }

        static public void Authenticated()
        {
            menuForm = new MenuForm();
            menuForm.Show();
            loginForm.Close();
        }

        static public void OpenSelect()
        {
            if (menuForm != null)
            {
                menuForm.Focus();
            }
            else
            {
                menuForm = new MenuForm();
            }
        }

        static public void OpenOp(int index)
        {
            if (opForms.Exists(p => ReferenceEquals(p.proiect, proiecte.ElementAt(index))))
            {
                MessageBox.Show("Fereastra este deja deschisa");
            }
            else
            {
                opForms.Add(new OpForm(proiecte.ElementAt(index)));
                opForms[opForms.Count - 1].Text = "Operatii " + proiecte.ElementAt(index).nume;
            }

        }

        static public void OpenConturi(int index)
        {
            if (contForms.Exists(p => ReferenceEquals(p.proiect, proiecte.ElementAt(index))))
            {
                MessageBox.Show("Fereastra este deja deschisa");
            }
            else
            {
                contForms.Add(new ConturiForm(proiecte.ElementAt(index)));
                contForms[contForms.Count - 1].Text = "Conturi " + proiecte.ElementAt(index).nume;
            }
        }

        static public void SaveFiles()
        {
            string file = Application.StartupPath + "\\Saved";
            foreach (Proiect prj in proiecte)
            {
                BinarySerialization.WriteToBinaryFile<Proiect>(file + "\\" + prj.nume + ".bin", prj);
            }

        }

        static public void CheckActiveForms()
        {
            if (opForms.Count == 0 && contForms.Count == 0 && menuForm == null && loginForm == null)
            {
                SaveFiles();
                Application.Exit();
            }
        }

        private void LoadConturi()
        {
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(Application.StartupPath + "\\Data\\conturi.txt");
            int i, j;
            while ((line = file.ReadLine()) != null)
            {
                i = line.IndexOf('.');
                j = line.IndexOf('(');
                double id = Convert.ToDouble(line.Substring(0, i + 1));
                string nume = line.Substring(i + 2, j - i - 3);
                bool activ = true;
                if (line[j + 1] == 'P')
                {
                    activ = false;
                }
                conturiDic.Add(id, nume);
                conturiLst.Add(new Cont(id, 0.0, activ, nume));
            }
        }
    }
    [Serializable]
    public class Proiect
    {
        public string nume;
        public List<Operatie> operatii = new List<Operatie>();
        public List<Operatie> presets = new List<Operatie>();
        public List<Cont> Active = new List<Cont>();
        public List<Cont> Pasive = new List<Cont>();
        public List<Cont> ActiveCurente = new List<Cont>();
        public List<Cont> PasiveCurente = new List<Cont>();

        public Proiect()
        {


        }
    }

    [Serializable]
    public class Operatie
    {
        public string nume { get; set; }
        public string descriere { get; set; }
        public List<Cont> debit { get; set; }
        public List<Cont> credit { get; set; }

        public Operatie(string Nume = "", string Descriere = "", List<Cont> Debit = null, List<Cont> Credit = null)
        {
            descriere = Descriere;
            nume = Nume;
            if (Debit == null)
            {
                debit = new List<Cont>();
            }
            else
            {
                foreach (Cont cont in Debit)
                {
                    debit.Add(new Cont(cont));
                }
            }
            if (Credit == null)
            {
                credit = new List<Cont>();
            }
            else
            {
                foreach (Cont cont in Credit)
                {
                    credit.Add(new Cont(cont));
                }
            }

        }
        public Operatie(Operatie op)
        {
            debit = new List<Cont>();
            credit = new List<Cont>();
            nume = op.nume;
            descriere = op.descriere;
            foreach (Cont cont in op.debit)
            {
                debit.Add(new Cont(cont));
            }
            foreach (Cont cont in op.credit)
            {
                credit.Add(new Cont(cont));
            }
        }


    }

    [Serializable]
    public class Cont
    {
        public string nume { get; set; }
        public double id { get; set; }
        public bool activ { get; set; }
        public double valoare { get; set; }

        public Cont(double ID, double VALOARE, bool ACTIV, string NUME = "")
        {
            id = ID;
            valoare = VALOARE;
            activ = ACTIV;
            nume = NUME;
        }

        public Cont(Cont cont)
        {
            nume = cont.nume;
            id = cont.id;
            activ = cont.activ;
            valoare = cont.valoare;
        }
    }
}
