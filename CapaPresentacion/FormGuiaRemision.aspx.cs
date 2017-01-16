using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoTanqueIntermedioEpam.CapaNegocios;

namespace ProyectoTanqueIntermedioEpam.CapaPresentacion
{
    public partial class FormGuiaRemision : System.Web.UI.Page
    {
        GuiaRemisionClass GRC = new GuiaRemisionClass();
        ClientesClass clie = new ClientesClass();
        TransportistaClass trans = new TransportistaClass();
        FormInicioSesion ini = new FormInicioSesion();
        public string user;
        public string tipoUser;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (FormInicioSesion.userNow == null)
            {
                Response.Redirect("FormInicioSesion.aspx");
            }
            if (FormMenu.PermisosUser3.PGuardar) { btnGuardar.Enabled = true; } else { btnGuardar.Enabled = false; }
            if (FormMenu.PermisosUser3.PModificar) { btnModificar.Enabled = true; } else { btnModificar.Enabled = false; }
            if (FormMenu.PermisosUser3.PEliminar) { btnEliminar.Enabled = true; } else { btnEliminar.Enabled = false; }

            //cbxCedulaCli.DataSource = clie.devolver_cliente();
            //cbxCedulaCli.DataValueField = "CedulaCliente";
            //cbxCedulaCli.DataTextField = "CedulaCliente";
            //cbxCedulaCli.DataBind();
            //cbxCedulaTanquero.DataSource = trans.devolver_transportista();
            //cbxCedulaTanquero.DataValueField = "CedulaTransportista";
            //cbxCedulaTanquero.DataTextField = "CedulaTransportista";
            //cbxCedulaTanquero.DataBind();
            lblFecha.Text = Convert.ToString(DateTime.Now);
            user = FormInicioSesion.userNow;
            lblUser.Text = ("Bienvenid@: " + user + " | ");
            tipoUser = FormInicioSesion.tipoNow;
            lblTipoUser.Text = tipoUser;
            lblTipoUser.Enabled = false;
            
            txtGuiaRemision.Attributes.Add("onkeypress", "javascript:return ValidInt(event);");
            txtNumFactura.Attributes.Add("onkeypress", "javascript:return ValidInt(event);");
            txtFechaInicio.Attributes.Add("onkeypress", "javascript:return ValidFecha(event);");
            txtFechaFin.Attributes.Add("onkeypress", "javascript:return ValidFecha(event);");
            txtHoraDespacho.Attributes.Add("onkeypress", "javascript:return ValidHora(event);");
            cbxCedulaCli.Attributes.Add("onkeypress", "javascript:return ValidCed(event);");
            txtPuntoDestino.Attributes.Add("onkeypress", "javascript:return ValidDom(event);");
            cbxCedulaTanquero.Attributes.Add("onkeypress", "javascript:return ValidCed(event);");

        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtGuiaRemision.Text == "" ||
                    txtNumFactura.Text == "" ||
                    txtFechaInicio.Text == "" ||
                    txtFechaFin.Text == "" ||
                    txtHoraDespacho.Text == "" ||
                    cbxCedulaCli.Text == "" ||
                    txtPuntoDestino.Text == "" ||
                    cbxCedulaTanquero.Text == "")
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alertIns", "alert('Faltan campos por llenar');", true);                                                       
                }
                else
                {
                    GRC.update_GuiaRemision(int.Parse(txtGuiaRemision.Text), int.Parse(txtNumFactura.Text),
                                                  DateTime.Parse(txtFechaInicio.Text), DateTime.Parse(txtFechaFin.Text),
                                                  txtHoraDespacho.Text, cbxCedulaCli.Text, 
                                                  txtPuntoDestino.Text, cbxCedulaTanquero.Text);
                    txtGuiaRemision.Enabled = true;
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alertIns", "alert('El registro se modificó correctamente');", true);
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (//txtGuiaRemision.Text == "" ||
                    txtNumFactura.Text == "" ||
                    txtFechaInicio.Text == "" ||
                    txtFechaFin.Text == "" ||
                    txtHoraDespacho.Text == "" ||
                    cbxCedulaCli.Text == "" ||
                    txtPuntoDestino.Text=="" ||
                    cbxCedulaTanquero.Text == "")
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alertIns", "alert('Faltan campos por llenar');", true);                    
                }
                else
                {

                    GuiaRemisionClass GR = new GuiaRemisionClass();
                    //GR.GuiaRemision = int.Parse(txtGuiaRemision.Text);
                    GR.NumeFactura = int.Parse(txtNumFactura.Text);
                    GR.FechIniTrans = DateTime.Parse(txtFechaInicio.Text);
                    GR.FechFinTrans = DateTime.Parse(txtFechaFin.Text);
                    GR.HoraDespacho = txtHoraDespacho.Text;
                    GR.CedulaCliente = cbxCedulaCli.Text;
                    GR.PuntoDestino = txtPuntoDestino.Text;
                    GR.CedulaRucTransportista = cbxCedulaTanquero.Text;
                    GRC.new_GuiaRemision(GR);
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
            GuiaRemisionClass TraerDatos;
            try
            {
                if (GRC.consulta_NGuia(int.Parse(txtGuiaRemision.Text)) == false)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alertIns", "alert('No existe registro');", true);
                    txtGuiaRemision.Focus();
                }
                else
                {
                    TraerDatos=GRC.find_Guia(int.Parse(txtGuiaRemision.Text));
                    txtGuiaRemision.Text = Convert.ToString(TraerDatos.GuiaRemision);
                    txtNumFactura.Text = Convert.ToString(TraerDatos.NumeFactura);
                    txtFechaInicio.Text = Convert.ToString(TraerDatos.FechIniTrans);
                    txtFechaFin.Text = Convert.ToString(TraerDatos.FechFinTrans);
                    txtHoraDespacho.Text = Convert.ToString(TraerDatos.HoraDespacho);
                    cbxCedulaCli.Text = Convert.ToString(TraerDatos.CedulaCliente);
                    txtPuntoDestino.Text = Convert.ToString(TraerDatos.PuntoDestino);
                    cbxCedulaTanquero.Text = Convert.ToString(TraerDatos.CedulaRucTransportista);
                    txtGuiaRemision.Enabled = false;
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
                GRC.delete_GuiaRemision(int.Parse(txtGuiaRemision.Text));
                txtGuiaRemision.Enabled = true;
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
            txtGuiaRemision.Text = "";
            txtNumFactura.Text = "";
            txtFechaInicio.Text = "";
            txtFechaFin.Text = "";
            txtHoraDespacho.Text = "";
            cbxCedulaCli.Text = "";
            txtPuntoDestino.Text = "";
            cbxCedulaTanquero.Text = "";
        }


        public static void RegisterStartupScript(Control control, Type type, string key, string script, bool addScriptTags)
        {

        }

        protected void cbxCedulaCli_PreRender(object sender, EventArgs e)
        {
            cbxCedulaCli.DataSource = clie.devolver_cliente();
            cbxCedulaCli.DataValueField = "CedulaCliente";
            cbxCedulaCli.DataTextField = "CedulaCliente";
            cbxCedulaCli.DataBind();  
        }

        protected void cbxCedulaTanquero_PreRender(object sender, EventArgs e)
        {
            cbxCedulaTanquero.DataSource = trans.devolver_transportista();
            cbxCedulaTanquero.DataValueField = "CedulaTransportista";
            cbxCedulaTanquero.DataTextField = "CedulaTransportista";
            cbxCedulaTanquero.DataBind();
        }


    }
}

