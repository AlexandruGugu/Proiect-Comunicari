namespace Proiect_Comunicari
{
    partial class OpForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.listaOperatii = new System.Windows.Forms.ListBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.PresetBox = new System.Windows.Forms.ComboBox();
            this.pasivID = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listActiv = new System.Windows.Forms.ListBox();
            this.listPasiv = new System.Windows.Forms.ListBox();
            this.activID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addActiv = new System.Windows.Forms.Button();
            this.addPasiv = new System.Windows.Forms.Button();
            this.activValoare = new System.Windows.Forms.TextBox();
            this.pasivValoare = new System.Windows.Forms.TextBox();
            this.resultDebit = new System.Windows.Forms.ListBox();
            this.Save = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.saveConturi = new System.Windows.Forms.Button();
            this.resultCredit = new System.Windows.Forms.ListBox();
            this.Egal = new System.Windows.Forms.TextBox();
            this.egal2 = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.TextBox();
            this.numeOp = new System.Windows.Forms.TextBox();
            this.deletePasiv = new System.Windows.Forms.Button();
            this.editPasiv = new System.Windows.Forms.Button();
            this.deleteActiv = new System.Windows.Forms.Button();
            this.editActiv = new System.Windows.Forms.Button();
            this.debitActiv = new System.Windows.Forms.RadioButton();
            this.creditActiv = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.creditPasiv = new System.Windows.Forms.RadioButton();
            this.debitPasiv = new System.Windows.Forms.RadioButton();
            this.descriereOp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(125, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 21);
            this.button1.TabIndex = 0;
            this.button1.Text = "Adauga operatie noua";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listaOperatii
            // 
            this.listaOperatii.FormattingEnabled = true;
            this.listaOperatii.Location = new System.Drawing.Point(69, 37);
            this.listaOperatii.Name = "listaOperatii";
            this.listaOperatii.Size = new System.Drawing.Size(277, 212);
            this.listaOperatii.TabIndex = 1;
            this.listaOperatii.SelectedIndexChanged += new System.EventHandler(this.listaOperatii_SelectedIndexChanged);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // PresetBox
            // 
            this.PresetBox.FormattingEnabled = true;
            this.PresetBox.Location = new System.Drawing.Point(29, 527);
            this.PresetBox.Name = "PresetBox";
            this.PresetBox.Size = new System.Drawing.Size(196, 21);
            this.PresetBox.TabIndex = 2;
            // 
            // pasivID
            // 
            this.pasivID.Location = new System.Drawing.Point(870, 392);
            this.pasivID.Name = "pasivID";
            this.pasivID.Size = new System.Drawing.Size(100, 20);
            this.pasivID.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(438, 527);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(776, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listActiv
            // 
            this.listActiv.FormattingEnabled = true;
            this.listActiv.Location = new System.Drawing.Point(553, 175);
            this.listActiv.Name = "listActiv";
            this.listActiv.Size = new System.Drawing.Size(206, 186);
            this.listActiv.TabIndex = 7;
            // 
            // listPasiv
            // 
            this.listPasiv.FormattingEnabled = true;
            this.listPasiv.Location = new System.Drawing.Point(870, 175);
            this.listPasiv.Name = "listPasiv";
            this.listPasiv.Size = new System.Drawing.Size(206, 186);
            this.listPasiv.TabIndex = 8;
            // 
            // activID
            // 
            this.activID.Location = new System.Drawing.Point(553, 392);
            this.activID.Name = "activID";
            this.activID.Size = new System.Drawing.Size(100, 20);
            this.activID.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(937, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Pasiv";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(622, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Activ";
            // 
            // addActiv
            // 
            this.addActiv.Location = new System.Drawing.Point(767, 389);
            this.addActiv.Name = "addActiv";
            this.addActiv.Size = new System.Drawing.Size(75, 23);
            this.addActiv.TabIndex = 12;
            this.addActiv.Text = "Adauga";
            this.addActiv.UseVisualStyleBackColor = true;
            this.addActiv.Click += new System.EventHandler(this.addActiv_Click);
            // 
            // addPasiv
            // 
            this.addPasiv.Location = new System.Drawing.Point(1082, 392);
            this.addPasiv.Name = "addPasiv";
            this.addPasiv.Size = new System.Drawing.Size(75, 23);
            this.addPasiv.TabIndex = 13;
            this.addPasiv.Text = "Adauga";
            this.addPasiv.UseVisualStyleBackColor = true;
            this.addPasiv.Click += new System.EventHandler(this.addPasiv_Click);
            // 
            // activValoare
            // 
            this.activValoare.Location = new System.Drawing.Point(659, 392);
            this.activValoare.Name = "activValoare";
            this.activValoare.Size = new System.Drawing.Size(100, 20);
            this.activValoare.TabIndex = 14;
            this.activValoare.Text = "0";
            this.activValoare.Leave += new System.EventHandler(this.activValoare_Leave);
            // 
            // pasivValoare
            // 
            this.pasivValoare.Location = new System.Drawing.Point(976, 391);
            this.pasivValoare.Name = "pasivValoare";
            this.pasivValoare.Size = new System.Drawing.Size(100, 20);
            this.pasivValoare.TabIndex = 15;
            this.pasivValoare.Text = "0";
            this.pasivValoare.Leave += new System.EventHandler(this.pasivValoare_Leave);
            // 
            // resultDebit
            // 
            this.resultDebit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.resultDebit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultDebit.ForeColor = System.Drawing.SystemColors.WindowText;
            this.resultDebit.FormattingEnabled = true;
            this.resultDebit.Location = new System.Drawing.Point(1172, 278);
            this.resultDebit.MultiColumn = true;
            this.resultDebit.Name = "resultDebit";
            this.resultDebit.Size = new System.Drawing.Size(75, 169);
            this.resultDebit.TabIndex = 16;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(29, 498);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 17;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Visible = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(1185, 213);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(142, 20);
            this.Update.TabIndex = 18;
            this.Update.Text = "Verificare formula contabila";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // saveConturi
            // 
            this.saveConturi.Location = new System.Drawing.Point(1314, 525);
            this.saveConturi.Name = "saveConturi";
            this.saveConturi.Size = new System.Drawing.Size(81, 23);
            this.saveConturi.TabIndex = 19;
            this.saveConturi.Text = "Salveaza";
            this.saveConturi.UseVisualStyleBackColor = true;
            this.saveConturi.Click += new System.EventHandler(this.saveConturi_Click);
            // 
            // resultCredit
            // 
            this.resultCredit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.resultCredit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultCredit.ForeColor = System.Drawing.SystemColors.WindowText;
            this.resultCredit.FormattingEnabled = true;
            this.resultCredit.Location = new System.Drawing.Point(1273, 278);
            this.resultCredit.MultiColumn = true;
            this.resultCredit.Name = "resultCredit";
            this.resultCredit.Size = new System.Drawing.Size(74, 182);
            this.resultCredit.TabIndex = 21;
            // 
            // Egal
            // 
            this.Egal.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Egal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Egal.Location = new System.Drawing.Point(1253, 278);
            this.Egal.Name = "Egal";
            this.Egal.Size = new System.Drawing.Size(14, 13);
            this.Egal.TabIndex = 22;
            this.Egal.Text = "=";
            // 
            // egal2
            // 
            this.egal2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.egal2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.egal2.Location = new System.Drawing.Point(1381, 278);
            this.egal2.Name = "egal2";
            this.egal2.Size = new System.Drawing.Size(14, 13);
            this.egal2.TabIndex = 23;
            this.egal2.Text = "=";
            // 
            // Result
            // 
            this.Result.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Result.Location = new System.Drawing.Point(1401, 278);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(62, 13);
            this.Result.TabIndex = 24;
            // 
            // numeOp
            // 
            this.numeOp.Location = new System.Drawing.Point(383, 37);
            this.numeOp.Name = "numeOp";
            this.numeOp.Size = new System.Drawing.Size(165, 20);
            this.numeOp.TabIndex = 25;
            // 
            // deletePasiv
            // 
            this.deletePasiv.Location = new System.Drawing.Point(1082, 263);
            this.deletePasiv.Name = "deletePasiv";
            this.deletePasiv.Size = new System.Drawing.Size(75, 23);
            this.deletePasiv.TabIndex = 26;
            this.deletePasiv.Text = "Sterge";
            this.deletePasiv.UseVisualStyleBackColor = true;
            this.deletePasiv.Click += new System.EventHandler(this.deletePasiv_Click);
            // 
            // editPasiv
            // 
            this.editPasiv.Location = new System.Drawing.Point(1082, 292);
            this.editPasiv.Name = "editPasiv";
            this.editPasiv.Size = new System.Drawing.Size(75, 35);
            this.editPasiv.TabIndex = 27;
            this.editPasiv.Text = "Modifica valoarea";
            this.editPasiv.UseVisualStyleBackColor = true;
            this.editPasiv.Click += new System.EventHandler(this.editPasiv_Click);
            // 
            // deleteActiv
            // 
            this.deleteActiv.Location = new System.Drawing.Point(767, 263);
            this.deleteActiv.Name = "deleteActiv";
            this.deleteActiv.Size = new System.Drawing.Size(75, 23);
            this.deleteActiv.TabIndex = 28;
            this.deleteActiv.Text = "Sterge";
            this.deleteActiv.UseVisualStyleBackColor = true;
            this.deleteActiv.Click += new System.EventHandler(this.deleteActiv_Click);
            // 
            // editActiv
            // 
            this.editActiv.Location = new System.Drawing.Point(767, 292);
            this.editActiv.Name = "editActiv";
            this.editActiv.Size = new System.Drawing.Size(75, 35);
            this.editActiv.TabIndex = 29;
            this.editActiv.Text = "Modifica valoarea";
            this.editActiv.UseVisualStyleBackColor = true;
            this.editActiv.Click += new System.EventHandler(this.editActiv_Click);
            // 
            // debitActiv
            // 
            this.debitActiv.AutoSize = true;
            this.debitActiv.Location = new System.Drawing.Point(19, 8);
            this.debitActiv.Name = "debitActiv";
            this.debitActiv.Size = new System.Drawing.Size(50, 17);
            this.debitActiv.TabIndex = 30;
            this.debitActiv.TabStop = true;
            this.debitActiv.Text = "Debit";
            this.debitActiv.UseVisualStyleBackColor = true;
            // 
            // creditActiv
            // 
            this.creditActiv.AutoSize = true;
            this.creditActiv.Location = new System.Drawing.Point(19, 31);
            this.creditActiv.Name = "creditActiv";
            this.creditActiv.Size = new System.Drawing.Size(52, 17);
            this.creditActiv.TabIndex = 31;
            this.creditActiv.TabStop = true;
            this.creditActiv.Text = "Credit";
            this.creditActiv.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.creditActiv);
            this.groupBox1.Controls.Add(this.debitActiv);
            this.groupBox1.Location = new System.Drawing.Point(584, 417);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(122, 61);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.creditPasiv);
            this.groupBox2.Controls.Add(this.debitPasiv);
            this.groupBox2.Location = new System.Drawing.Point(910, 417);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(111, 61);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            // 
            // creditPasiv
            // 
            this.creditPasiv.AutoSize = true;
            this.creditPasiv.Location = new System.Drawing.Point(11, 31);
            this.creditPasiv.Name = "creditPasiv";
            this.creditPasiv.Size = new System.Drawing.Size(52, 17);
            this.creditPasiv.TabIndex = 31;
            this.creditPasiv.TabStop = true;
            this.creditPasiv.Text = "Credit";
            this.creditPasiv.UseVisualStyleBackColor = true;
            // 
            // debitPasiv
            // 
            this.debitPasiv.AutoSize = true;
            this.debitPasiv.Location = new System.Drawing.Point(11, 12);
            this.debitPasiv.Name = "debitPasiv";
            this.debitPasiv.Size = new System.Drawing.Size(50, 17);
            this.debitPasiv.TabIndex = 30;
            this.debitPasiv.TabStop = true;
            this.debitPasiv.Text = "Debit";
            this.debitPasiv.UseVisualStyleBackColor = true;
            // 
            // descriereOp
            // 
            this.descriereOp.Location = new System.Drawing.Point(625, 37);
            this.descriereOp.Multiline = true;
            this.descriereOp.Name = "descriereOp";
            this.descriereOp.Size = new System.Drawing.Size(796, 78);
            this.descriereOp.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1182, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Debit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1283, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Credit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1398, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(690, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "valoare";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(570, 375);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "numar cont";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(896, 375);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "numar cont";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1011, 375);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 43;
            this.label9.Text = "valoare";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(723, 503);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(277, 13);
            this.label10.TabIndex = 44;
            this.label10.Text = "Lista denumiri conturi, conform planului de conturi general";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(419, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 13);
            this.label11.TabIndex = 45;
            this.label11.Text = "numele operatiei";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(977, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 13);
            this.label12.TabIndex = 46;
            this.label12.Text = "descrierea operatiei";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(148, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 13);
            this.label13.TabIndex = 47;
            this.label13.Text = "Lista operatiilor";
            // 
            // OpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1475, 711);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.descriereOp);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.editActiv);
            this.Controls.Add(this.deleteActiv);
            this.Controls.Add(this.editPasiv);
            this.Controls.Add(this.deletePasiv);
            this.Controls.Add(this.numeOp);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.egal2);
            this.Controls.Add(this.Egal);
            this.Controls.Add(this.resultCredit);
            this.Controls.Add(this.saveConturi);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.resultDebit);
            this.Controls.Add(this.pasivValoare);
            this.Controls.Add(this.activValoare);
            this.Controls.Add(this.addPasiv);
            this.Controls.Add(this.addActiv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.activID);
            this.Controls.Add(this.listPasiv);
            this.Controls.Add(this.listActiv);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pasivID);
            this.Controls.Add(this.PresetBox);
            this.Controls.Add(this.listaOperatii);
            this.Controls.Add(this.button1);
            this.Name = "OpForm";
            this.Text = "Pasiv";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OpForm_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listaOperatii;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.ComboBox PresetBox;
        private System.Windows.Forms.TextBox pasivID;
        private System.Windows.Forms.ListBox listPasiv;
        private System.Windows.Forms.ListBox listActiv;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox activID;
        private System.Windows.Forms.TextBox pasivValoare;
        private System.Windows.Forms.TextBox activValoare;
        private System.Windows.Forms.Button addPasiv;
        private System.Windows.Forms.Button addActiv;
        private System.Windows.Forms.ListBox resultDebit;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button saveConturi;
        private System.Windows.Forms.TextBox Egal;
        private System.Windows.Forms.ListBox resultCredit;
        private System.Windows.Forms.TextBox egal2;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.TextBox numeOp;
        private System.Windows.Forms.Button editActiv;
        private System.Windows.Forms.Button deleteActiv;
        private System.Windows.Forms.Button editPasiv;
        private System.Windows.Forms.Button deletePasiv;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton creditPasiv;
        private System.Windows.Forms.RadioButton debitPasiv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton creditActiv;
        private System.Windows.Forms.RadioButton debitActiv;
        private System.Windows.Forms.TextBox descriereOp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}

