using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoTanqueIntermedioEpam.CapaPresentacion
{
    public partial class HojaDeReportes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ReportesPor miDataSet1 = new ReportesPor();

            ReportesPorTableAdapters.DatosFactura_GuiaTableAdapter FacturaGuia = new ReportesPorTableAdapters.DatosFactura_GuiaTableAdapter();
            ReportesPorTableAdapters.Reporte_por_NumFacturaTableAdapter ReportFacturitas = new ReportesPorTableAdapters.Reporte_por_NumFacturaTableAdapter();
            ReportesPorTableAdapters.ReporteDespacho_por_NumRemisionTableAdapter ReportGuiaRemi = new ReportesPorTableAdapters.ReporteDespacho_por_NumRemisionTableAdapter();
            ReportesPorTableAdapters.ReporteDespacho_por_FechaTableAdapter ReportFechita = new ReportesPorTableAdapters.ReporteDespacho_por_FechaTableAdapter();
            ReportesPorTableAdapters.ReporteDespacho_entre_fechasTableAdapter ReportFechitas = new ReportesPorTableAdapters.ReporteDespacho_entre_fechasTableAdapter();

            //Y llenamos el DataSet//Los parametros de este metodo depende de los parametros del procedimiento

            if(FormReportes.QueReporte=="GuiaRemision")
            {
                FacturaGuia.Fill(miDataSet1.DatosFactura_Guia, FormGuiaRemisionGeneral.NFactura, FormGuiaRemisionGeneral.NGuiaR);
                CrystalReportGuiaR GuiaR = new CrystalReportGuiaR();
                GuiaR.SetDataSource(miDataSet1);
                this.CrystalReportViewer1.ReportSource = GuiaR;
            }
            if (FormReportes.QueReporte == "Diario")
            {
                ReportFechita.Fill(miDataSet1.ReporteDespacho_por_Fecha, FormReportes.Fecha1);
                CrystalReportByDatee reporte = new CrystalReportByDatee();
                reporte.SetDataSource(miDataSet1);
                this.CrystalReportViewer1.ReportSource = reporte;
            }
            if (FormReportes.QueReporte == "Entre fechas")
            {
                ReportFechitas.Fill(miDataSet1.ReporteDespacho_entre_fechas, FormReportes.Fecha1, FormReportes.Fecha2);
                CrystalReportBetweenDatess reporte = new CrystalReportBetweenDatess();
                reporte.SetDataSource(miDataSet1);
                this.CrystalReportViewer1.ReportSource = reporte;
            }
            if (FormReportes.QueReporte == "Por número de Factura")
            {
                ReportFacturitas.Fill(miDataSet1.Reporte_por_NumFactura, FormReportes.NumFact);
                CrystalReportByNumFac reporte = new CrystalReportByNumFac();
                reporte.SetDataSource(miDataSet1);
                this.CrystalReportViewer1.ReportSource = reporte;
            }
            if (FormReportes.QueReporte == "Por número de Guía Remisión")
            {
                ReportGuiaRemi.Fill(miDataSet1.ReporteDespacho_por_NumRemision, FormReportes.NumGR);
                CrystalReportByNumGR reporte = new CrystalReportByNumGR();
                reporte.SetDataSource(miDataSet1);
                this.CrystalReportViewer1.ReportSource = reporte;
            }

        }
    }
}