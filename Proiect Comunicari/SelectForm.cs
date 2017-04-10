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
            listBox1.Items.Add((listBox1.Items.Count + 1).ToString() + " Proiect");
        }

        private void openOp_Click(object sender, EventArgs e)
        {
            ShadowForm.OpenOp(listBox1.SelectedIndex);
        }

        private void openConturi_Click(object sender, EventArgs e)
        {
            ShadowForm.OpenConturi(listBox1.SelectedIndex);
        }
    }
}
