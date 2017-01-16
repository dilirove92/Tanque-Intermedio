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
    public class DetalleFacturaClass
    {
        BD_DespTanqInteEntities conexion { get; set; }
        BD_DespTanqInteEntities BD = new BD_DespTanqInteEntities();

        public int NumFactura { get; set; }
        public int NumControl { get; set; }
        public DateTime FechEmision { get; set; }
        public DateTime FechFact { get; set; }
        public string CedRucClie { get; set; }
        public string PlacaTanquero { get; set; }
        public int MetCubFact { get; set; }
        public decimal valorCancelado { get; set; }


        public DetalleFacturaClass()
        {
            conexion = new BD_DespTanqInteEntities();
        }

        public void new_detalleFactura(DetalleFacturaClass DF)
        {
            DetalleFactura tabla = new DetalleFactura();
            try
            {
                tabla.NumFactura = DF.NumFactura;
                tabla.NumControl = DF.NumControl;
                tabla.FechEmision = DF.FechEmision;
                tabla.FechFact = DF.FechFact;
                tabla.CedRucClie = DF.CedRucClie;
                tabla.PlacaTanquero = DF.PlacaTanquero;
                tabla.MetrosCubicosFacturados = DF.MetCubFact;
                tabla.ValorCancelado = DF.valorCancelado;
                BD.AddToDetalleFacturas(tabla);
                BD.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void delete_DetalleFactura(int Num_Fac)
        {
            try
            {
                DetalleFactura tabla = new DetalleFactura();
                tabla = (from a in BD.DetalleFacturas
                         where a.NumFactura == Num_Fac
                         select a).FirstOrDefault();
                BD.DeleteObject(tabla);
                BD.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void update_DetalleFactura(int NumeroFact, int NumeroControl, DateTime FechaEmision,
                                        DateTime FechaFactura, string CedulaCliente, string PlacaT,
                                        int MetCubFact, decimal ValorCance)
        {
            try
            {
                DetalleFactura tabla = new DetalleFactura();
                tabla = (from a in BD.DetalleFacturas
                         where a.NumFactura == NumeroFact
                         select a).FirstOrDefault();
                tabla.NumControl = NumeroControl;
                tabla.FechEmision = FechaEmision;
                tabla.FechFact = FechaFactura;
                tabla.CedRucClie = CedulaCliente;
                tabla.PlacaTanquero = PlacaT;
                tabla.MetrosCubicosFacturados = MetCubFact;
                tabla.ValorCancelado = ValorCance;
                BD.Refresh(System.Data.Objects.RefreshMode.ClientWins, tabla);
                BD.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool consulta_Factura(int Num_Fact)
        {
            DetalleFactura tabla = BD.DetalleFacturas.FirstOrDefault(a => a.NumFactura == Num_Fact);
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


        public DetalleFacturaClass find_Factura(int Numero_Factura)
        {
            DetalleFacturaClass FacturaDatos = new DetalleFacturaClass();

            try
            {
                DetalleFactura tabla = new DetalleFactura();
                tabla = (from a in BD.DetalleFacturas
                         where a.NumFactura == Numero_Factura
                         select a).FirstOrDefault();
                FacturaDatos.NumFactura = tabla.NumFactura;
                FacturaDatos.NumControl = tabla.NumControl;
                FacturaDatos.FechEmision = tabla.FechEmision;
                FacturaDatos.FechFact = tabla.FechFact;
                FacturaDatos.CedRucClie = tabla.CedRucClie;
                FacturaDatos.PlacaTanquero = tabla.PlacaTanquero;
                FacturaDatos.MetCubFact = tabla.MetrosCubicosFacturados;
                FacturaDatos.valorCancelado = tabla.ValorCancelado;

                return FacturaDatos;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

    }
}