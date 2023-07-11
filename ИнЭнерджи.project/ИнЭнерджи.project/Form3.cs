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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            //pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

       

       

        private void button3_Click(object sender, EventArgs e)
        {
            Form[] form = Parent.FindForm().MdiChildren;
            foreach (Form fr in form)
                fr.Close();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureBox2_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            //pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
    
}
