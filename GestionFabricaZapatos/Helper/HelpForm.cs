﻿using System;
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
        static public void mostrarGridInsumos(DataGridView grid, List<Insumo> listaInsumos)
        {
            grid.DataSource = listaInsumos;
            grid.Columns["Id"].Visible = false;
            grid.Columns["CantidadInsumosParaArmado"].Visible = false;
            grid.Columns["PrecioUnidad"].Visible = false;
            grid.Columns["UrlImagen"].Visible = false;

        }

        static public void mostrarGrid(DataGridView grid,List<Insumo> listaInsumos)
        {
            grid.DataSource = listaInsumos;
            grid.Columns["Id"].Visible = false;
            grid.Columns["Cantidad"].Visible = false;
            grid.Columns["PrecioBruto"].Visible = false;

        }
        static public void mostrarGrid(DataGridView grid,List<Articulo> listaArticulos)
        {
            grid.DataSource = listaArticulos;
            grid.Columns["Id"].Visible = false;
            grid.Columns["Activo"].Visible = false;
        }
        static public void mostrarGrid(DataGridView grid, List<RelacionSucursalArticulo> listaRelacionSucursalarticulo)
        {
            grid.DataSource = listaRelacionSucursalarticulo;
            grid.Columns["Id"].Visible = false;
        }
        static public void mostrarGrid(DataGridView grid, List<RelacionArticuloInsumo> listaRelacionArticuloInsumo)
        {
            grid.DataSource = listaRelacionArticuloInsumo;
            grid.Columns["Id"].Visible = false;
            grid.Columns["IdArticulo"].Visible = false;
            grid.Columns["IdInsumo"].Visible = false;
            grid.Columns["Articulo"].Visible = false;
        }
        static public void mostrarGrid(DataGridView grid, List<RelacionSucursal_Insumo> listaRelacionSucursalInsumo)
        {
            grid.DataSource = listaRelacionSucursalInsumo;
            grid.Columns["Id"].Visible = false;
           
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
                pbx.Load("https://aeroclub-issoire.fr/wp-content/uploads/2020/05/image-not-found.jpg");
            }
        }
    }
}
