using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoTanqueIntermedioEpam.CapaNegocios;

namespace ProyectoTanqueIntermedioEpam.CapaPresentacion
{
    public partial class FormMedidor2 : System.Web.UI.Page
    {
        Medidor2Class Medid = new Medidor2Class();
        FormInicioSesion ini = new FormInicioSesion();
        public string user;
        public string tipoUser;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (FormInicioSesion.userNow == null)
            {
                Response.Redirect("FormInicioSesion.aspx");
            }

            if (FormMenu.PermisosUser5.PModificar) { btnModificar.Enabled = true; } else { btnModificar.Enabled = false; }
            if (FormMenu.PermisosUser5.PEliminar) { btnEliminar.Enabled = true; } else { btnEliminar.Enabled = false; }

            lblFecha.Text = Convert.ToString(DateTime.Now);
            user = FormInicioSesion.userNow;
            lblUser.Text = ("Bienvenid@: " + user + " | ");
            tipoUser = FormInicioSesion.tipoNow;
            lblTipoUser.Text = tipoUser;
            lblTipoUser.Enabled = false;
            
            txtID.Attributes.Add("onkeypress", "javascript:return ValidInt(event);");
            txtLecturaIni.Attributes.Add("onkeypress", "javascript:return ValidInt(event);");
            txtLecturaFin.Attributes.Add("onkeypress", "javascript:return ValidInt(event);");
            txtFecha.Attributes.Add("onkeypress", "javascript:return ValidFecha(event);");
            txtObservacion.Attributes.Add("onkeypress", "javascript:return ValidText(event);");
            txtUsuario.Attributes.Add("onkeypress", "javascript:return ValidText(event);");
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            MedidorClass TraerDatos;
            try
            {
                if (Medid.consulta_Medidor(int.Parse(txtID.Text)) == false)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alertIns", "alert('No existe registro');", true);                    
                    txtID.Focus();
                }
                else
                {
                    TraerDatos = Medid.find_Medidor(int.Parse(txtID.Text));
                    //txtID.Text = Convert.ToString(TraerDatos.ID);
                    txtLecturaIni.Text = Convert.ToString(TraerDatos.LecturaInicial);
                    txtLecturaFin.Text = Convert.ToString(TraerDatos.LecturaFinal);
                    txtFecha.Text = Convert.ToString(TraerDatos.Fecha);
                    txtObservacion.Text = Convert.ToString(TraerDatos.observacion);
                    txtUsuario.Text = Convert.ToString(TraerDatos.NomUsuario);
                    txtID.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtLecturaIni.Text == "" ||
                    txtLecturaFin.Text == "" ||
                    txtFecha.Text == "" ||
                    txtUsuario.Text == "")
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alertIns", "alert('Faltan campos por llenar');", true);                    
                }
                else
                {
                    Medid.update_DetallesMedidor(int.Parse(txtID.Text), int.Parse(txtLecturaIni.Text),
                                                   int.Parse(txtLecturaFin.Text), DateTime.Parse(txtFecha.Text),
                                                   txtObservacion.Text, txtUsuario.Text);
                    txtID.Enabled = true;
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alertIns", "alert('El registro se modificó correctamente');", true);
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            //Response.Redirect("Menu.aspx");
            //Response.Close();

            try
            {
                Medid.delete_DetallesMedidor(int.Parse(txtID.Text));
                txtUsuario.Enabled = true;
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alertIns", "alert('El registro se eliminó correctamente');", true);
                Limpiar();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        protected void btnSalir_Click(object sender, EventArgs e)
        {
            Response.Redirect("FormMenu.aspx");
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }


        public void Limpiar()
        {
            txtID.Text = "";
            txtLecturaIni.Text = "";
            txtLecturaFin.Text = "";
            txtFecha.Text = "";
            txtObservacion.Text = "";
            txtUsuario.Text = "";
        }


        public static void RegisterStartupScript(Control control, Type type, string key, string script, bool addScriptTags)
        {

        }

    }
}
