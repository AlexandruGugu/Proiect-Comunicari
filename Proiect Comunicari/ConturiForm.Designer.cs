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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.addPasiv = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.activID = new System.Windows.Forms.TextBox();
            this.pasivValoare = new System.Windows.Forms.TextBox();
            this.activValoare = new System.Windows.Forms.TextBox();
            this.pasivID = new System.Windows.Forms.TextBox();
            this.addActiv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(168, 63);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(445, 342);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(750, 63);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(445, 342);
            this.listBox2.TabIndex = 1;
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
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(645, 539);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 27);
            this.button2.TabIndex = 4;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
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
            // 
            // ConturiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1437, 603);
            this.Controls.Add(this.addActiv);
            this.Controls.Add(this.pasivID);
            this.Controls.Add(this.activValoare);
            this.Controls.Add(this.pasivValoare);
            this.Controls.Add(this.activID);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addPasiv);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "ConturiForm";
            this.Text = "ConturiForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConturiForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button addPasiv;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox activID;
        private System.Windows.Forms.TextBox pasivValoare;
        private System.Windows.Forms.TextBox activValoare;
        private System.Windows.Forms.TextBox pasivID;
        private System.Windows.Forms.Button addActiv;
    }
}