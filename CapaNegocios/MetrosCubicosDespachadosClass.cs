using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProyectoTanqueIntermedioEpam.CapaDatos;
using System.Windows.Forms;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoTanqueIntermedioEpam.CapaNegocios
{
    public class MetrosCubicosDespachadosClass
    {
        BD_DespTanqInteEntities conexion { get; set; }
        BD_DespTanqInteEntities BD = new BD_DespTanqInteEntities();

        public int NumGuia { get; set; }
        public int NumFactura { get; set; }
        public int MCDespachados { get; set; }
        public int MCSobrantes { get; set; }

        public MetrosCubicosDespachadosClass()
        {
            conexion = new BD_DespTanqInteEntities();
        }

        public void new_MCDespachados(MetrosCubicosDespachadosClass MCD)
        {
            MetrosCubicosDepachado tabla = new MetrosCubicosDepachado();
            try
            {
                tabla.ReferRemis = MCD.NumGuia;
                tabla.NumFactura = MCD.NumFactura;
                tabla.MetrCubiDesp = MCD.MCDespachados;
                tabla.MetrCubiSobr = MCD.MCSobrantes;
                BD.AddToMetrosCubicosDepachados(tabla);
                BD.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void update_MCDespachados(int NumGuia, int NumFactura, int MDespachados, int MSobrantes)
        {
            try
            {
                MetrosCubicosDepachado tabla = new MetrosCubicosDepachado();
                tabla = (from a in BD.MetrosCubicosDepachados
                         where a.ReferRemis == NumGuia
                         select a).FirstOrDefault();
                tabla.NumFactura = NumFactura;
                tabla.MetrCubiDesp = MDespachados;
                tabla.MetrCubiSobr = MSobrantes;
                BD.Refresh(System.Data.Objects.RefreshMode.ClientWins, tabla);
                BD.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool consulta_MCD(int Num_Guia)
        {
            MetrosCubicosDepachado tabla = BD.MetrosCubicosDepachados.FirstOrDefault(a => a.ReferRemis == Num_Guia);
            try
            {
                if (!tabla.Equals(null))
                {
                    return true;
                }
            }
            catch (Exception)
            { }
            return false;
        }


        public MetrosCubicosDespachadosClass find_MCD(int Numero_Guia)
        {
            MetrosCubicosDespachadosClass MCDDatos = new MetrosCubicosDespachadosClass();

            try
            {
                MetrosCubicosDepachado tabla = new MetrosCubicosDepachado();
                tabla = (from a in BD.MetrosCubicosDepachados
                         where a.ReferRemis == Numero_Guia
                         select a).FirstOrDefault();
                MCDDatos.NumGuia = tabla.ReferRemis;
                MCDDatos.NumFactura = tabla.NumFactura;
                MCDDatos.MCDespachados = tabla.MetrCubiDesp;
                MCDDatos.MCSobrantes = tabla.MetrCubiSobr;
                return MCDDatos;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public void delete_MCDespachados(int NumeroGuia)
        {
            try
            {
                MetrosCubicosDepachado tabla = new MetrosCubicosDepachado();
                tabla = (from a in BD.MetrosCubicosDepachados
                         where a.ReferRemis == NumeroGuia
                         select a).FirstOrDefault();
                BD.DeleteObject(tabla);
                BD.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public int devolver_Sobrante(int NumFactura)
        {
            int suma = 0;

            foreach (var item in BD.MetrosCubicosDepachados)
            {
                MetrosCubicosDespachadosClass MetrosC = new MetrosCubicosDespachadosClass();
                MetrosC.NumFactura = item.NumFactura;
                MetrosC.MCDespachados = item.MetrCubiDesp;
                if (MetrosC.NumFactura == NumFactura)
                    suma += MetrosC.MCDespachados;
            }
            return suma;
        }
    }
}
