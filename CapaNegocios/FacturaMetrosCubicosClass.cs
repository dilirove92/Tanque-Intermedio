using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DespachoTanqueIntermedio.CapaDatos;
using System.Windows.Forms;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DespachoTanqueIntermedio.CapaNegocios
{
    public class FacturaMetrosCubicosClass
    {
        BD_DespTanqInterEntities1 conexion { get; set; }
        BD_DespTanqInterEntities1 BD = new BD_DespTanqInterEntities1();

        public int NumeFactura { get; set; }
        public int MetrosCFacturados { get; set; }
        public int MetrosCDespachados { get; set; }
        public int MetrosCSobrantes{ get; set; }
        public decimal valorCancelado { get; set; }

        public FacturaMetrosCubicosClass() 
        {
            conexion = new BD_DespTanqInterEntities1();
        }

        public void new_FacturaMetrosC(FacturaMetrosCubicosClass FMC)
        {
            FacturaMetrosCubico tabla = new FacturaMetrosCubico();
            try
            {
                tabla.NumFactura = FMC.NumeFactura;
                tabla.MetrCubiFact = FMC.MetrosCFacturados;
                tabla.MetrCubiDesp= FMC.MetrosCDespachados;
                tabla.MetrCubiSobr = FMC.MetrosCSobrantes;
                tabla.ValorCancelado = FMC.valorCancelado;
                BD.AddToFacturaMetrosCubicos(tabla);
                BD.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void update_FacturaMetrosC(int NumFact, int MCFacturados, int MCDespachados,
                                           int MCSobrantes, decimal valorCancel)
        {
            try
            {
                FacturaMetrosCubico tabla = new FacturaMetrosCubico();
                tabla = (from a in BD.FacturaMetrosCubicos
                         where a.NumFactura == NumFact
                         select a).FirstOrDefault();
                tabla.MetrCubiFact = MCFacturados;
                tabla.MetrCubiDesp= MCDespachados;
                tabla.MetrCubiSobr = MCSobrantes;
                tabla.ValorCancelado = valorCancelado;
                BD.Refresh(System.Data.Objects.RefreshMode.ClientWins, tabla);
                BD.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool consulta_FMC(int Num_Factura)
        {
            FacturaMetrosCubico tabla = BD.FacturaMetrosCubicos.FirstOrDefault(a => a.NumFactura == Num_Factura);
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


        public FacturaMetrosCubicosClass find_FMC(int Numero_Factura)
        {
            FacturaMetrosCubicosClass FMCDatos = new FacturaMetrosCubicosClass();

            try
            {
                FacturaMetrosCubico tabla = new FacturaMetrosCubico();
                tabla = (from a in BD.FacturaMetrosCubicos
                         where a.NumFactura == Numero_Factura
                         select a).FirstOrDefault();
                FMCDatos.NumeFactura = tabla.NumFactura;
                FMCDatos.MetrosCFacturados = tabla.MetrCubiFact;
                FMCDatos.MetrosCDespachados= tabla.MetrCubiDesp;
                FMCDatos.MetrosCSobrantes = tabla.MetrCubiSobr;
                FMCDatos.valorCancelado = tabla.ValorCancelado;
                return FMCDatos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public void delete_FacturaMetrosC(int num_fac)
        {
            try
            {
                FacturaMetrosCubico tabla = new FacturaMetrosCubico();
                tabla = (from a in BD.FacturaMetrosCubicos
                         where a.NumFactura == num_fac
                         select a).FirstOrDefault();
                BD.DeleteObject(tabla);
                BD.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
