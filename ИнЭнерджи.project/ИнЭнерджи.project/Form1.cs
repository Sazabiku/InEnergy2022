using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ИнЭнерджи.project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       /* private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Owner = this;
            form2.Show();
            this.Hide();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*Form3 form3 = new Form3();
            form3.Show();
            this.Close();
        }*/

        /*private void литийИонныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form[] form = MdiChildren;
            foreach (Form fr in form)
                fr.Close();
            Form2 form2 = new Form2();
            form2.MdiParent = this;
            form2.Show();
        }*/

        private void натрийИонныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form[] form = MdiChildren;
            foreach (Form fr in form)
                fr.Close();
            Form3 form3 = new Form3();
            form3.MdiParent = this;
            form3.Show();
        }

        private void литийИонныеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form[] form = MdiChildren;
            foreach (Form fr in form)
                fr.Close();
            Form4 form4 = new Form4();
            form4.MdiParent = this;
            form4.Show();
        }

        /*private void натрийИонныеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form[] form = MdiChildren;
            foreach (Form fr in form)
                fr.Close();
            Form5 form5 = new Form5();
            form5.MdiParent = this;
            form5.Show();
        }*/

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is MdiClient)
                {
                    control.BackColor = Color.FromArgb(240,240,240);
                    break;
                }
            }
        }

        private void модельПотребленияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form[] form = MdiChildren;
            foreach (Form fr in form)
                fr.Close();
            Form2 form2 = new Form2();
            form2.MdiParent = this;
            form2.Show();
        }

        private void натрийИонныеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form[] form = MdiChildren;
            foreach (Form fr in form)
                fr.Close();
            Form6 form6 = new Form6();
            form6.MdiParent = this;
            form6.Show();
        }
    }
}
