using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai16_FormatTextt
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fomatTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormatText formatText = new FormatText();
            formatText.MdiParent = this;
            formatText.Show();
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 AboutBox1 = new AboutBox1();
           AboutBox1.MdiParent = this;
           AboutBox1.Show();
        }
    }
}
