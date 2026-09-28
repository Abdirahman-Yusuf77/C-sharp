using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //create variable
            String First_name, Second_name, Full_Name;
            // initialization
            First_name = txt_firstname.Text;
            Second_name = txt_secondname.Text;
            // concatination process using + operator
            Full_Name = First_name + Second_name;
            // dDisplay output usnig label output
            lbl_output.Text = Full_Name;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            // clear textbox using clear function
            txt_firstname.Clear();
            txt_secondname.Text = " ";
            lbl_output.Text = "";
        }

        private void txt_secondname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
