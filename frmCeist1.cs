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
    public partial class frmCeist1 : Form
    {
        public Imreoir im;
        public frmCeist1(ref Imreoir imreoir)
        {
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            InitializeComponent();
            this.im = imreoir;
            label3.Text = im.Scor.ToString();
        }

        private void frmCeist1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
            timer1.Interval = 1000;
            
          
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Question_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rb1.Checked == true)
            {
                im.Scor += 100;
                im.Scor += Convert.ToInt32(lblAm.Text);
                pictureBox1.Image = Resources.Adele_thumbs_up;
                Form clar = new frmCeist2(ref im);
                clar.Show();
                this.Hide();
            }
            else
            {
                pictureBox1.Image = Resources.x;
                MessageBox.Show("WRONG!!");
                Form clar = new frmCeist2(ref im);
                clar.Show();
                this.Hide();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lblAm.Text)>0)
            {
                lblAm.Text = Convert.ToString(Convert.ToInt32(lblAm.Text) - 1);

            }
            else
            {
                timer1.Stop();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblAm_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            im.Scor -= 100;
            im.Scor += Convert.ToInt32(lblAm.Text);
            Form clar = new frmCeist2(ref im);
            clar.Show();
            this.Hide();
        }
    }
}
