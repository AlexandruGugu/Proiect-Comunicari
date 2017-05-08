namespace Proiect_Comunicari
{
    partial class ConturiForm
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
            this.listaActive = new System.Windows.Forms.ListBox();
            this.listaPasive = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.addPasiv = new System.Windows.Forms.Button();
            this.activID = new System.Windows.Forms.TextBox();
            this.pasivValoare = new System.Windows.Forms.TextBox();
            this.activValoare = new System.Windows.Forms.TextBox();
            this.pasivID = new System.Windows.Forms.TextBox();
            this.addActiv = new System.Windows.Forms.Button();
            this.deletePasiv = new System.Windows.Forms.Button();
            this.deleteActiv = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listaActive
            // 
            this.listaActive.FormattingEnabled = true;
            this.listaActive.Location = new System.Drawing.Point(168, 63);
            this.listaActive.Name = "listaActive";
            this.listaActive.Size = new System.Drawing.Size(445, 342);
            this.listaActive.TabIndex = 0;
            // 
            // listaPasive
            // 
            this.listaPasive.FormattingEnabled = true;
            this.listaPasive.Location = new System.Drawing.Point(750, 63);
            this.listaPasive.Name = "listaPasive";
            this.listaPasive.Size = new System.Drawing.Size(445, 342);
            this.listaPasive.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(168, 487);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(1027, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // addPasiv
            // 
            this.addPasiv.Location = new System.Drawing.Point(1108, 430);
            this.addPasiv.Name = "addPasiv";
            this.addPasiv.Size = new System.Drawing.Size(87, 24);
            this.addPasiv.TabIndex = 3;
            this.addPasiv.Text = "Adauga contul";
            this.addPasiv.UseVisualStyleBackColor = true;
            this.addPasiv.Click += new System.EventHandler(this.addPasiv_Click);
            // 
            // activID
            // 
            this.activID.Location = new System.Drawing.Point(168, 433);
            this.activID.Name = "activID";
            this.activID.Size = new System.Drawing.Size(100, 20);
            this.activID.TabIndex = 5;
            // 
            // pasivValoare
            // 
            this.pasivValoare.Location = new System.Drawing.Point(930, 433);
            this.pasivValoare.Name = "pasivValoare";
            this.pasivValoare.Size = new System.Drawing.Size(100, 20);
            this.pasivValoare.TabIndex = 6;
            // 
            // activValoare
            // 
            this.activValoare.Location = new System.Drawing.Point(342, 434);
            this.activValoare.Name = "activValoare";
            this.activValoare.Size = new System.Drawing.Size(100, 20);
            this.activValoare.TabIndex = 7;
            // 
            // pasivID
            // 
            this.pasivID.Location = new System.Drawing.Point(750, 433);
            this.pasivID.Name = "pasivID";
            this.pasivID.Size = new System.Drawing.Size(100, 20);
            this.pasivID.TabIndex = 8;
            // 
            // addActiv
            // 
            this.addActiv.Location = new System.Drawing.Point(527, 430);
            this.addActiv.Name = "addActiv";
            this.addActiv.Size = new System.Drawing.Size(86, 24);
            this.addActiv.TabIndex = 9;
            this.addActiv.Text = "Adauga contul";
            this.addActiv.UseVisualStyleBackColor = true;
            this.addActiv.Click += new System.EventHandler(this.addActiv_Click);
            // 
            // deletePasiv
            // 
            this.deletePasiv.Location = new System.Drawing.Point(1201, 226);
            this.deletePasiv.Name = "deletePasiv";
            this.deletePasiv.Size = new System.Drawing.Size(75, 23);
            this.deletePasiv.TabIndex = 10;
            this.deletePasiv.Text = "Sterge";
            this.deletePasiv.UseVisualStyleBackColor = true;
            this.deletePasiv.Click += new System.EventHandler(this.deletePasiv_Click);
            // 
            // deleteActiv
            // 
            this.deleteActiv.Location = new System.Drawing.Point(87, 226);
            this.deleteActiv.Name = "deleteActiv";
            this.deleteActiv.Size = new System.Drawing.Size(75, 23);
            this.deleteActiv.TabIndex = 11;
            this.deleteActiv.Text = "Sterge";
            this.deleteActiv.UseVisualStyleBackColor = true;
            this.deleteActiv.Click += new System.EventHandler(this.deleteActiv_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(960, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "PASIVE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(339, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "ACTIVE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(573, 471);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Lista denumiri conturi, conform planului de conturi general";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(960, 417);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "valoare";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(774, 417);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "numar cont";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(379, 418);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "valoare";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(188, 417);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "numar cont";
            // 
            // ConturiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1437, 603);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteActiv);
            this.Controls.Add(this.deletePasiv);
            this.Controls.Add(this.addActiv);
            this.Controls.Add(this.pasivID);
            this.Controls.Add(this.activValoare);
            this.Controls.Add(this.pasivValoare);
            this.Controls.Add(this.activID);
            this.Controls.Add(this.addPasiv);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listaPasive);
            this.Controls.Add(this.listaActive);
            this.Name = "ConturiForm";
            this.Text = "ConturiForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConturiForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listaActive;
        private System.Windows.Forms.ListBox listaPasive;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button addPasiv;
        private System.Windows.Forms.TextBox activID;
        private System.Windows.Forms.TextBox pasivValoare;
        private System.Windows.Forms.TextBox activValoare;
        private System.Windows.Forms.TextBox pasivID;
        private System.Windows.Forms.Button addActiv;
        private System.Windows.Forms.Button deletePasiv;
        private System.Windows.Forms.Button deleteActiv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}