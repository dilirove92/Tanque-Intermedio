using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoTanqueIntermedioEpam.CapaNegocios;

namespace ProyectoTanqueIntermedioEpam.CapaPresentacion
{
    public partial class FormTransportista : System.Web.UI.Page
    {
        TransportistaClass Trans = new TransportistaClass();
        ValidacionesClass cli = new ValidacionesClass();
        FormInicioSesion ini = new FormInicioSesion();
        public string user;
        public string tipoUser;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (FormInicioSesion.userNow == null)
            {
                Response.Redirect("FormInicioSesion.aspx");
            }

            if (FormMenu.PermisosUser9.PGuardar) { btnGuardar.Enabled = true; } else { btnGuardar.Enabled = false; }
            if (FormMenu.PermisosUser9.PModificar) { btnModificar.Enabled = true; } else { btnModificar.Enabled = false; }
            if (FormMenu.PermisosUser9.PEliminar) { btnEliminar.Enabled = true; } else { btnEliminar.Enabled = false; }

            lblFecha.Text = Convert.ToString(DateTime.Now);
            user = FormInicioSesion.userNow;
            lblUser.Text = ("Bienvenid@: " + user + " | ");
            tipoUser = FormInicioSesion.tipoNow;
            lblTipoUser.Text = tipoUser;
            lblTipoUser.Enabled = false;

            txtCedulaTrans.Attributes.Add("onkeypress", "javascript:return ValidCed(event);");
            txtNombreTrans.Attributes.Add("onkeypress", "javascript:return ValidText(event);");
            txtApellidosTrans.Attributes.Add("onkeypress", "javascript:return ValidText(event);");
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCedulaTrans.Text == "" ||
                    txtNombreTrans.Text == "" ||
                    txtApellidosTrans.Text == "")
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alertIns", "alert('Faltan campos por llenar');", true);                    
                }
                else
                {
                    if (cli.ValidacionCedula(txtCedulaTrans.Text))
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "alertIns", "alert('Cumple con el Patrón de la Cédula');", true); 
                        TransportistaClass Tr = new TransportistaClass();
                        Tr.CedulaTransportista = txtCedulaTrans.Text;
                        Tr.NombreTransportista = txtNombreTrans.Text;
                        Tr.ApellidoTransportista = txtApellidosTrans.Text;
                        Trans.new_Transportista(Tr);
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "alertIns", "alert('No cumple con el Patrón de la Cédula');", true); 
                    }

                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alertIns", "alert('El registro se guardó correctamente');", true);
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
            try
            {
                Trans.delete_transportista(txtCedulaTrans.Text);
                txtCedulaTrans.Enabled = true;
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alertIns", "alert('El registro se eliminó correctamente');", true);                  
                Limpiar();
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
                if (txtCedulaTrans.Text == "" ||
                    txtNombreTrans.Text == "" ||
                    txtApellidosTrans.Text=="")
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alertIns", "alert('Faltan campos por llenar');", true);
                }
                else
                {
                    Trans.update_Transportista(txtCedulaTrans.Text, txtNombreTrans.Text,txtApellidosTrans.Text);
                    txtCedulaTrans.Enabled = true;
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alertIns", "alert('El registro se modificó correctamente');", true);
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            TransportistaClass TraerDatos;
            try
            {
                if (Trans.consulta_Transportista(txtCedulaTrans.Text) == false)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alertIns", "alert('No existe registro');", true);
                    txtCedulaTrans.Focus();
                }
                else
                {
                    TraerDatos = Trans.find_Transportista(txtCedulaTrans.Text);
                    txtCedulaTrans.Text = TraerDatos.CedulaTransportista;
                    txtNombreTrans.Text= TraerDatos.NombreTransportista;
                    txtApellidosTrans.Text = TraerDatos.ApellidoTransportista;
                    txtCedulaTrans.Enabled = false;
                }
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
            txtCedulaTrans.Text = "";
            txtNombreTrans.Text = "";
            txtApellidosTrans.Text = "";
        }


        public static void RegisterStartupScript(Control control, Type type, string key, string script, bool addScriptTags)
        {

        }


    }
}
          
      

