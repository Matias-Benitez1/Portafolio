using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoOra
{
    class Validar
    {
        public static void SoloLetras(KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else 
            {
                e.Handled = true;
                MessageBox.Show("Se permite solo Letras");
            }
        }
        public static void Letrasynumeros(KeyPressEventArgs pE)
        {
            
                if (Char.IsLetter(pE.KeyChar))
                {
                    pE.Handled = false;
                }
                else if (Char.IsDigit(pE.KeyChar))
                {
                    pE.Handled = false;
                }
                else if (Char.IsControl(pE.KeyChar))
                {
                    pE.Handled = false;
                }
                else if (Char.IsSeparator(pE.KeyChar))
                {
                    pE.Handled = false;
                }
                else
                {
                    pE.Handled = true;
                MessageBox.Show("Solo Letras y Numeros");
                }            
        }
        public static void SoloNumeros(KeyPressEventArgs v)
        {
            if (Char.IsDigit(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsSeparator(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
            else 
            {
                v.Handled = true;
                MessageBox.Show("Solo Numeros");
            }
        }
    }
}
