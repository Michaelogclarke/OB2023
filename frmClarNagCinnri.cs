using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Obair_Chursa_2022
{
    public partial class frmClarNagCinnri : Form
    {
        Imreoir im;
        public frmClarNagCinnri(ref Imreoir imreoir)
        { this.im = imreoir;
            InitializeComponent();
           
        }

        

        private void frmClarNagCinnri_Load(object sender, EventArgs e)
        {
            
            List<Imreoir> LiostaImreoiri = new List<Imreoir>();
            LiostaImreoiri.Add(new Imreoir("Michaelog", "password1@", 564));
            LiostaImreoiri.Add(new Imreoir("Voipfr", "password2", 999999999));
            LiostaImreoiri.Add(new Imreoir("Caolan", "password3", 534));
            LiostaImreoiri.Add(new Imreoir("Cathal", "password4", 124));
            LiostaImreoiri.Add(im);
            LiostaImreoiri.Sort();
            foreach (Imreoir imreoir in LiostaImreoiri)
            {
                listBox1.Items.Add(imreoir.UserName+ ":" + imreoir.Scor);
                
            }


            SeolImreoirGoBinComhad();
            foreach (Imreoir i in Program.BailighImreoiri())
            {
                listBox1.Items.Add(i.UserName + "::" + i.Scor);
            }
        }
        
        public void SeolImreoirGoBinComhad()
        {
            Imreoir[] naHimreoiri = new Imreoir[1];
            naHimreoiri[0] = im;
            Stream sw;
            BinaryFormatter bf = new BinaryFormatter();
            try
            {
                sw = File.Open("imreoiri.bin", FileMode.Create);
                bf.Serialize(sw, naHimreoiri);
                sw.Dispose();
                sw.Close();
            }
            catch (SerializationException s)
            {
                lblEarraidi.Text = s.Message;
            }
            catch (IOException i)
            {
                lblEarraidi.Text = i.Message;

            }
            catch (Exception ex)
            {
                lblEarraidi.Text = ex.Message;

                 
            }
            finally
            {
                

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
