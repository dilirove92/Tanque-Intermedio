using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoTanqueIntermedioEpam.CapaNegocios;

namespace ProyectoTanqueIntermedioEpam.CapaPresentacion
{
    public partial class FormUsuario : System.Web.UI.Page
    {
        UsuarioClass Usuarios = new UsuarioClass();
        ValidacionesClass CedUsu = new ValidacionesClass();
        public static string UsuarioAEditar;
        FormInicioSesion ini = new FormInicioSesion();
        public string user;
        public string tipoUser;


        protected void Page_Load(object sender, EventArgs e)
        {
            if (FormInicioSesion.userNow == null)
            {
                Response.Redirect("FormInicioSesion.aspx");
            }

            if (FormMenu.PermisosUser10.PGuardar) { btnGuardar.Enabled = true; } else { btnGuardar.Enabled = false; }
            if (FormMenu.PermisosUser10.PModificar) { btnModificar.Enabled = true; } else { btnModificar.Enabled = false; }
            if (FormMenu.PermisosUser10.PEliminar) { btnEliminar.Enabled = true; } else { btnEliminar.Enabled = false; }

            lblFecha.Text = Convert.ToString(DateTime.Now);
            user = FormInicioSesion.userNow;
            lblUser.Text = ("Bienvenid@: " + user + " | ");
            tipoUser = FormInicioSesion.tipoNow;
            lblTipoUser.Text = tipoUser;
            lblTipoUser.Enabled = false;

            txtNombreUsu.Attributes.Add("onkeypress", "javascript:return ValidText(event);");
            txtCedula.Attributes.Add("onkeypress", "javascript:return ValidCed(event);");
            txtNombreUsu.Attributes.Add("onkeypress", "javascript:return ValidText(event);");
            txtApellidosUsu.Attributes.Add("onkeypress", "javascript:return ValidText(event);");  

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombreUsu.Text == "" ||
                    txtApellidosUsu.Text== "" ||
                    txtUsuario.Text == "" ||
                    txtContraseña.Text == "" ||
                    txtCedula.Text == ""||
                    cbxTipoUsuario.Text=="")
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alertIns", "alert('Faltan campos por llenar');", true); 
                }
                else
                {
                    if (CedUsu.ValidacionCedula(txtCedula.Text))
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "alertIns", "alert('Cumple con el Patrón de la Cédula');", true);                                             
                        Usuarios.Usuario = txtUsuario.Text;
                        Usuarios.NomUsuario = txtNombreUsu.Text;
                        Usuarios.ApeUsuario = txtApellidosUsu.Text;
                        Usuarios.ContraseñaUs = txtContraseña.Text;
                        Usuarios.CedulaUs = txtCedula.Text;
                        Usuarios.TipoUsuario = cbxTipoUsuario.Text;
                        Usuarios.new_Usuario(Usuarios);
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

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            UsuarioClass TraerDatos;
            try
            {
                if (Usuarios.consulta_Usuario(txtUsuario.Text) == false)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alertIns", "alert('No existe registro');", true);                    
                    txtUsuario.Focus();
                }
                else
                {
                    TraerDatos = Usuarios.find_Usuario(txtUsuario.Text);
                    txtUsuario.Text = TraerDatos.Usuario;
                    txtContraseña.Text = TraerDatos.ContraseñaUs;
                    txtNombreUsu.Text = TraerDatos.NomUsuario;
                    txtApellidosUsu.Text = TraerDatos.ApeUsuario;
                    txtCedula.Text = TraerDatos.CedulaUs;
                    cbxTipoUsuario.Text = TraerDatos.TipoUsuario;

                    txtUsuario.Enabled = false;
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
                if (txtNombreUsu.Text == "" ||
                    txtApellidosUsu.Text == "" ||
                    txtUsuario.Text == "" ||
                    txtContraseña.Text == "" ||
                    cbxTipoUsuario.Text == "" ||
                    txtCedula.Text == "")
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alertIns", "alert('Faltan campos por llenar');", true); 
                }
                else
                {
                    Usuarios.update_user(txtUsuario.Text, txtContraseña.Text, txtCedula.Text, txtNombreUsu.Text, txtApellidosUsu.Text, cbxTipoUsuario.Text);
                    txtUsuario.Enabled = true;
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
            try
            {
                Usuarios.delete_user(txtUsuario.Text);
                txtUsuario.Enabled = true;
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alertIns", "alert('El registro se eliminó correctamente');", true);
                Limpiar();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        protected void btnGestionUsuario_Click(object sender, EventArgs e)
        {
            UsuarioAEditar = txtUsuario.Text;
            if (UsuarioAEditar == "")
            {
                //Mostrar mensaje
            }
            else
            {
                Response.Redirect("FormGestionPermisosUsuario.aspx");
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
            txtNombreUsu.Text = "";
            txtContraseña.Text = "";
            txtCedula.Text = "";
            txtNombreUsu.Text = "";
            txtApellidosUsu.Text = "";
            cbxTipoUsuario.Text = "";
        }

        public static void RegisterStartupScript(Control control, Type type, string key, string script, bool addScriptTags)
        {

        }

    }
}