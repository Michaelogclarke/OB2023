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
    
    public partial class frmCeist3 : Form
    {
        System.Media.SoundPlayer player;
        
        public Imreoir im;
        public frmCeist3(ref Imreoir imreoir)
        {
            InitializeComponent();
            this.im = imreoir;
            label2.Text = im.Scor.ToString();

        }

        public void Music_Click(object sender, EventArgs e)
        {
            

            player = new System.Media.SoundPlayer("CertainRomance.wav");
            
            player.Play();
            
        }


        private void frmCeist3_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
            timer1.Interval = 1000;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            player = new System.Media.SoundPlayer("CertainRomance.wav");

            player.Stop();
            player.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_MouseDown(object sender, MouseEventArgs e)
        {
            button4.DoDragDrop(button4.Text, DragDropEffects.Copy);
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void button4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_DragDrop(object sender, DragEventArgs e)
        {
            textBox1.Text = e.Data.GetData(DataFormats.Text).ToString();
        }

        private void textBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void button3_DragDrop(object sender, DragEventArgs e)
        {
           
        }

        private void button3_DragEnter(object sender, DragEventArgs e)
        {
          
        }

        private void button3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            button3.DoDragDrop(button3.Text, DragDropEffects.Copy);
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            button2.DoDragDrop(button2.Text, DragDropEffects.Copy);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "A Certain Romance")
            {
                im.Scor += 100;
                im.Scor += Convert.ToInt32(lblAm.Text);
                Form clar = new frmCeist4(ref im);
                clar.Show();
                this.Hide();
            }
            else
            {

                pictureBox1.Image = Resources.sad_ye;
                MessageBox.Show("WRONG!!");
                Form clar = new frmCeist4(ref im);
                clar.Show();
                this.Hide();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
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

        private void button5_Click(object sender, EventArgs e)
        {
            im.Scor -= 100;
            im.Scor += Convert.ToInt32(lblAm.Text);
            Form clar = new frmCeist4(ref im);
            clar.Show();
            this.Hide();
        }
    }
}
