﻿using System;
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
    public partial class FormatText: Form
    {
        public FormatText()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lbl.ForeColor = Color.Red;
            txtNhapTen.ForeColor = Color.Red;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            lbl.ForeColor = Color.Blue;
            txtNhapTen.ForeColor = Color.Blue;
        }

        private void FormatText_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Font = new Font(lblLapTrinh.Font.Name, lbl.Font.Size, lblLapTrinh.Font.Style ^ FontStyle.Bold);
           txtNhapTen.Font = new Font(txtNhapTen.Font.Name, txtNhapTen.Font.Size, txtNhapTen.Font.Style ^ FontStyle.Bold);
        }

        private void radDreen_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.ForeColor = Color.Green;
            txtNhapTen.ForeColor = Color.Green;
        }

        private void radBlack_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.ForeColor = Color.Black;
            txtNhapTen.ForeColor = Color.Black;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Font = new Font(lblLapTrinh.Font.Name, lblLapTrinh.Font.Size, lblLapTrinh.Font.Style ^ FontStyle.Italic);
            txtNhapTen.Font = new Font(txtNhapTen.Font.Name, txtNhapTen.Font.Size, txtNhapTen.Font.Style ^ FontStyle.Italic);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Font = new Font(lblLapTrinh.Font.Name, lblLapTrinh.Font.Size, lblLapTrinh.Font.Style ^ FontStyle.Underline);
            txtNhapTen.Font = new Font(txtNhapTen.Font.Name, txtNhapTen.Font.Size, txtNhapTen.Font.Style ^ FontStyle.Underline);
        }

        private void lblLapTrinh_Click(object sender, EventArgs e)
        {

        }
    }
}
