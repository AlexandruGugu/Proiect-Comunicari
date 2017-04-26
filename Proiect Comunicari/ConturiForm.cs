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
    public partial class ConturiForm : Form
    {
        public Proiect proiect;

        public ConturiForm(Proiect prj)
        {
            InitializeComponent();
            proiect = prj;
            this.Show();
            InitConturi();
            if(proiect.Active.Count > 0)
            {
                addActiv.Hide();
                addPasiv.Hide();
                deleteActiv.Hide();
                deletePasiv.Hide();
                comboBox1.Hide();
                activID.Hide();
                activValoare.Hide();
                pasivID.Hide();
                pasivValoare.Hide();
                DisplayConturi(proiect.ActiveCurente, proiect.PasiveCurente);
            }
            else
            {
                DisplayConturi(proiect.Active, proiect.Pasive);
            }
            
        }

        private void AddCont(double valoare, double id, bool activ)
        {
            if (activ)
            {
                proiect.Active.Add(new Cont(id, valoare, activ, ShadowForm.conturiDic[id]));
            }
            else
            {
                proiect.Pasive.Add(new Cont(id, valoare, activ, ShadowForm.conturiDic[id]));
            }
            DisplayConturi(proiect.Active, proiect.Pasive);
        }

        private void DisplayConturi(List<Cont> conturiActive, List<Cont> conturiPasive)
        {
            listaActive.Items.Clear();
            listaPasive.Items.Clear();
            foreach (Cont cont in conturiActive)
            {
                listaActive.Items.Add(cont.id + " " + cont.nume + ": " + cont.valoare);
            }
            foreach (Cont cont in conturiPasive)
            {
                listaPasive.Items.Add(cont.id + " " + cont.nume + ": " + cont.valoare);
            }
        }

        private void InitConturi()
        {
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(Application.StartupPath + "\\Data\\conturi.txt");
            int i, j;
            while ((line = file.ReadLine()) != null)
            {
                comboBox1.Items.Add(line);
            }
        }

        private void ConturiForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(proiect.ActiveCurente.Count == 0)
            {
                foreach(Cont cont in proiect.Active)
                {
                    proiect.ActiveCurente.Add(new Cont(cont));
                }

                foreach(Cont cont in proiect.Pasive)
                {
                    proiect.PasiveCurente.Add(new Cont(cont));
                }
            }
            ShadowForm.contForms.Remove(this);
            ShadowForm.CheckActiveForms();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            Cont cont = ShadowForm.conturiLst[index];
            if (comboBox1.SelectedItem.ToString().Contains("/"))
            {
                DialogResult res = MessageBox.Show("Cont de activ?", "Cont bifunctional", MessageBoxButtons.YesNoCancel);
                if (res == DialogResult.Yes)
                {
                    activID.Text = cont.id.ToString();
                }
                else if (res == DialogResult.No)
                {
                    pasivID.Text = cont.id.ToString();
                }
            }
            else
            {

                if (cont.activ)
                {
                    activID.Text = cont.id.ToString();
                }
                else
                {
                    pasivID.Text = cont.id.ToString();
                }
            }
        }

        private void addActiv_Click(object sender, EventArgs e)
        {
            double id, x;
            if (double.TryParse(activValoare.Text, out x) && double.TryParse(activID.Text, out id))
            {
                if (!ShadowForm.conturiDic.Keys.Contains(id))
                {
                    MessageBox.Show("Contul introdus nu exista");
                    return;
                }
                foreach (Cont cont in proiect.Active)
                {
                    if (cont.id == id)
                    {
                        MessageBox.Show("Contul exista deja");
                        return;
                    }
                }
                AddCont(x, id, true);
                activValoare.Clear();
                activID.Clear();
            }           
        }




        private void addPasiv_Click(object sender, EventArgs e)
        {
            double id, x;
            if (double.TryParse(pasivValoare.Text, out x) && double.TryParse(pasivID.Text, out id))
            {
                if (!ShadowForm.conturiDic.Keys.Contains(id))
                {
                    MessageBox.Show("Contul introdus nu exista");
                    return;
                }
                foreach (Cont cont in proiect.Pasive)
                {
                    if (cont.id == id)
                    {
                        MessageBox.Show("Contul exista deja");
                        return;
                    }
                }
                AddCont(x, id, false);
                pasivValoare.Clear();
                pasivID.Clear();
            }
        }

        private void deleteActiv_Click(object sender, EventArgs e)
        {
            int index = listaActive.SelectedIndex;
            if(index < 0)
            {
                return;
            }
            proiect.Active.RemoveAt(index);
            listaActive.Items.RemoveAt(index);
        }

        private void deletePasiv_Click(object sender, EventArgs e)
        {
            int index = listaPasive.SelectedIndex;
            if (index < 0)
            {
                return;
            }
            proiect.Pasive.RemoveAt(index);
            listaPasive.Items.RemoveAt(index);
        }
    }
}
