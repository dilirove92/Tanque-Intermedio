using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoTanqueIntermedioEpam.CapaNegocios;


namespace ProyectoTanqueIntermedioEpam.CapaPresentacion
{
    public partial class FormReportes : System.Web.UI.Page
    {
        ReportesClass Reports = new ReportesClass();
        FormInicioSesion ini = new FormInicioSesion();
        public string user;
        public string tipoUser;
        public static string QueReporte;
        public static DateTime Fecha1;
        public static DateTime Fecha2;
        public static int NumFact;
        public static int NumGR;
             
        protected void Page_Load(object sender, EventArgs e)
        {
            if (FormInicioSesion.userNow == null)
            {
                Response.Redirect("FormInicioSesion.aspx");
            }

            if (FormMenu.PermisosUser7.PGuardar) { btnImprimir.Enabled = true; } else { btnImprimir.Enabled = false; }

            lblFecha.Text = Convert.ToString(DateTime.Now);
            user = FormInicioSesion.userNow;
            lblUser.Text = ("Bienvenid@: " + user + " | ");
            tipoUser = FormInicioSesion.tipoNow;
            lblTipoUser.Text = tipoUser;
            lblTipoUser.Enabled = false;
            
            txtFecha1.Attributes.Add("onkeypress", "javascript:return ValidFecha(event);");
            txtFecha2.Attributes.Add("onkeypress", "javascript:return ValidFecha(event);");
            txtNumeroFactura.Attributes.Add("onkeypress", "javascript:return ValidInt(event);");
            txtNumGuia.Attributes.Add("onkeypress", "javascript:return ValidInt(event);");

        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cbxTipoReporte.Text == "Diario")
            {
                ReportesClass miMedMetodo = new ReportesClass();
                miMedMetodo.ReportesPorFecha(GridView1, DateTime.Parse(txtFecha1.Text));
                Fecha1 = DateTime.Parse(txtFecha1.Text);
            }

            if (cbxTipoReporte.Text == "Entre fechas")
            {
                ReportesClass miMedMetodo = new ReportesClass();
                miMedMetodo.ReportesEntreFechas(GridView1, DateTime.Parse(txtFecha1.Text), DateTime.Parse(txtFecha2.Text));
                Fecha1 = DateTime.Parse(txtFecha1.Text);
                Fecha2 = DateTime.Parse(txtFecha2.Text);
            }

            if (cbxTipoReporte.Text == "Por número de Factura")
            {
                ReportesClass miMedMetodo = new ReportesClass();
                miMedMetodo.ReportesPorFactura(GridView1, int.Parse(txtNumeroFactura.Text));
                NumFact = int.Parse(txtNumeroFactura.Text);
            }

            if (cbxTipoReporte.Text == "Por número de Guía Remisión")
            {
                ReportesClass miMedMetodo = new ReportesClass();
                miMedMetodo.ReportesPorGuiaRemision(GridView1, int.Parse(txtNumGuia.Text));
                NumGR = int.Parse(txtNumGuia.Text);
            }

            QueReporte = cbxTipoReporte.SelectedValue;
        }

        protected void btnSalir_Click(object sender, EventArgs e)
        {
            QueReporte = "";
            Response.Redirect("FormMenu.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        protected void btnImprimir_Click(object sender, EventArgs e)
        {
            
        }

        protected void btnImprimir_Click1(object sender, EventArgs e)
        {
            Response.Redirect("HojaDeReportes.aspx");
        }


        public void Limpiar()
        {
            cbxTipoReporte.Text = "";
            txtFecha1.Text = "";
            txtFecha2.Text = "";
            txtNumeroFactura.Text = "";
            txtNumGuia.Text = "";
        }

    }
}