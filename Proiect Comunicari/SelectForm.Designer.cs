namespace Proiect_Comunicari
{
    partial class SelectForm
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
            this.addPrj.Location = new System.Drawing.Point(381, 344);
            this.addPrj.Name = "addPrj";
            this.addPrj.Size = new System.Drawing.Size(107, 21);
            this.addPrj.TabIndex = 1;
            this.addPrj.Text = "New";
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
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 498);
            this.Controls.Add(this.openOp);
            this.Controls.Add(this.openConturi);
            this.Controls.Add(this.addPrj);
            this.Controls.Add(this.listBox1);
            this.Name = "SelectForm";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SelectForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button addPrj;
        private System.Windows.Forms.Button openConturi;
        private System.Windows.Forms.Button openOp;
    }
}