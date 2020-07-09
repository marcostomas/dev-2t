using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taskool
{
    class Utils
    {
        public static bool temCamposVazio(Form form)
        {
            //Varrer os obj do formulário
            foreach(Control c in form.Controls)
            {
                //Guardar as caixas de texto
                TextBox tbx = c as TextBox;

                //Verifica se estão preenchidas
                if(tbx != null && tbx.Text.Trim().Length == 0)
                {
                    //Retorna que tem campos vazios
                    return true;
                }
            }

            //Retorna que não tem campos vazios
            return false;
        }
    }
}
