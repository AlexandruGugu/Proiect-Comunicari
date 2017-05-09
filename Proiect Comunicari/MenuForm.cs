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
    public partial class MenuForm : Form
    {
        private Dictionary<double, int> conturiDeschise = new Dictionary<double, int>();
        public static XmlBook book = new XmlBook();
        public static Sheet APInitial = book.addSheet("API");
        public static Sheet conturi = book.addSheet("Conturi");
        public static Sheet APFinal = book.addSheet("APF");
        public static Format titleFormat = book.addFormat();
        public static Format debitFormat = book.addFormat();
        public static Format creditFormat = book.addFormat();
        public static Format FD1 = book.addFormat();
        public static Format FD2;
        public static Format FC1;
        public static Format FC2 = book.addFormat();
        public static Format tabel;

        public MenuForm()
        {
            InitializeComponent();
            foreach(Proiect prj in Manager.proiecte)
            {
                listBox1.Items.Add(prj.nume);
            }

            
            conturi.displayGridlines = false;
            APInitial.displayGridlines = false;
            APFinal.displayGridlines = false;

            titleFormat.setBorderColor(libxl.Color.COLOR_GRAY50);
            titleFormat.borderBottom = libxl.BorderStyle.BORDERSTYLE_MEDIUM;
            titleFormat.alignV = libxl.AlignV.ALIGNV_CENTER;
            titleFormat.alignH = libxl.AlignH.ALIGNH_MERGE;
            titleFormat.shrinkToFit = true;

            debitFormat.setBorderColor(libxl.Color.COLOR_GRAY50);
            debitFormat.borderRight = libxl.BorderStyle.BORDERSTYLE_MEDIUM;

            creditFormat.setBorderColor(libxl.Color.COLOR_GRAY50);
            creditFormat.borderLeft = libxl.BorderStyle.BORDERSTYLE_MEDIUM;

            FD2 = book.addFormat(debitFormat);
            FC1 = book.addFormat(creditFormat);

            FD1.setBorderColor(libxl.Color.COLOR_GRAY50);
            FD1.borderTop = libxl.BorderStyle.BORDERSTYLE_MEDIUM;
            FD1.borderBottom = libxl.BorderStyle.BORDERSTYLE_MEDIUM;

            FD2.borderTop = libxl.BorderStyle.BORDERSTYLE_MEDIUM; 
            FD2.borderBottom = libxl.BorderStyle.BORDERSTYLE_MEDIUM;

            FC1.setBorderColor(libxl.Color.COLOR_GRAY50);
            FC1.borderBottom = libxl.BorderStyle.BORDERSTYLE_MEDIUM;
            FC1.borderTop = libxl.BorderStyle.BORDERSTYLE_MEDIUM;

            FC2.setBorderColor(libxl.Color.COLOR_GRAY50);
            FC2.borderTop = libxl.BorderStyle.BORDERSTYLE_MEDIUM; 
            FC2.borderBottom = libxl.BorderStyle.BORDERSTYLE_MEDIUM;

            tabel = book.addFormat();
            tabel.setBorder(libxl.BorderStyle.BORDERSTYLE_MEDIUM);            
            //tabel.alignH = AlignH.ALIGNH_MERGE;

        }

        private void SelectForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Manager.menuForm = null;
            Manager.CheckActiveForms();
        }

        private void addPrj_Click(object sender, EventArgs e)
        {
            Manager.proiecte.Add(new Proiect());
            if (textBox1.Text != String.Empty)
            {
                Manager.proiecte[Manager.proiecte.Count - 1].nume = textBox1.Text;
            }
            else
            {
                Manager.proiecte[Manager.proiecte.Count - 1].nume = "Proiect nou";
            }
            listBox1.Items.Add(Manager.proiecte[Manager.proiecte.Count - 1].nume);
        }

        private void openOp_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex < 0)
            {
                return;
            }
            Manager.OpenOp(listBox1.SelectedIndex);
        }

        private void openConturi_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0)
            {
                return;
            }
            Manager.OpenConturi(listBox1.SelectedIndex);
        }

        private void delPrj_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(index);
            OpForm i;
            ConturiForm j;
            if ((i = Manager.opForms.Find(p => ReferenceEquals(p.proiect, Manager.proiecte.ElementAt(index)))) != null)
            {
                MessageBox.Show("Fereastra este deja deschisa");
                i.Close();
                Manager.opForms.Remove(i);
            }
            if ((j = Manager.contForms.Find(p => ReferenceEquals(p.proiect, Manager.proiecte.ElementAt(index)))) != null)
            {
                MessageBox.Show("Fereastra este deja deschisa");
                j.Close();
                Manager.contForms.Remove(j);
            }
            Manager.proiecte.RemoveAt(index);
        }

        public void PrintConturi()
        {
            Proiect proiect = Manager.proiecte.ElementAt(listBox1.SelectedIndex);           
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
                conturi.writeStr(row, col + 2, "RC:", FC1);
                conturi.writeNum(row, col + 3, rc, FC2);
                conturi.writeStr(row + 1, col + 2, "TSC:", FC1);
                conturi.writeNum(row + 1, col + 3, tsc, FC2);

                tsd += rd;
                conturi.writeStr(row, col, "RD:", FD1);
                conturi.writeNum(row, col + 1, rd, FD2);
                conturi.writeStr(row + 1, col, "TSD:", FD1);
                conturi.writeNum(row + 1, col + 1, tsd, FD2);

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
                    conturi.writeStr(row + 2, col, "SFD:", FD1);
                    conturi.writeNum(row + 2, col + 1, sf, FD2);
                }
                else
                {
                    conturi.writeStr(row + 2, col + 2, "SFC:", FC1);
                    conturi.writeNum(row + 2, col + 3, sf, FC2);
                }
            }
        }

        private void PrintAP(List<Cont> active, List<Cont> pasive, Sheet sheet)
        {
            sheet.writeStr(2, 2, "ACTIVE");
            sheet.writeStr(2, 3, "PASIVE");
            int row = 3;
            int col = 2;
            
            foreach(Cont cont in active)
            {
                if (cont.valoare != 0)
                {
                    sheet.writeStr(row++, col, cont.id.ToString() + cont.nume + ": " + cont.valoare.ToString(), tabel);
                }
            }
            sheet.setCol(col, -1);
            row = 3;
            col = 3;
            foreach(Cont cont in pasive)
            {
                if (cont.valoare != 0)
                {
                    sheet.writeStr(row++, col, cont.id.ToString() + cont.nume + ": " + cont.valoare.ToString(), tabel);
                }
            }
            sheet.setCol(col, -1);

        }

        private void print_Click(object sender, EventArgs e)
        {
            if(numeFisier.Text == string.Empty)
            {
                MessageBox.Show("Introduceti un nume");
                numeFisier.Focus();
            }

            Proiect proiect = Manager.proiecte.ElementAt(listBox1.SelectedIndex);
            PrintAP(proiect.Active, proiect.Pasive, APInitial);
            PrintAP(proiect.ActiveCurente, proiect.PasiveCurente, APFinal);
            PrintConturi();            
            book.save(numeFisier.Text + ".xlsx");
        }

        private void InchidereCheltuieli()
        {
            Proiect proiect = Manager.proiecte.ElementAt(listBox1.SelectedIndex);
            Operatie op = new Operatie();
            double x = 0;
            foreach (Cont cont in proiect.ActiveCurente)
            {
                if(cont.id.ToString()[0] == '6' && cont.valoare != 0)
                {
                    op.credit.Add(new Cont(cont));                    
                    x += cont.valoare;
                    cont.valoare = 0;
                }
            }
            if(x == 0)
            {
                return;
            }
            op.nume = "Inchidere conturi de cheltuieli";
            op.debit.Add(new Cont(121, x, true));
            proiect.operatii.Add(op);
        }

        private void InchidereVenituri()
        {
            Proiect proiect = Manager.proiecte.ElementAt(listBox1.SelectedIndex);
            Operatie op = new Operatie();
            double x = 0;
            foreach (Cont cont in proiect.PasiveCurente)
            {
                if (cont.id.ToString()[0] == '7' && cont.valoare != 0)
                {                   
                    op.debit.Add(new Cont(cont));
                    x += cont.valoare;
                    cont.valoare = 0;
                }
            }
            if(x == 0)
            {
                return;
            }
            op.nume = "Inchidere conturi de venituri";
            op.credit.Add(new Cont(121, x, true));
            proiect.operatii.Add(op);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InchidereCheltuieli();
            InchidereVenituri();
        }
    }

}
