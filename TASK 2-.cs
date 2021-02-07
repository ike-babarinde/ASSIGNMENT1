using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordCount
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string ch, temp, str;
            int len, Count,i;
            str = txtString.Text;
            len = str.Length;
            Count = 0;
            temp = String.Empty;
            for (i = 0; i < len; i++)
            {
                ch = str.Substring(i, 1);
                if(ch!=" ")
                {
                    temp = temp + ch;
                   

                }
                if(ch==" "|| i == len - 1)
                {
                    if (temp.Length > 0)
                    {
                        Count+=1;
                        temp = "";
                       

                    }
                }
            }
            txtCount.Text = Count.ToString();
        }

        private void txtString_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            /*string help;
            help=txtString.Text;
            textBox1.Text = help.ToString();*/
        }

        private void txtCount_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string help;
            help = txtString.Text;
            textBox1.Text = help.ToString();
        }
    }
}
