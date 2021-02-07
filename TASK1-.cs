using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_PoundstoKilo
{
    public partial class Form1 : Form
    {
        double Lbs, Kg;
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Form1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double pounds = (double)numericUpDown2.Value;
            double Answer = pounds * 0.453592;
            label4.Text = Answer.ToString() + "kgs";

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double kgs = (double)numericUpDown1.Value;
            double Answer2 = kgs * 2.20462;
            label4.Text = Answer2.ToString() + "pounds";
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            numericUpDown2.Value = 0;
            numericUpDown1.Value = 0;
            label4.Text = "Answer";
        }
        }
    }

