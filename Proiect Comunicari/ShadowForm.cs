using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_Comunicari
{
    public partial class ShadowForm : Form
    {
        static public List<OpForm> opForms = new List<OpForm>();
        static public List<ConturiForm> contForms = new List<ConturiForm>();
        static public SelectForm selectForm = null;
        static public LoginForm loginForm = null;


        static public List<Proiect> proiecte = new List<Proiect>();
        //private LoginInfo loginInfo;

        public ShadowForm()
        {            
            InitializeComponent();
            loginForm = new LoginForm();
            loginForm.Show();
            LoadFiles();
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
            selectForm = new SelectForm();
            selectForm.Show();
            loginForm.Close();
        }

        static public void OpenSelect()
        {
            if(selectForm != null)
            {
                selectForm.Focus();
            }
            else
            {
                selectForm = new SelectForm();
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
            if( opForms.Count == 0 && contForms.Count == 0 && selectForm == null && loginForm == null)
            {
                SaveFiles();
                Application.Exit();
            }
        }
    }
}
