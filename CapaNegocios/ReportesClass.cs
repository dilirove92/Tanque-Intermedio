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
    public class ReportesClass
    {
        BD_DespTanqInteEntities conexion { get; set; }
        BD_DespTanqInteEntities BD = new BD_DespTanqInteEntities();

        public ReportesClass()
        {
            conexion = new BD_DespTanqInteEntities();
        }

        public void ReportesPorFecha(GridView grilla, DateTime fecha)
        {
            grilla.DataSource = BD.ReporteByFecha(fecha);
            grilla.DataBind();
        }

        public void ReportesEntreFechas(GridView grilla, DateTime fecha1, DateTime fecha2)
        {
            grilla.DataSource = BD.ReporteByFechas(fecha1, fecha2);
            grilla.DataBind();
        }


        public void ReportesPorGuiaRemision(GridView grilla, int guia)
        {
            grilla.DataSource = BD.ReportePorGuia(guia);
            grilla.DataBind();
        }

        public void ReportesPorFactura(GridView grilla, int factura)
        {
            grilla.DataSource = BD.ReportePorFacturass(factura);
            grilla.DataBind();
        }                    

    }
}
