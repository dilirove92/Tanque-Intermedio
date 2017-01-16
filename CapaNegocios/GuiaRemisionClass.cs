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
    public class GuiaRemisionClass
    {
        BD_DespTanqInteEntities conexion { get; set; }
        BD_DespTanqInteEntities BD = new BD_DespTanqInteEntities();

        public int GuiaRemision { get; set; }
        public int NumeFactura { get; set; }
        public DateTime FechIniTrans { get; set; }
        public DateTime FechFinTrans { get; set; }
        public string HoraDespacho { get; set; }
        public string CedulaCliente { get; set; }
        public string PuntoDestino { get; set; }
        public string CedulaRucTransportista { get; set; }

        public GuiaRemisionClass()
        {
            conexion = new BD_DespTanqInteEntities();
        }

        public int new_GuiaRemision(GuiaRemisionClass GR)
        {
            GuiaRemision tabla = new GuiaRemision();
            try
            {
                //tabla.ReferRemis = GR.GuiaRemision;
                tabla.NumFactura = GR.NumeFactura;
                tabla.FechInicTras = GR.FechIniTrans;
                tabla.FechFinTras = GR.FechFinTrans;
                tabla.HoraDespacho = GR.HoraDespacho;
                tabla.CedRucClie = GR.CedulaCliente;
                tabla.PuntoDestino = GR.PuntoDestino;
                tabla.CedRucTran = GR.CedulaRucTransportista;
                BD.AddToGuiaRemisions(tabla);
                BD.SaveChanges();
                return tabla.ReferRemis;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return 0;
        }

        public void update_GuiaRemision(int NumeroGuia, int NumeroFactura, DateTime FechaInicio,
                                        DateTime FechaFin, string HoraDespa, string CedulaCliente,
                                        string Destino, string CedulaTanquero)
        {
            try
            {
                GuiaRemision tabla = new GuiaRemision();
                tabla = (from a in BD.GuiaRemisions
                         where a.ReferRemis == NumeroGuia
                         select a).FirstOrDefault();
                tabla.NumFactura = NumeroFactura;
                tabla.FechInicTras = FechaInicio;
                tabla.FechFinTras = FechaFin;
                tabla.HoraDespacho = HoraDespa;
                tabla.CedRucClie = CedulaCliente;
                tabla.PuntoDestino = Destino;
                tabla.CedRucTran = CedulaTanquero;
                BD.Refresh(System.Data.Objects.RefreshMode.ClientWins, tabla);
                BD.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void delete_GuiaRemision(int num_guia)
        {
            try
            {
                GuiaRemision tabla = new GuiaRemision();
                tabla = (from a in BD.GuiaRemisions
                         where a.ReferRemis == num_guia
                         select a).FirstOrDefault();
                BD.DeleteObject(tabla);
                BD.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool consulta_NGuia(int Num_Guia)
        {
            GuiaRemision tabla = BD.GuiaRemisions.FirstOrDefault(a => a.ReferRemis == Num_Guia);
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


        public GuiaRemisionClass find_Guia(int NumeroGuia)
        {
            GuiaRemisionClass GuiaDatos = new GuiaRemisionClass();
            //GuiaRemisionClass GuiaDatos;

            try
            {
                GuiaRemision tabla = new GuiaRemision();
                tabla = (from a in BD.GuiaRemisions
                         where a.ReferRemis == NumeroGuia
                         select a).FirstOrDefault();
                GuiaDatos.GuiaRemision = tabla.ReferRemis;
                GuiaDatos.NumeFactura = tabla.NumFactura;
                GuiaDatos.FechIniTrans = tabla.FechInicTras;
                GuiaDatos.FechFinTrans = tabla.FechFinTras;
                GuiaDatos.HoraDespacho = tabla.HoraDespacho;
                GuiaDatos.CedulaCliente = tabla.CedRucClie;
                GuiaDatos.PuntoDestino = tabla.PuntoDestino;
                GuiaDatos.CedulaRucTransportista = tabla.CedRucTran;
                return GuiaDatos;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public List<GuiaRemisionClass> devolver_guias(int NumeroFactura)
        {
            List<GuiaRemisionClass> lista_guias_remision = new List<GuiaRemisionClass>();

            foreach (var item in BD.GuiaRemisions)
            {
                GuiaRemisionClass GRN = new GuiaRemisionClass();
                GRN.GuiaRemision = item.ReferRemis;
                GRN.NumeFactura = item.NumFactura;
                GRN.FechIniTrans = item.FechInicTras;
                GRN.FechFinTrans = item.FechFinTras;
                GRN.HoraDespacho = item.HoraDespacho;
                GRN.CedulaCliente = item.CedRucClie;
                GRN.PuntoDestino = item.PuntoDestino;
                GRN.CedulaRucTransportista = item.CedRucTran;
                if (GRN.NumeFactura == NumeroFactura)
                {
                    lista_guias_remision.Add(GRN);
                }
            }
            return lista_guias_remision;
        }


        public List<int> devolver_guias1(int NumeroFactura)
        {
            List<int> lista_guias_remision = new List<int>();

            foreach (var item in BD.GuiaRemisions)
            {
                int numGuia = item.ReferRemis;
                int numfactura = item.NumFactura;
                if (numfactura == NumeroFactura)
                {
                    lista_guias_remision.Add(numGuia);
                }
            }
            return lista_guias_remision;
        }
    }
}
