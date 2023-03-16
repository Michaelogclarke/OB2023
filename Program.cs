using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Drawing.Text;
using System.Drawing;

namespace Obair_Chursa_2022
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
            IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private static PrivateFontCollection fonts = new PrivateFontCollection();

        
        [STAThread]
        static void Main()
        {
            Imreoir d = new Imreoir("s", "s", 1);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmSplashScreen(d));
           

        }
        public static Imreoir[] BailighImreoiri()
        {
            Stream sr;
            BinaryFormatter bf1 = new BinaryFormatter();
            //léigh ón nin comhad
            try
            {
                Imreoir[] SeanIms;
                sr = File.OpenRead("imreoiri.bin");
                SeanIms = (Imreoir[])bf1.Deserialize(sr);
                sr.Close();
                return SeanIms;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        public static void SeolImreoir(Imreoir ImNua)
        {
            Stream sr;
            BinaryFormatter bf1 = new BinaryFormatter();
            //scríobh go comhad
            try
            {
                Imreoir[] ImreoirNua = new Imreoir[1];
                ImreoirNua[0] = ImNua;
                //an ndéanfaidh Create, Create & append?
                sr = File.Open("imreoiri.bin", FileMode.Create);
                bf1.Serialize(sr, ImreoirNua);
                sr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}
