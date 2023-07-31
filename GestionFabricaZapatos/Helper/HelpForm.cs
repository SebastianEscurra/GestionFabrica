using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Helper
{
    static public class HelpForm   
    {
        static public void abrirFormHijo(Panel panelPrincipal,object frmHijo)
        {
            if (panelPrincipal.Controls.Count > 0)
            {
                panelPrincipal.Controls.Clear();
            }
            Form fr = (Form)frmHijo;
            fr.TopLevel = false;
            fr.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(fr);
            panelPrincipal.Tag = frmHijo;
            fr.Show();
        }
    }
}
