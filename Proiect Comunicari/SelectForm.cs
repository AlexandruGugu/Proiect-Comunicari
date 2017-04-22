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
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
            foreach(Proiect prj in ShadowForm.proiecte)
            {
                listBox1.Items.Add((listBox1.Items.Count + 1).ToString() + " Proiect");
            }
        }

        private void SelectForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ShadowForm.selectForm = null;
            ShadowForm.CheckActiveForms();
        }

        private void addPrj_Click(object sender, EventArgs e)
        {
            ShadowForm.proiecte.Add(new Proiect());
            ShadowForm.proiecte[ShadowForm.proiecte.Count - 1].nume = "Proiect nou " + listBox1.Items.Count;
            listBox1.Items.Add((listBox1.Items.Count + 1).ToString() + " Proiect");
        }

        private void openOp_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex < 0)
            {
                return;
            }
            ShadowForm.OpenOp(listBox1.SelectedIndex);
        }

        private void openConturi_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0)
            {
                return;
            }
            ShadowForm.OpenConturi(listBox1.SelectedIndex);
        }

        private void delPrj_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(index);
            OpForm i;
            ConturiForm j;
            if ((i = ShadowForm.opForms.Find(p => ReferenceEquals(p.proiect, ShadowForm.proiecte.ElementAt(index)))) != null)
            {
                MessageBox.Show("Fereastra este deja deschisa");
                i.Close();
                ShadowForm.opForms.Remove(i);
            }
            if ((j = ShadowForm.contForms.Find(p => ReferenceEquals(p.proiect, ShadowForm.proiecte.ElementAt(index)))) != null)
            {
                MessageBox.Show("Fereastra este deja deschisa");
                j.Close();
                ShadowForm.contForms.Remove(j);
            }
            ShadowForm.proiecte.RemoveAt(index);
        }
    }
}
