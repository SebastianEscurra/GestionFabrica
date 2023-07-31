using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;


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
    static public class HelpGrid
    {
        
        static public void mostrarGrid(DataGridView grid,List<Insumo> listaInsumo)
        {
            grid.DataSource = listaInsumo;
            grid.Columns["Id"].Visible = false;
        }
    }
}
