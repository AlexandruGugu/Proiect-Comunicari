namespace Proiect_Comunicari
{
    partial class MenuForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.addPrj = new System.Windows.Forms.Button();
            this.openConturi = new System.Windows.Forms.Button();
            this.openOp = new System.Windows.Forms.Button();
            this.delPrj = new System.Windows.Forms.Button();
            this.print = new System.Windows.Forms.Button();
            this.numeFisier = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(227, 72);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(436, 251);
            this.listBox1.TabIndex = 0;
            // 
            // addPrj
            // 
            this.addPrj.Location = new System.Drawing.Point(227, 344);
            this.addPrj.Name = "addPrj";
            this.addPrj.Size = new System.Drawing.Size(107, 21);
            this.addPrj.TabIndex = 1;
            this.addPrj.Text = "Proiect nou";
            this.addPrj.UseVisualStyleBackColor = true;
            this.addPrj.Click += new System.EventHandler(this.addPrj_Click);
            // 
            // openConturi
            // 
            this.openConturi.Location = new System.Drawing.Point(721, 149);
            this.openConturi.Name = "openConturi";
            this.openConturi.Size = new System.Drawing.Size(132, 20);
            this.openConturi.TabIndex = 2;
            this.openConturi.Text = "Conturi";
            this.openConturi.UseVisualStyleBackColor = true;
            this.openConturi.Click += new System.EventHandler(this.openConturi_Click);
            // 
            // openOp
            // 
            this.openOp.Location = new System.Drawing.Point(721, 206);
            this.openOp.Name = "openOp";
            this.openOp.Size = new System.Drawing.Size(132, 21);
            this.openOp.TabIndex = 3;
            this.openOp.Text = "Operatii";
            this.openOp.UseVisualStyleBackColor = true;
            this.openOp.Click += new System.EventHandler(this.openOp_Click);
            // 
            // delPrj
            // 
            this.delPrj.Location = new System.Drawing.Point(588, 344);
            this.delPrj.Name = "delPrj";
            this.delPrj.Size = new System.Drawing.Size(75, 23);
            this.delPrj.TabIndex = 4;
            this.delPrj.Text = "Stergere";
            this.delPrj.UseVisualStyleBackColor = true;
            this.delPrj.Click += new System.EventHandler(this.delPrj_Click);
            // 
            // print
            // 
            this.print.Location = new System.Drawing.Point(993, 405);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(98, 23);
            this.print.TabIndex = 5;
            this.print.Text = "Scrie in excel";
            this.print.UseVisualStyleBackColor = true;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // numeFisier
            // 
            this.numeFisier.Location = new System.Drawing.Point(993, 433);
            this.numeFisier.Margin = new System.Windows.Forms.Padding(2);
            this.numeFisier.Name = "numeFisier";
            this.numeFisier.Size = new System.Drawing.Size(128, 20);
            this.numeFisier.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(898, 436);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nume fisier excel:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(869, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 48);
            this.button1.TabIndex = 8;
            this.button1.Text = "Inchidere conturi de venituri si cheltuieli";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(340, 347);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "nume proiect";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 498);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numeFisier);
            this.Controls.Add(this.print);
            this.Controls.Add(this.delPrj);
            this.Controls.Add(this.openOp);
            this.Controls.Add(this.openConturi);
            this.Controls.Add(this.addPrj);
            this.Controls.Add(this.listBox1);
            this.Name = "MenuForm";
            this.Text = "Meniu Principal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SelectForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button addPrj;
        private System.Windows.Forms.Button openConturi;
        private System.Windows.Forms.Button openOp;
        private System.Windows.Forms.Button delPrj;
        private System.Windows.Forms.Button print;
        private System.Windows.Forms.TextBox numeFisier;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}