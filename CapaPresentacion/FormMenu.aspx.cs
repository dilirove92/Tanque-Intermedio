using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoTanqueIntermedioEpam.CapaNegocios;

namespace ProyectoTanqueIntermedioEpam.CapaPresentacion
{
    public partial class FormMenu : System.Web.UI.Page
    {
        FormInicioSesion ini = new FormInicioSesion();
        GestionUsuarioClass UserPer = new GestionUsuarioClass();
        public static GestionUsuarioClass PermisosUser1, PermisosUser2, PermisosUser3, PermisosUser4, PermisosUser5;
        public static GestionUsuarioClass PermisosUser6, PermisosUser7, PermisosUser8, PermisosUser9, PermisosUser10;
        public string user;
        public string tipoUser;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (FormInicioSesion.userNow == null)
            {
                Response.Redirect("FormInicioSesion.aspx");
            }

            FormInicioSesion.salir = 1;

            PermisosUser1 = UserPer.devolver_permisos1(FormInicioSesion.userNow, "Cliente");
            PermisosUser2 = UserPer.devolver_permisos1(FormInicioSesion.userNow, "Detalle Factura");
            PermisosUser3 = UserPer.devolver_permisos1(FormInicioSesion.userNow, "Guia Remision");
            PermisosUser4 = UserPer.devolver_permisos1(FormInicioSesion.userNow, "Guia Remision General");
            PermisosUser5 = UserPer.devolver_permisos1(FormInicioSesion.userNow, "Medidor");
            PermisosUser6 = UserPer.devolver_permisos1(FormInicioSesion.userNow, "Metros Cubicos Despachados");
            PermisosUser7 = UserPer.devolver_permisos1(FormInicioSesion.userNow, "Reportes");
            PermisosUser8 = UserPer.devolver_permisos1(FormInicioSesion.userNow, "Tanquero");
            PermisosUser9 = UserPer.devolver_permisos1(FormInicioSesion.userNow, "Transportista");
            PermisosUser10 = UserPer.devolver_permisos1(FormInicioSesion.userNow, "Usuario");

            if (PermisosUser1.PAcceso == true) { ImageClientes.Enabled = true; } else { ImageClientes.Enabled = false; }
            if (PermisosUser2.PAcceso == true) { ImageDetalleFactura.Enabled = true; } else { ImageDetalleFactura.Enabled = false; }
            if (PermisosUser3.PAcceso == true) { ImageGuiaRemision.Enabled = true; } else { ImageGuiaRemision.Enabled = false; }
            if (PermisosUser4.PAcceso == true) { btnGenerarGuiaRemision.Enabled = true; } else { btnGenerarGuiaRemision.Enabled = false; }
            if (PermisosUser5.PAcceso == true) { ImageMedidor.Enabled = true; } else { ImageMedidor.Enabled = false; }
            if (PermisosUser6.PAcceso == true) { ImageMetrosCubicosDespachados.Enabled = true; } else { ImageMetrosCubicosDespachados.Enabled = false; }
            if (PermisosUser7.PAcceso == true) { ImageReportes.Enabled = true; } else { ImageReportes.Enabled = false; }
            if (PermisosUser8.PAcceso == true) { ImageTanquero.Enabled = true; } else { ImageTanquero.Enabled = false; }
            if (PermisosUser9.PAcceso == true) { ImageTransportita.Enabled = true; } else { ImageTransportita.Enabled = false; }
            if (PermisosUser10.PAcceso == true) { ImageUsuarios.Enabled = true; } else { ImageUsuarios.Enabled = false; }

            lblFecha.Text = Convert.ToString(DateTime.Now);            
            user = FormInicioSesion.userNow;
            lblUser.Text = ("Bienvenid@: "+user+" | ");
            tipoUser = FormInicioSesion.tipoNow;
            lblTipoUser.Text = tipoUser;
            lblTipoUser.Enabled = false;
        }

        protected void ImageUsuarios_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("FormUsuario.aspx");
        }

        protected void ImageTransportita_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("FormTransportista.aspx");
        }

        protected void ImageClientes_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("FormCliente.aspx");
        }

        protected void ImageTanquero_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("FormTanquero.aspx");
        }

        protected void ImageMetrosCubicosDespachados_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("FormMetrosCubicosDespachados.aspx");
        }

        protected void ImageDetalleFactura_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("FormDetalleFactura.aspx");
        }

        protected void ImageGuiaRemision_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("FormGuiaRemision.aspx");
        }

        protected void ImageReportes_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("FormReportes.aspx");
        }

        protected void ImageMedidor_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("FormMedidor2.aspx");
        }

        protected void btnGenerarGuiaRemision_Click(object sender, EventArgs e)
        {
            Response.Redirect("FormGuiaRemisionGeneral.aspx");
        }

        protected void HyperLink1_Click(object sender, EventArgs e)
        {
            //FormInicioSesion.salir = 1;
        }
    }
}