using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Aula08Estoque
{
    internal class Utilidades
    {

        public void mostraMensagem()
        {

            MessageBox.Show(" Oii sumido:");





        }
        public bool textBoxEstaVazio( TextBox txt )
        {
            if( txt.Text == "")
            {

                return true;

            }
            else
            {

                return false;

            }
        }

        public bool txtVazio( TextBox txtvazio)
        {



            if (txtvazio.Text == "")
            {

                return true;

            }
            else
            {

                return false;

            }




        }


    }
}
