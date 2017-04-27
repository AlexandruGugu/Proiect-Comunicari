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
            this.addPasiv.Text = "Add";
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
            this.addActiv.Location = new System.Drawing.Point(538, 430);
            this.addActiv.Name = "addActiv";
            this.addActiv.Size = new System.Drawing.Size(75, 23);
            this.addActiv.TabIndex = 9;
            this.addActiv.Text = "Add";
            this.addActiv.UseVisualStyleBackColor = true;
            this.addActiv.Click += new System.EventHandler(this.addActiv_Click);
            // 
            // deletePasiv
            // 
            this.deletePasiv.Location = new System.Drawing.Point(1201, 226);
            this.deletePasiv.Name = "deletePasiv";
            this.deletePasiv.Size = new System.Drawing.Size(75, 23);
            this.deletePasiv.TabIndex = 10;
            this.deletePasiv.Text = "Delete";
            this.deletePasiv.UseVisualStyleBackColor = true;
            this.deletePasiv.Click += new System.EventHandler(this.deletePasiv_Click);
            // 
            // deleteActiv
            // 
            this.deleteActiv.Location = new System.Drawing.Point(87, 226);
            this.deleteActiv.Name = "deleteActiv";
            this.deleteActiv.Size = new System.Drawing.Size(75, 23);
            this.deleteActiv.TabIndex = 11;
            this.deleteActiv.Text = "Delete";
            this.deleteActiv.UseVisualStyleBackColor = true;
            this.deleteActiv.Click += new System.EventHandler(this.deleteActiv_Click);
            // 
            // ConturiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1437, 603);
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
    }
}