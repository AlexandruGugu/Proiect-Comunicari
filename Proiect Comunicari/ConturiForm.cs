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
        }

        private void ConturiForm_FormClosed(object sender, FormClosedEventArgs e)
        {
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
    }
}
