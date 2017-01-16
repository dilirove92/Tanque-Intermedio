using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoTanqueIntermedioEpam.CapaNegocios;

namespace ProyectoTanqueIntermedioEpam.CapaPresentacion
{
    public partial class FormMetrosCubicosDespachados : System.Web.UI.Page
    {
        MetrosCubicosDespachadosClass MCD = new MetrosCubicosDespachadosClass();
        FormInicioSesion ini = new FormInicioSesion();
        public string user;
        public string tipoUser;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (FormInicioSesion.userNow == null)
            {
                Response.Redirect("FormInicioSesion.aspx");
            }

            if (FormMenu.PermisosUser6.PGuardar) { btnGuardar.Enabled = true; } else { btnGuardar.Enabled = false; }
            if (FormMenu.PermisosUser6.PModificar) { btnModificar.Enabled = true; } else { btnModificar.Enabled = false; }
            if (FormMenu.PermisosUser6.PEliminar) { btnEliminar.Enabled = true; } else { btnEliminar.Enabled = false; }

            lblFecha.Text = Convert.ToString(DateTime.Now);
            user = FormInicioSesion.userNow;
            lblUser.Text = ("Bienvenid@: " + user + " | ");
            tipoUser = FormInicioSesion.tipoNow;
            lblTipoUser.Text = tipoUser;
            lblTipoUser.Enabled = false;

            txtNumeroGuia.Attributes.Add("onkeypress", "javascript:return ValidInt(event);");
            txtNumeroFactura.Attributes.Add("onkeypress", "javascript:return ValidInt(event);");
            txtMCDespa.Attributes.Add("onkeypress", "javascript:return ValidInt(event);");
            txtMCSobran.Attributes.Add("onkeypress", "javascript:return ValidInt(event);");
           
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNumeroGuia.Text == "" ||
                    txtNumeroFactura.Text == "" ||
                    txtMCDespa.Text == "" ||
                    txtMCSobran.Text == "")
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alertIns", "alert('Faltan campos por llenar');", true);                    
                }
                else
                {

                    MetrosCubicosDespachadosClass MD = new MetrosCubicosDespachadosClass();
                    MD.NumGuia = int.Parse(txtNumeroGuia.Text);
                    MD.NumFactura = int.Parse(txtNumeroFactura.Text);
                    MD.MCDespachados = int.Parse(txtMCDespa.Text);
                    MD.MCSobrantes = int.Parse(txtMCSobran.Text);
                    MCD.new_MCDespachados(MD);
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
            MetrosCubicosDespachadosClass TraerDatos;
            try
            {
                if (MCD.consulta_MCD(int.Parse(txtNumeroGuia.Text)) == false)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alertIns", "alert('No existe registro');", true);   
                    txtNumeroGuia.Focus();
                }
                else
                {
                    TraerDatos = MCD.find_MCD(int.Parse(txtNumeroGuia.Text));
                    txtNumeroGuia.Text = Convert.ToString(TraerDatos.NumGuia);
                    txtNumeroFactura.Text = Convert.ToString(TraerDatos.NumFactura);
                    txtMCDespa.Text = Convert.ToString(TraerDatos.MCDespachados);
                    txtMCSobran.Text = Convert.ToString(TraerDatos.MCSobrantes);
                    txtNumeroGuia.Enabled = false;
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
                if (txtNumeroGuia.Text == "" ||
                    txtNumeroFactura.Text == "" ||
                    txtMCDespa.Text == "" ||
                    txtMCSobran.Text == "")
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alertIns", "alert('Faltan campos por llenar');", true);  
                }
                else
                {
                    MCD.update_MCDespachados(int.Parse(txtNumeroGuia.Text), int.Parse(txtNumeroFactura.Text), 
                                             int.Parse(txtMCDespa.Text), int.Parse(txtMCSobran.Text));
                    txtNumeroGuia.Enabled = true;
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
                MCD.delete_MCDespachados(int.Parse(txtNumeroGuia.Text));
                txtNumeroGuia.Enabled = true;
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
            txtNumeroGuia.Text = "";
            txtNumeroFactura.Text = "";
            txtMCDespa.Text = "";
            txtMCSobran.Text = "";
        }

        public static void RegisterStartupScript(Control control, Type type, string key, string script, bool addScriptTags)
        {

        }


    }
}

