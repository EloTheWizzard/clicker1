using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseClicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int i = 0;
        private void Click_Click(object sender, EventArgs e)
        {
            if (i == 10)
            {
                MessageBox.Show("Уровень один пройден!");
                lvl1.Visible = false;
                //vistest.Visible = true;
            }
            i++;
         
            if (i == 11)
            {
                i = 0;
                lvl2.Visible = true;
            }
            numcl.Text = i.ToString() + ;
        }//lvl1 
        private string d (int i)
        {
            if (i == 2 || i == 3 || i == 4)
            {
                return " раза";
            }
            return " раз";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lvl2.Visible = false;
            lvl2.Text = "NOW KILL ME!";
            lvl1.Text = "KILL ME";
            numcl.Text = "-";
            label1.Visible = false;
        }//visible or un (names text and aner)

        private void vistest_Click(object sender, EventArgs e)
        {           
                i++;
                numcl.Text = i.ToString();
            if (i == 20)
            {
                MessageBox.Show("Уровень два пройден!");
                lvl2.Visible = false;
                lvl1.Visible = false;
                numcl.Text = "крч хз, досвидания, блин.."; //шедевр просто..
            }
        }//lvl2 testver

        //private void label1_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show("Nothing");
        //}
    }
}