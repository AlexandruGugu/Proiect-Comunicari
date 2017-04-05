﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_Comunicari
{

    public partial class Form1 : Form
    {
        public Proiect proiect = new Proiect();
        public List<Operatie> presets = new List<Operatie>();
        public List<Cont> tempDebit = new List<Cont>();
        public List<Cont> tempCredit = new List<Cont>();
        public double sumaC = 0;
        public double sumaD = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PresetBox.SelectedIndex != -1)
            {
                AddOp(presets[PresetBox.SelectedIndex]);
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

            if (File.Exists("G:\\proiect.bin"))
            {
                proiect = BinarySerialization.ReadFromBinaryFile<Proiect>("G:\\proiect.bin");
            }

            if (File.Exists("G:\\presets.bin"))
            {
                presets = BinarySerialization.ReadFromBinaryFile<List<Operatie>>("G:\\presets.bin");
            }
            else
            {
                presets.Add(new Operatie("Custom"));
            }
            foreach (Operatie op in presets)
            {
                PresetBox.Items.Add(op.nume);
            }
            int i = 1;
            foreach (Operatie op in proiect.operatii)
            {
                listaOperatii.Items.Add(i++ + " " + op.nume);

            }

        }

        public void AddOp(Operatie op)
        {
            proiect.operatii.Add(new Operatie(op));
            listaOperatii.Items.Add(proiect.operatii.Count + " " + op.nume);

        }

        private void Save_Click(object sender, EventArgs e)
        {
            BinarySerialization.WriteToBinaryFile<Proiect>("G:\\proiect.bin", proiect);
        }


        private void clearDisplay()
        {
            numeOp.Clear();
            listActiv.Items.Clear();
            listPasiv.Items.Clear();
            Result.Clear();
            resultDebit.Items.Clear();
            resultCredit.Items.Clear();
            activID.Clear();
            pasivID.Clear();
            activValoare.Clear();
            pasivValoare.Clear();
        }
        private void updateListaConturi(List<Cont> from, List<Cont> to, string txt)
        {
            foreach (Cont cont in from)
            {
                to.Add(new Cont(cont));
                if (cont.activ)
                {
                    listActiv.Items.Add(cont.id + " " + cont.valoare + txt);
                }
                else
                {
                    listPasiv.Items.Add(cont.id + " " + cont.valoare + txt);
                }
            }
        }
        private void addCont(double x, double id, bool activ)
        {
            if (activ)
            {

                // listActiv.Items.Add(id + " " + x + (creditActiv.Checked? " C" : " D"));
                if (creditActiv.Checked)
                {
                    listActiv.Items.Add(id + " " + -x + " C");
                    tempCredit.Add(new Cont(id, x, true));
                }
                else
                {
                    listActiv.Items.Add(id + " " + x + " D");
                    tempDebit.Add(new Cont(id, x, true));
                }
            }
            else
            {
                // listPasiv.Items.Add(id + " " + x + (debitPasiv.Checked ? " D" : " C"));
                if (!debitPasiv.Checked)
                {
                    listPasiv.Items.Add(id + " " + x + " C");
                    tempCredit.Add(new Cont(id, x, false));
                }
                else
                {
                    listPasiv.Items.Add(id + " " + -x + " D");
                    tempDebit.Add(new Cont(id, x, false));
                }
            }
        }

        private bool EgalitateDebitCredit()
        {
            sumaD = 0;
            sumaC = 0;
            foreach (Cont cont in tempCredit)
            {
                sumaC += cont.valoare;
            }
            foreach (Cont cont in tempDebit)
            {
                sumaD += cont.valoare;
            }
            if (sumaC == sumaD)
            {
                return true;
            }
            return false;
        }
        private void updateDisplay()
        {
            clearDisplay();
            int index = listaOperatii.SelectedIndex;
            numeOp.Text = proiect.operatii[index].nume;
            tempCredit.Clear();
            tempDebit.Clear();
            updateListaConturi(proiect.operatii[index].debit, tempDebit, " D");
            updateListaConturi(proiect.operatii[index].credit, tempCredit, " C");
            /*foreach (Cont cont in proiect.operatii[index].debit)
            {
                tempDebit.Add(new Cont(cont));
                if (cont.activ)
                {
                    listActiv.Items.Add(cont.id + " " + cont.valoare + " D");
                }
                else
                {
                    listPasiv.Items.Add(cont.id + " " + cont.valoare + " D");
                }
            }
            foreach (Cont cont in proiect.operatii[index].credit)
            {
                tempCredit.Add(new Cont(cont));
                if (cont.activ)
                {
                    listActiv.Items.Add(cont.id + " " + cont.valoare + " C");
                }
                else
                {
                    listPasiv.Items.Add(cont.id + " " + cont.valoare + " C");
                }
            }*/
        }

        private void updateListaConturi()
        {
            clearDisplay();
            foreach (Cont cont in tempDebit)
            {
                if (cont.activ)
                {
                    listActiv.Items.Add(cont.id + " " + cont.valoare + " D");
                }
                else
                {
                    listPasiv.Items.Add(cont.id + " " + cont.valoare + " D");
                }
            }
            foreach (Cont cont in tempCredit)
            {
                if (cont.activ)
                {
                    listActiv.Items.Add(cont.id + " -" + cont.valoare + " C");
                }
                else
                {
                    listPasiv.Items.Add(cont.id + " -" + cont.valoare + " C");
                }
            }
        }
        private bool debit(ListBox list, int index)
        {
            char[] array = list.Items[index].ToString().ToCharArray();
            return array[array.Length - 1] == 'D' ? true : false;
        }

        private void changeActiv(Cont cont, string txt1, string txt2)
        {
            listActiv.SelectedItem = cont.id.ToString() + txt1 + activValoare.Text + txt2;
            cont.valoare = Convert.ToDouble(activValoare.Text);
        }

        private void changePasiv(Cont cont, string txt1, string txt2)
        {
            listPasiv.SelectedItem = cont.id.ToString() + txt1 + pasivValoare.Text + txt2;
            cont.valoare = Convert.ToDouble(activValoare.Text);
        }

        private void listaOperatii_SelectedIndexChanged(object sender, EventArgs e)
        {           
            if(listaOperatii.SelectedIndex >= 0)
            {
                updateDisplay();
            }
            
        }

        
        private void addActiv_Click(object sender, EventArgs e)
        {
            double id, x;
            if(double.TryParse(activValoare.Text, out x) && double.TryParse(activID.Text, out id))
            {
                addCont(x, id, true);
                activValoare.Clear();
                activID.Clear();
            }
        }

        private void addPasiv_Click(object sender, EventArgs e)
        {
            double id, x;
            if (double.TryParse(pasivValoare.Text, out x) && double.TryParse(pasivID.Text, out id))
            {
                addCont(x, id, false);
                pasivValoare.Clear();
                pasivID.Clear();
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            resultCredit.Items.Clear();
            resultDebit.Items.Clear();           
            if(!EgalitateDebitCredit())
            {
                MessageBox.Show("Debit(" + sumaD + ") nu este egal cu Credit("+ sumaC + ")");
                return;
            }
            if(tempDebit.Count > 1)
            {
                resultDebit.Items.Add("  %  ");
            }
            if(tempCredit.Count > 1)
            {
                resultCredit.Items.Add("  %  ");
            }
            foreach(Cont cont in tempDebit)
            {
                resultDebit.Items.Add(cont.id + " " + cont.valoare);
            }
            foreach(Cont cont in tempCredit)
            {
                resultCredit.Items.Add(cont.id + " " + cont.valoare);
            }
            Result.Text = sumaD.ToString();

        }

        private void saveConturi_Click(object sender, EventArgs e)
        {
            if(!EgalitateDebitCredit())
            {
                return;
            }
            int index = listaOperatii.SelectedIndex;
            proiect.operatii[index].credit.Clear();
            proiect.operatii[index].debit.Clear();
            foreach (Cont cont in tempCredit)
            {
                proiect.operatii[index].credit.Add(new Cont(cont));
            }
            foreach(Cont cont in tempDebit)
            {
                proiect.operatii[index].debit.Add(new Cont(cont));
            }
            proiect.operatii.ElementAt(index).nume = numeOp.Text;
            listaOperatii.SelectedIndexChanged -= new EventHandler(listaOperatii_SelectedIndexChanged);
            string nume = numeOp.Text;
            listaOperatii.Items[index] = index + 1 + " " + nume;
            listaOperatii.SelectedIndexChanged += new EventHandler(listaOperatii_SelectedIndexChanged);
        }

        
        private void deleteActiv_Click(object sender, EventArgs e)
        {
            int index = listActiv.SelectedIndex;
            if(index < 0)
            {
                return;
            }
            bool D = debit(listActiv, index);
            int contor = 0;
            for(int i = 0; i < index; i++)
            {
                if(debit(listActiv, i) == D)
                {
                    contor++;
                }
            }
            listActiv.Items.RemoveAt(index);
            if (D)
            {
                tempDebit.RemoveAt(contor);
            }
            else
            {
                tempCredit.RemoveAt(contor);
            }
                       
        }

        private void deletePasiv_Click(object sender, EventArgs e)
        {
            int index = listPasiv.SelectedIndex;
            if (index < 0)
            {
                return;
            }
            bool D = debit(listPasiv, index);
            int contor = 0;
            for (int i = 0; i < listActiv.Items.Count; i++)
            {
                if (debit(listActiv, i) == D)
                {
                    contor++;
                }
            }
            for (int i = 0; i < index; i++)
            {
                if (debit(listPasiv, i) == D)
                {
                    contor++;
                }
            }
            listPasiv.Items.RemoveAt(index);
            if (D)
            {
                tempDebit.RemoveAt(contor);
            }
            else
            {
                tempCredit.RemoveAt(contor);
            }
        }
        
        private void editActiv_Click(object sender, EventArgs e)
        {
            int index = listActiv.SelectedIndex;
            bool D = debit(listActiv, index);
            int contor = 0;
            for (int i = 0; i < index; i++)
            {
                if (debit(listActiv, i) == D)
                {
                    contor++;
                }
            }            
            if (D)
            {
                if(debitActiv.Checked)
                {
                    changeActiv(tempDebit[contor], " ", " D");
                }
                else
                {
                    changeActiv(tempDebit[contor], " -", " C");
                    tempCredit.Add(new Cont(tempDebit[contor]));
                    tempDebit.RemoveAt(contor);                    
                }                               
            }
            else
            {
                if(debitActiv.Checked)
                {
                    changeActiv(tempCredit[contor], " ", " D");
                    tempDebit.Add(new Cont(tempCredit[contor]));
                    tempCredit.RemoveAt(contor);                    
                }
                else
                {
                    changeActiv(tempCredit[contor], " -", " C");
                }
            }
            updateListaConturi();

        }

        private void editPasiv_Click(object sender, EventArgs e)
        {
            int index = listPasiv.SelectedIndex;
            bool D = debit(listPasiv, index);
            int contor = 0;
            for (int i = 0; i < listActiv.Items.Count; i++)
            {
                if (debit(listActiv, i) == D)
                {
                    contor++;
                }
            }
            for (int i = 0; i < index; i++)
            {
                if (debit(listPasiv, i) == D)
                {
                    contor++;
                }
            }
            if (D)
            {
                if (debitPasiv.Checked)
                {
                    changePasiv(tempDebit[contor], " -", " D");
                }
                else
                {
                    changePasiv(tempDebit[contor], " ", " C");
                    tempCredit.Add(new Cont(tempDebit[contor]));
                    tempDebit.RemoveAt(contor);
                }
            }
            else
            {
                if (debitPasiv.Checked)
                {
                    changePasiv(tempCredit[contor], " -", " D");
                    tempDebit.Add(new Cont(tempCredit[contor]));
                    tempCredit.RemoveAt(contor);
                    
                }
                else
                {
                    changePasiv(tempCredit[contor], " ", " C");
                }
            }
            updateListaConturi();
        }
    }
    [Serializable]
    public class Operatie
    {
        public string nume { get; set; }      
        bool TVA { get; set; }
        public List<Cont> debit { get; set; }
        public List<Cont> credit { get; set; }

        public Operatie(string Nume = "", bool tva = false, List<Cont> Debit = null, List<Cont> Credit = null)
        {
            TVA = tva;
            nume = Nume;
            if(Debit == null)
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
            if(Credit == null)
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
            foreach(Cont cont in op.debit)
            {
                debit.Add(new Cont(cont));
            }
            foreach(Cont cont in op.credit)
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

        public Cont(double ID, double VALOARE, bool ACTIV)
        {
            id = ID;
            valoare = VALOARE;
            activ = ACTIV;
        }
        
        public Cont(Cont cont)
        {
            nume = cont.nume;
            id = cont.id;
            activ = cont.activ;
            valoare = cont.valoare;
        }
    }

    
    [Serializable]
    public class Proiect
    {
        public List<Operatie> operatii = new List<Operatie>();
        public List<Operatie> presets = new List<Operatie>();
        public List<Cont> Active = new List<Cont>();
        public List<Cont> Pasive = new List<Cont>();
        int totalActive = 0;
        int totalPasive = 0;

        public Proiect()
        {
            
            
        }
    }
    
    public static class BinarySerialization
    {
        /// <summary>
        /// Writes the given object instance to a binary file.
        /// <para>Object type (and all child types) must be decorated with the [Serializable] attribute.</para>
        /// <para>To prevent a variable from being serialized, decorate it with the [NonSerialized] attribute; cannot be applied to properties.</para>
        /// </summary>
        /// <typeparam name="T">The type of object being written to the XML file.</typeparam>
        /// <param name="filePath">The file path to write the object instance to.</param>
        /// <param name="objectToWrite">The object instance to write to the XML file.</param>
        /// <param name="append">If false the file will be overwritten if it already exists. If true the contents will be appended to the file.</param>
        public static void WriteToBinaryFile<T>(string filePath, T objectToWrite, bool append = false)
        {
            using (Stream stream = File.Open(filePath, append ? FileMode.Append : FileMode.Create))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                binaryFormatter.Serialize(stream, objectToWrite);
            }
        }

        /// <summary>
        /// Reads an object instance from a binary file.
        /// </summary>
        /// <typeparam name="T">The type of object to read from the XML.</typeparam>
        /// <param name="filePath">The file path to read the object instance from.</param>
        /// <returns>Returns a new instance of the object read from the binary file.</returns>
        public static T ReadFromBinaryFile<T>(string filePath)
        {
            using (Stream stream = File.Open(filePath, FileMode.Open))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                return (T)binaryFormatter.Deserialize(stream);
            }
        }
    }
}
