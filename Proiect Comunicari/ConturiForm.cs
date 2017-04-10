using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_Comunicari
{
    public partial class ConturiForm : Form
    {
        public Proiect proiect;
        public ConturiForm(Proiect prj)
        {
            InitializeComponent();
            proiect = prj;
        }
    }
}
