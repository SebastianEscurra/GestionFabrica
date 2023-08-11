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
        static public Form abrirFormHijo(Panel panelPrincipal,Form frmHijo)
        {

               //if (panelPrincipal.Controls.Count > 0)
               //    panelPrincipal.Controls.Clear();


            frmHijo.TopLevel = false;
            frmHijo.FormBorderStyle = FormBorderStyle.None;
            frmHijo.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(frmHijo);
            panelPrincipal.Tag = frmHijo;
            frmHijo.Show();
            frmHijo.BringToFront();
            return frmHijo;

        }
    }
    static public class HelpGrid
    {
        
        static public void mostrarGrid(DataGridView grid,List<Insumo> listaInsumos)
        {
            grid.DataSource = listaInsumos;
            grid.Columns["Id"].Visible = false;
        }
        static public void mostrarGrid(DataGridView grid,List<Articulo> listaArticulos)
        {
            grid.DataSource = listaArticulos;
            grid.Columns["Id"].Visible = false;
            grid.Columns["Activo"].Visible = false;

        }
    }
    static public class HelpPicture
    {
        static public void cargarImagen(PictureBox pbx,string urlImagen)
        {
            try
            {
                pbx.Load(urlImagen);
            }
            catch (Exception)
            {
                pbx.Load("https://cdn-icons-png.flaticon.com/512/126/126472.png");
            }
        }
    }
}
