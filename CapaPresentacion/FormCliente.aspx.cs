using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoTanqueIntermedioEpam.CapaNegocios;

namespace ProyectoTanqueIntermedioEpam.CapaPresentacion
{
    public partial class FormCliente : System.Web.UI.Page
    {
        ClientesClass ObjClientes = new ClientesClass();
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

            if (FormMenu.PermisosUser1.PGuardar) { btnGuardar.Enabled = true; } else { btnGuardar.Enabled = false; }
            if (FormMenu.PermisosUser1.PModificar) { btnModificar.Enabled = true; } else { btnModificar.Enabled = false; }
            if (FormMenu.PermisosUser1.PEliminar) { btnEliminar.Enabled = true; } else { btnEliminar.Enabled = false; }
            
            lblFecha.Text = Convert.ToString(DateTime.Now);
            user = FormInicioSesion.userNow;
            lblUser.Text = ("Bienvenid@: " + user + " | ");
            tipoUser = FormInicioSesion.tipoNow;
            lblTipoUser.Text = tipoUser;
            lblTipoUser.Enabled = false;

            txtCedulaCli.Attributes.Add("onkeypress", "javascript:return ValidCed(event);");
            txtNombreCli.Attributes.Add("onkeypress", "javascript:return ValidText(event);");
            txtApellidoCli.Attributes.Add("onkeypress", "javascript:return ValidText(event);");
            txtDireccionCli.Attributes.Add("onkeypress", "javascript:return ValidDom(event);");
            txtTelefonoCli.Attributes.Add("onkeypress", "javascript:return ValidTel(event);");

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCedulaCli.Text == "" ||
                    txtNombreCli.Text == "" ||
                    txtApellidoCli.Text == "" ||
                    txtDireccionCli.Text == "" ||
                    txtTelefonoCli.Text == "")
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alertIns", "alert('Faltan campos por llenar');", true);                                   
                }
                else
                {
                    if (cli.ValidacionCedula(txtCedulaCli.Text))
                    {                        
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "alertIns", "alert('Cumple con el Patrón de la Cédula');", true);                     
                        ClientesClass Usu = new ClientesClass();
                        Usu.CedulaCliente = txtCedulaCli.Text;
                        Usu.NombreCliente = txtNombreCli.Text;
                        Usu.ApellidoCliente = txtApellidoCli.Text;
                        Usu.DireccionCliente = txtDireccionCli.Text;
                        Usu.TelefonoCliente = txtTelefonoCli.Text;
                        ObjClientes.new_Cliente(Usu);
                    }
                    else{
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
            ClientesClass TraerDatos;
            try
            {
                if (ObjClientes.consulta_Clientes(txtCedulaCli.Text) == false)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alertIns", "alert('No existe registro');", true);
                    txtCedulaCli.Focus();
                }
                else
                {
                    TraerDatos = ObjClientes.find_Clientes(txtCedulaCli.Text);
                    txtCedulaCli.Text = Convert.ToString(TraerDatos.CedulaCliente);
                    txtNombreCli.Text = Convert.ToString(TraerDatos.NombreCliente);
                    txtApellidoCli.Text = Convert.ToString(TraerDatos.ApellidoCliente);
                    txtDireccionCli.Text = Convert.ToString(TraerDatos.DireccionCliente);
                    txtTelefonoCli.Text = Convert.ToString(TraerDatos.TelefonoCliente);
                    txtCedulaCli.Enabled = false;
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
                if (txtCedulaCli.Text == "" ||
                    txtNombreCli.Text == "" ||
                    txtApellidoCli.Text == "" ||
                    txtDireccionCli.Text == "" ||
                    txtTelefonoCli.Text == "")
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alertIns", "alert('Faltan campos por llenar');", true);                    
                }
                else
                {
                    ObjClientes.update_Cliente(txtCedulaCli.Text, txtNombreCli.Text, txtApellidoCli.Text, txtDireccionCli.Text, txtTelefonoCli.Text);
                    txtCedulaCli.Enabled = true;
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
                ObjClientes.delete_Cliente(txtCedulaCli.Text);
                txtCedulaCli.Enabled = true;
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
            txtCedulaCli.Text = "";
            txtNombreCli.Text = "";
            txtApellidoCli.Text = "";
            txtDireccionCli.Text = "";
            txtTelefonoCli.Text = "";
        }

        public static void RegisterStartupScript(Control control,Type type,string key,string script,bool addScriptTags)
        {

        }


    }
}

    