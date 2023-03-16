﻿using System;
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
    public partial class frmCeist6 : Form
    {
        public Imreoir im;
        public frmCeist6(ref Imreoir imreoir)
        {
            InitializeComponent();
            this.im = imreoir;
            label2.Text = im.Scor.ToString();


        }

        private void rb2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (rb1.Checked == true)
            {
                im.Scor += 100;
                im.Scor += Convert.ToInt32(lblAm.Text);
                pictureBox1.Image = Resources.Adele_thumbs_up;
                Form clar = new frmCeist7(ref im);
                clar.Show();
                this.Hide();
            }
            else
            {
                pictureBox1.Image = Resources.x;
                MessageBox.Show("WRONG!!");
                Form clar = new frmCeist7(ref im);
                clar.Show();
                this.Hide();
            }
        }

        private void frmCeist6_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
            timer1.Interval = 1000;
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

        private void button6_Click(object sender, EventArgs e)
        {
            im.Scor -= 100;
            im.Scor += Convert.ToInt32(lblAm.Text);
            Form clar = new frmCeist7(ref im);
            clar.Show();
            this.Hide();
        }
    }
}
