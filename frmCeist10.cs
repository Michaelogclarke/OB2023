using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Obair_Chursa_2022.Properties;

namespace Obair_Chursa_2022
{
    public partial class frmCeist10 : Form
    {
        public Imreoir im;
        public frmCeist10(ref Imreoir imreoir)
        {
            this.im = imreoir;
            InitializeComponent();
            
            this.im = imreoir;
            label2.Text = im.Scor.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rb2.Checked == true)
            {
                im.Scor += 100;
                im.Scor += Convert.ToInt32(lblAm.Text);

                //pictureBox1.Image = Resources.Adele_thumbs_up;
                Form clar = new frmClarNagCinnri(ref im);
                clar.Show();
                this.Hide();
            }
            else
            {
                pictureBox1.Image = Resources.Sad_joe;
                MessageBox.Show("WRONG!!");
                Form clar = new frmClarNagCinnri(ref im);
                clar.Show();
                this.Hide();
            }
        }

        private void frmCeist10_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
            timer1.Interval = 1000;
        }

        private void rb2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lblAm.Text) > 0)
            {
                lblAm.Text = Convert.ToString(Convert.ToInt32(lblAm.Text) - 1);

            }
            else
            {

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblAm_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            im.Scor -= 100;
            im.Scor += Convert.ToInt32(lblAm.Text);
            Form clar = new frmClarNagCinnri(ref im);
            clar.Show();
            this.Hide();
        }
    }
}
