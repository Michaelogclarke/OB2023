using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obair_Chursa_2022
{
    [Serializable]
    public class Imreoir:IComparable<Imreoir>
    {
       public int CompareTo(Imreoir x)
        {
            if (this.Scor>x.Scor)
            {
                return -1;
            }
            if (this.Scor<x.Scor)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        private string userName;

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        private string pasfhocal;

        public string Pasfhocal
        {
            get { return pasfhocal; }
            set { pasfhocal = value; }
        }
        private int scor;
        private string text1;
        private string text2;
        private string text3;

        public int Scor
        {
            get { return scor; }
            set { scor = value; }
        }

        //constructor 
        public Imreoir(string u, string p, int s)
        {
            this.Pasfhocal = p;
            this.UserName = u;
            this.scor = s;
        }

        public Imreoir(string text1, string text2, string text3)
        {
            this.text1 = text1;
            this.text2 = text2;
            this.text3 = text3;
        }

        public string CurSiosArImreoir()
        {
            return "Tá an usáideoir " + UserName + " agus scór " + Scor;
        }
    } 
}
