using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Obair_Chursa_2022
{
    public partial class frmSplashScreen : Form
    {
        public Imreoir im;
        public frmSplashScreen(Imreoir im)
        {

            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        
        public bool passOK = false;
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.TextLength < 5)
            {
                lblEarraidi.ForeColor = Color.Red;
                lblEarraidi.Text = "Caithfidh Pass bheith níos mó na 4 caractar";
                lblEarraidi.Visible = true;
            }
            else
            {
                passOK = true;
                lblEarraidi.Text = string.Empty;
            }
        }
        public bool ainmOK = false;
        private void txtAinmUsaideora_TextChanged(object sender, EventArgs e)
        {
            if (txtAinmUsaideora.TextLength < 7)
            {
                lblEarraidi.ForeColor = Color.Red;
                lblEarraidi.Text = "Caithfidh Ainm bheith níos mó na 6 caractar";

                lblEarraidi.Visible = true;
            }
            else
            {
                ainmOK = true;
                lblEarraidi.Visible = false;
            }
        }

        private void FrmSplashScreen_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //má tá an téacsbhosca folamh beidh, beidh teachtaireacht
            //scríobh sonraí
            if (txtAinmUsaideora.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Caithfidh tú sonraí a scríobh LDT!!!!");
            }
            //nó   má tá login ceart, teachtaireacht ceadaithe        

            else if (txtAinmUsaideora.Text == "ainm@gmail.com" && textBox2.Text == "password1")
            {
                MessageBox.Show("Sonraí Céadaithe");

               
               

            }
            else if (passOK) 
            {
                //dean imreoir nua
                Imreoir newplayer = new Imreoir(txtAinmUsaideora.Text, textBox2.Text, 0);
                //seol chuig an storas
                Program.SeolImreoir(newplayer);
                //bailigh iad uilig
                Imreoir[] ImreoiriUilig = Program.BailighImreoiri(); Form frm1 = new frmCeist1(ref newplayer);
                //oscail foirm eile
                //má tá Pasfhocal nó Ainm Úsáideora mícheart, teachtaireacht agus glan na téacsbhoscaí
                MessageBox.Show("Failte");
                txtAinmUsaideora.Text = "";
                textBox2.Text = "";
                frm1.Show();
                this.Hide();
            }
            


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtAinmUsaideora.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Caithfidh tú sonraí a scríobh LDT!!!!");
            }
            else
            {
                MessageBox.Show("Tá tú cláraithe");
                Imreoir imreoirnua = new Imreoir(txtAinmUsaideora.Text, textBox2.Text, 0);

            }
        }
    }
}
