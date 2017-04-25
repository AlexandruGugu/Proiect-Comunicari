using System;
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
            InchidereConturi();
        }

        private void DeschideCont(Cont cont, bool operatie = false)
        {
            titleFormat.setBorderColor(libxl.Color.COLOR_GRAY50);
            titleFormat.borderBottom = libxl.BorderStyle.BORDERSTYLE_MEDIUM;
            titleFormat.alignV = libxl.AlignV.ALIGNV_CENTER;

            debitFormat.setBorderColor(libxl.Color.COLOR_GRAY50);
            debitFormat.borderRight = libxl.BorderStyle.BORDERSTYLE_MEDIUM;

            creditFormat.setBorderColor(libxl.Color.COLOR_GRAY50);
            creditFormat.borderLeft = libxl.BorderStyle.BORDERSTYLE_MEDIUM;

            int poz = (conturiDeschise.Count + 1) * 5;
            string titlu = "D";
            for(int i = 0; i < (60 - cont.nume.Length) / 2; i++)
            {
                titlu += " ";
            }

            titlu += cont.nume;

            for (int i = 0; i < (60 - cont.nume.Length) / 2; i++)
            {
                titlu += " ";
            }
            titlu += "C";
            conturi.writeStr(2, poz, titlu, titleFormat);
           
            conturi.setMerge(2, 2, poz, poz + 3);
            double val = cont.valoare;

            if (operatie)
            {
                val = 0;
            }
            if (cont.activ)
            {
                conturi.writeStr(3, poz, "SI:");
                conturi.writeNum(3, poz + 1, val, debitFormat);
            }
            else
            {
                conturi.writeStr(3, poz + 2, "SI:", creditFormat);
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

        private void InchidereConturi()
        {
            bool finalDebit;
            int col;
            int rowD, rowC, row;
            double rd, rc, tsd, tsc, sf;
            //debitFormat.borderTop = libxl.BorderStyle.BORDERSTYLE_MEDIUM;
            //creditFormat.borderTop = libxl.BorderStyle.BORDERSTYLE_MEDIUM;
            //debitFormat.borderBottom = libxl.BorderStyle.BORDERSTYLE_MEDIUM;
            //creditFormat.borderBottom = libxl.BorderStyle.BORDERSTYLE_MEDIUM;
            foreach (double id in conturiDeschise.Keys )
            {
                rd = 0;
                rc = 0;
                tsd = 0;
                tsc = 0;
                rowD = 3;
                rowC = 3;
                sf = 0;
                col = conturiDeschise[id] * 5;
                string str = conturi.readStr(rowD, col);
                if(conturi.readStr(rowD, col) == "SI:")
                {
                    tsd += conturi.readNum(rowD, col + 1);
                    finalDebit = true;
                    rowD++;
                }
                else
                {
                    tsc += conturi.readNum(rowC, col + 3);
                    finalDebit = false;
                    rowC++;
                }

                for (; conturi.cellType(rowD, col + 1) != CellType.CELLTYPE_EMPTY; rowD++)
                {
                    rd += conturi.readNum(rowD, col + 1);               
                }



                for (; conturi.cellType(rowC, col + 3) != CellType.CELLTYPE_EMPTY; rowC++)
                {
                    rc += conturi.readNum(rowC, col + 3);
                }

                row = rowD > rowC ? rowD : rowC;

                tsc += rc;
                conturi.writeStr(row, col + 2, "RC:", creditFormat);
                conturi.writeNum(row, col + 3, rc, creditFormat);
                conturi.writeStr(row + 1, col + 2, "TSC:", creditFormat);
                conturi.writeNum(row + 1, col + 3, tsc, creditFormat);

                tsd += rd;
                conturi.writeStr(row, col, "RD:", debitFormat);
                conturi.writeNum(row, col + 1, rd, debitFormat);
                conturi.writeStr(row + 1, col, "TSD:", debitFormat);
                conturi.writeNum(row + 1, col + 1, tsd, debitFormat);

                if (tsd > tsc)
                {
                    finalDebit = true;
                    sf = tsd - tsc;
                }
                else if (tsd < tsc)
                {
                    finalDebit = false;
                    sf = tsc - tsd;
                }

                if (finalDebit)
                {
                    conturi.writeStr(row + 2, col, "SFD:", debitFormat);
                    conturi.writeNum(row + 2, col + 1, sf, debitFormat);
                }
                else
                {
                    conturi.writeStr(row + 2, col + 2, "SFC:", creditFormat);
                    conturi.writeNum(row + 2, col + 3, sf, creditFormat);
                }
            }
        }

        private void print_Click(object sender, EventArgs e)
        {
            PrintConturi();
            book.save("test.xlsx");
        }
    }
}
