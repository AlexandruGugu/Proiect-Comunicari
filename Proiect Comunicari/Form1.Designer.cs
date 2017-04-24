namespace Proiect_Comunicari
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(376, 361);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listaOperatii
            // 
            this.listaOperatii.FormattingEnabled = true;
            this.listaOperatii.ItemHeight = 16;
            this.listaOperatii.Location = new System.Drawing.Point(92, 46);
            this.listaOperatii.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listaOperatii.Name = "listaOperatii";
            this.listaOperatii.Size = new System.Drawing.Size(368, 260);
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
            this.PresetBox.Location = new System.Drawing.Point(92, 361);
            this.PresetBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PresetBox.Name = "PresetBox";
            this.PresetBox.Size = new System.Drawing.Size(260, 24);
            this.PresetBox.TabIndex = 2;
            // 
            // pasivID
            // 
            this.pasivID.Location = new System.Drawing.Point(1160, 482);
            this.pasivID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pasivID.Name = "pasivID";
            this.pasivID.Size = new System.Drawing.Size(132, 22);
            this.pasivID.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 326);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Selectati operatiunea";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(737, 649);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(696, 24);
            this.comboBox1.TabIndex = 5;
            // 
            // listActiv
            // 
            this.listActiv.FormattingEnabled = true;
            this.listActiv.ItemHeight = 16;
            this.listActiv.Location = new System.Drawing.Point(737, 215);
            this.listActiv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listActiv.Name = "listActiv";
            this.listActiv.Size = new System.Drawing.Size(273, 228);
            this.listActiv.TabIndex = 7;
            // 
            // listPasiv
            // 
            this.listPasiv.FormattingEnabled = true;
            this.listPasiv.ItemHeight = 16;
            this.listPasiv.Location = new System.Drawing.Point(1160, 215);
            this.listPasiv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listPasiv.Name = "listPasiv";
            this.listPasiv.Size = new System.Drawing.Size(273, 228);
            this.listPasiv.TabIndex = 8;
            // 
            // activID
            // 
            this.activID.Location = new System.Drawing.Point(737, 482);
            this.activID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.activID.Name = "activID";
            this.activID.Size = new System.Drawing.Size(132, 22);
            this.activID.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1249, 185);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Pasiv";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(829, 185);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Activ";
            // 
            // addActiv
            // 
            this.addActiv.Location = new System.Drawing.Point(1023, 479);
            this.addActiv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addActiv.Name = "addActiv";
            this.addActiv.Size = new System.Drawing.Size(100, 28);
            this.addActiv.TabIndex = 12;
            this.addActiv.Text = "Add";
            this.addActiv.UseVisualStyleBackColor = true;
            this.addActiv.Click += new System.EventHandler(this.addActiv_Click);
            // 
            // addPasiv
            // 
            this.addPasiv.Location = new System.Drawing.Point(1443, 482);
            this.addPasiv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addPasiv.Name = "addPasiv";
            this.addPasiv.Size = new System.Drawing.Size(100, 28);
            this.addPasiv.TabIndex = 13;
            this.addPasiv.Text = "Add";
            this.addPasiv.UseVisualStyleBackColor = true;
            this.addPasiv.Click += new System.EventHandler(this.addPasiv_Click);
            // 
            // activValoare
            // 
            this.activValoare.Location = new System.Drawing.Point(879, 482);
            this.activValoare.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.activValoare.Name = "activValoare";
            this.activValoare.Size = new System.Drawing.Size(132, 22);
            this.activValoare.TabIndex = 14;
            this.activValoare.Text = "0";
            this.activValoare.Leave += new System.EventHandler(this.activValoare_Leave);
            // 
            // pasivValoare
            // 
            this.pasivValoare.Location = new System.Drawing.Point(1301, 481);
            this.pasivValoare.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pasivValoare.Name = "pasivValoare";
            this.pasivValoare.Size = new System.Drawing.Size(132, 22);
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
            this.resultDebit.ItemHeight = 16;
            this.resultDebit.Location = new System.Drawing.Point(1563, 342);
            this.resultDebit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.resultDebit.MultiColumn = true;
            this.resultDebit.Name = "resultDebit";
            this.resultDebit.Size = new System.Drawing.Size(100, 208);
            this.resultDebit.TabIndex = 16;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(200, 602);
            this.Save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(100, 28);
            this.Save.TabIndex = 17;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(1715, 636);
            this.Update.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(100, 28);
            this.Update.TabIndex = 18;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // saveConturi
            // 
            this.saveConturi.Location = new System.Drawing.Point(1823, 636);
            this.saveConturi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveConturi.Name = "saveConturi";
            this.saveConturi.Size = new System.Drawing.Size(100, 28);
            this.saveConturi.TabIndex = 19;
            this.saveConturi.Text = "Save";
            this.saveConturi.UseVisualStyleBackColor = true;
            this.saveConturi.Click += new System.EventHandler(this.saveConturi_Click);
            // 
            // resultCredit
            // 
            this.resultCredit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.resultCredit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultCredit.ForeColor = System.Drawing.SystemColors.WindowText;
            this.resultCredit.FormattingEnabled = true;
            this.resultCredit.ItemHeight = 16;
            this.resultCredit.Location = new System.Drawing.Point(1697, 342);
            this.resultCredit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.resultCredit.MultiColumn = true;
            this.resultCredit.Name = "resultCredit";
            this.resultCredit.Size = new System.Drawing.Size(99, 224);
            this.resultCredit.TabIndex = 21;
            // 
            // Egal
            // 
            this.Egal.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Egal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Egal.Location = new System.Drawing.Point(1671, 342);
            this.Egal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Egal.Name = "Egal";
            this.Egal.Size = new System.Drawing.Size(19, 15);
            this.Egal.TabIndex = 22;
            this.Egal.Text = "=";
            // 
            // egal2
            // 
            this.egal2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.egal2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.egal2.Location = new System.Drawing.Point(1841, 342);
            this.egal2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.egal2.Name = "egal2";
            this.egal2.Size = new System.Drawing.Size(19, 15);
            this.egal2.TabIndex = 23;
            this.egal2.Text = "=";
            // 
            // Result
            // 
            this.Result.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Result.Location = new System.Drawing.Point(1868, 342);
            this.Result.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(83, 15);
            this.Result.TabIndex = 24;
            // 
            // numeOp
            // 
            this.numeOp.Location = new System.Drawing.Point(552, 46);
            this.numeOp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numeOp.Name = "numeOp";
            this.numeOp.Size = new System.Drawing.Size(219, 22);
            this.numeOp.TabIndex = 25;
            // 
            // deletePasiv
            // 
            this.deletePasiv.Location = new System.Drawing.Point(1443, 324);
            this.deletePasiv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deletePasiv.Name = "deletePasiv";
            this.deletePasiv.Size = new System.Drawing.Size(100, 28);
            this.deletePasiv.TabIndex = 26;
            this.deletePasiv.Text = "Delete";
            this.deletePasiv.UseVisualStyleBackColor = true;
            this.deletePasiv.Click += new System.EventHandler(this.deletePasiv_Click);
            // 
            // editPasiv
            // 
            this.editPasiv.Location = new System.Drawing.Point(1443, 359);
            this.editPasiv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.editPasiv.Name = "editPasiv";
            this.editPasiv.Size = new System.Drawing.Size(100, 28);
            this.editPasiv.TabIndex = 27;
            this.editPasiv.Text = "Modify";
            this.editPasiv.UseVisualStyleBackColor = true;
            this.editPasiv.Click += new System.EventHandler(this.editPasiv_Click);
            // 
            // deleteActiv
            // 
            this.deleteActiv.Location = new System.Drawing.Point(1023, 324);
            this.deleteActiv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteActiv.Name = "deleteActiv";
            this.deleteActiv.Size = new System.Drawing.Size(100, 28);
            this.deleteActiv.TabIndex = 28;
            this.deleteActiv.Text = "Delete";
            this.deleteActiv.UseVisualStyleBackColor = true;
            this.deleteActiv.Click += new System.EventHandler(this.deleteActiv_Click);
            // 
            // editActiv
            // 
            this.editActiv.Location = new System.Drawing.Point(1023, 359);
            this.editActiv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.editActiv.Name = "editActiv";
            this.editActiv.Size = new System.Drawing.Size(100, 28);
            this.editActiv.TabIndex = 29;
            this.editActiv.Text = "Modify";
            this.editActiv.UseVisualStyleBackColor = true;
            this.editActiv.Click += new System.EventHandler(this.editActiv_Click);
            // 
            // debitActiv
            // 
            this.debitActiv.AutoSize = true;
            this.debitActiv.Location = new System.Drawing.Point(25, 10);
            this.debitActiv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.debitActiv.Name = "debitActiv";
            this.debitActiv.Size = new System.Drawing.Size(62, 21);
            this.debitActiv.TabIndex = 30;
            this.debitActiv.TabStop = true;
            this.debitActiv.Text = "Debit";
            this.debitActiv.UseVisualStyleBackColor = true;
            // 
            // creditActiv
            // 
            this.creditActiv.AutoSize = true;
            this.creditActiv.Location = new System.Drawing.Point(25, 38);
            this.creditActiv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.creditActiv.Name = "creditActiv";
            this.creditActiv.Size = new System.Drawing.Size(66, 21);
            this.creditActiv.TabIndex = 31;
            this.creditActiv.TabStop = true;
            this.creditActiv.Text = "Credit";
            this.creditActiv.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.creditActiv);
            this.groupBox1.Controls.Add(this.debitActiv);
            this.groupBox1.Location = new System.Drawing.Point(779, 513);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(163, 75);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.creditPasiv);
            this.groupBox2.Controls.Add(this.debitPasiv);
            this.groupBox2.Location = new System.Drawing.Point(1213, 513);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(148, 75);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            // 
            // creditPasiv
            // 
            this.creditPasiv.AutoSize = true;
            this.creditPasiv.Location = new System.Drawing.Point(15, 38);
            this.creditPasiv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.creditPasiv.Name = "creditPasiv";
            this.creditPasiv.Size = new System.Drawing.Size(66, 21);
            this.creditPasiv.TabIndex = 31;
            this.creditPasiv.TabStop = true;
            this.creditPasiv.Text = "Credit";
            this.creditPasiv.UseVisualStyleBackColor = true;
            // 
            // debitPasiv
            // 
            this.debitPasiv.AutoSize = true;
            this.debitPasiv.Location = new System.Drawing.Point(15, 15);
            this.debitPasiv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.debitPasiv.Name = "debitPasiv";
            this.debitPasiv.Size = new System.Drawing.Size(62, 21);
            this.debitPasiv.TabIndex = 30;
            this.debitPasiv.TabStop = true;
            this.debitPasiv.Text = "Debit";
            this.debitPasiv.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1914, 875);
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
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pasivID);
            this.Controls.Add(this.PresetBox);
            this.Controls.Add(this.listaOperatii);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Pasiv";
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
        private System.Windows.Forms.Label label1;
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
    }
}

