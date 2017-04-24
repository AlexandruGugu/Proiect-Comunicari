﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libxl;
namespace Proiect_Comunicari
{
    public partial class SelectForm : Form
    {
        private Dictionary<double, int> conturiDeschise = new Dictionary<double, int>();
        public static XmlBook book = new XmlBook();
        public static Sheet conturi = book.addSheet("Conturi");
        public static Format titleFormat = book.addFormat();
        public static Format debitFormat = book.addFormat();
        public static Format creditFormat = book.addFormat();

        public SelectForm()
        {
            InitializeComponent();
            foreach(Proiect prj in ShadowForm.proiecte)
            {
                listBox1.Items.Add((listBox1.Items.Count + 1).ToString() + " Proiect");
            }
            conturi.displayGridlines = false;
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

        public void PrintConturi()
        {
            Proiect proiect = ShadowForm.proiecte.ElementAt(listBox1.SelectedIndex);           
            foreach(Cont cont in proiect.Active)
            {               
                DeschideCont(cont);
            }
            foreach(Cont cont in proiect.Pasive)
            {
                DeschideCont(cont);
            }
            int i = 0;
            foreach(Operatie op in proiect.operatii)
            {
                i++;
                ScrieOperatieT(op, i);             
            }
        }

        private void DeschideCont(Cont cont, bool operatie = false)
        {
            //titleFormat.setBorder(libxl.BorderStyle.BORDERSTYLE_MEDIUM);
            titleFormat.setBorderColor(libxl.Color.COLOR_GRAY50);
            titleFormat.borderBottom = libxl.BorderStyle.BORDERSTYLE_MEDIUM;
            titleFormat.alignV = libxl.AlignV.ALIGNV_CENTER;

            debitFormat.setBorderColor(libxl.Color.COLOR_GRAY50);
            debitFormat.borderRight = libxl.BorderStyle.BORDERSTYLE_MEDIUM;

            creditFormat.setBorderColor(libxl.Color.COLOR_GRAY50);
            creditFormat.borderLeft = libxl.BorderStyle.BORDERSTYLE_MEDIUM;

            int poz = (conturiDeschise.Count + 1) * 5;
            string titlu = "D";
            for(int i = 0; i < (20 - cont.nume.Length) / 2; i++)
            {
                titlu += " ";
            }

            titlu += cont.nume;

            for (int i = 0; i < (20 - cont.nume.Length) / 2; i++)
            {
                titlu += " ";
            }
            titlu += "C";
            conturi.writeStr(2, poz, titlu, titleFormat);
           
            conturi.setMerge(2, 2, poz, poz + 4);
            double val = cont.valoare;

            if (operatie)
            {
                val = 0;
            }
            if (cont.activ)
            {
                conturi.writeStr(3, poz, "TSD:", debitFormat);
                conturi.writeNum(3, poz + 1, val);
            }
            else
            {
                conturi.writeStr(3, poz + 2, "TSC:", creditFormat);
                conturi.writeNum(3, poz + 3, val);
            }
            conturiDeschise.Add(cont.id, conturiDeschise.Count + 1);
        }

        private void ScrieOperatieT(Operatie op, int index)
        {
            foreach (Cont cont in op.credit)
            {
                if (!conturiDeschise.ContainsKey(cont.id))
                {
                    DeschideCont(cont, true);
                }
                ScrieModificare(cont, index, false);
                
            }

            foreach(Cont cont in op.debit)
            {               
                if(!conturiDeschise.ContainsKey(cont.id))
                {
                    DeschideCont(cont, true);
                }
                ScrieModificare(cont, index, true);
            }
        }

        private void ScrieModificare(Cont cont, int index, bool debit)
        {
            int col = conturiDeschise[cont.id] * 5;
            int row = 2;
            if(!debit)
            {
                col += 2;
            }

            for (; conturi.cellType(row, col) != CellType.CELLTYPE_EMPTY; row++) ;
            if(debit)
            {
                conturi.writeStr(row, col, "(" + index + ")");
                conturi.writeNum(row, col + 1, cont.valoare, debitFormat);
            }
            else
            {
                conturi.writeStr(row, col, "(" + index + ")", creditFormat);
                conturi.writeNum(row, col + 1, cont.valoare);
            }
            
        }
    }
}
