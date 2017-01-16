using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoTanqueIntermedioEpam.CapaNegocios;

namespace ProyectoTanqueIntermedioEpam.CapaPresentacion
{
    public partial class FormGestionPermisosUsuario : System.Web.UI.Page
    {
        GestionUsuarioClass Gestion = new GestionUsuarioClass();
        public bool acciones = false, accionG = false, accionM = false, accionE = false, accionI = false;
        FormInicioSesion ini = new FormInicioSesion();
        public string user;
        public string tipoUser;


        protected void Page_Load(object sender, EventArgs e)
        {
            if (FormInicioSesion.userNow == null)
            {
                Response.Redirect("FormInicioSesion.aspx");
            }
            
            lblFecha.Text = Convert.ToString(DateTime.Now);
            user = FormInicioSesion.userNow;
            lblUser.Text = ("Bienvenid@: " + user + " | ");
            tipoUser = FormInicioSesion.tipoNow;
            lblTipoUser.Text = tipoUser;
            lblTipoUser.Enabled = false;

        }

        protected void btnSalir_Click(object sender, EventArgs e)
        {
          Response.Redirect("FormUsuario.aspx");
        }

        public void validar()
        {
            if (radios.SelectedItem.Text == "Sin acceso") { acciones = false; }
            if (radios.SelectedItem.Text == "Permitir acceso") { acciones = true; }

            if (CheckGuardar.Checked==true) { accionG = true; } else { accionG = false; }
            if (CheckModificar.Checked == true) { accionM = true; } else { accionM = false; }
            if (CheckEliminar.Checked == true) { accionE = true; } else { accionE = false; }
            if (CheckImprimir.Checked == true) { accionI = true; } else { accionI = false; }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            validar();

            try
            {
                //if (cbxTablas.SelectedItem.Text="" || radios.SelectedItem.Text="")
                //{

                //MessageBox.Show("Faltan campos por llenar");
                //}
                //else
                //{

                GestionUsuarioClass Tr = new GestionUsuarioClass();
                Tr.CuentaUsuario = FormUsuario.UsuarioAEditar;
                Tr.NombreTabla = cbxTablas.SelectedValue;
                Tr.PAcceso = acciones;
                Tr.PGuardar = accionG;
                Tr.PModificar = accionM;
                Tr.PEliminar = accionE;
                Tr.PImprimir = accionI;
                Gestion.new_Permisos(Tr);

                //MessageBox.Show("Datos guardados");
                //Limpiar();
                //}
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            validar();

            try
            {
                if (cbxTablas.SelectedItem.Text == "" || radios.SelectedIndex == -1)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alertIns", "alert('Faltan campos por llenar');", true);                                                            
                }
                else
                {

                    GestionUsuarioClass Tr = new GestionUsuarioClass();
                    Gestion.update_Permisos(FormUsuario.UsuarioAEditar, cbxTablas.SelectedValue, acciones, accionG, accionM, accionE, accionI);
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alertIns", "alert('El registro se guardó correctamente');", true);                                                            
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        protected void btnBuscar_Click1(object sender, EventArgs e)
        {
            try
            {
                Limpiar();
                GestionUsuarioClass GU= Gestion.devolver_permisos1(FormUsuario.UsuarioAEditar, cbxTablas.SelectedValue);
                if (GU.PAcceso == true) { radios.SelectedIndex = 1; }
                else { radios.SelectedIndex = 0; }
                if (GU.PGuardar == true) { CheckGuardar.Checked = true; } else { CheckGuardar.Checked = false; }
                if (GU.PModificar == true) { CheckModificar.Checked = true; } else { CheckModificar.Checked = false; }
                if (GU.PEliminar == true) { CheckEliminar.Checked = true; } else { CheckEliminar.Checked = false; }
                if (GU.PImprimir == true) { CheckImprimir.Checked = true; } else { CheckImprimir.Checked = false; }
            }
            catch (Exception ex)
            {
                
                throw;
            }
        }

        public void Limpiar()
        {
            CheckGuardar.Checked = false;
            CheckModificar.Checked = false;
            CheckEliminar.Checked = false;
            CheckImprimir.Checked = false;
            radios.ClearSelection();
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            //cbxTablas.Text = "";
            Limpiar();
        }

        public static void RegisterStartupScript(Control control, Type type, string key, string script, bool addScriptTags)
        {

        }

    }
}