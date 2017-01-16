using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoTanqueIntermedioEpam.CapaNegocios;

namespace ProyectoTanqueIntermedioEpam.CapaPresentacion
{
    public partial class FormDetalleFactura : System.Web.UI.Page
    {
        DetalleFacturaClass Detalle = new DetalleFacturaClass();
        TanqueroClass Tanq = new TanqueroClass();
        ClientesClass Clie = new ClientesClass();
        FormInicioSesion ini = new FormInicioSesion();
        public string user;
        public string tipoUser;

        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (FormInicioSesion.userNow == null)
            {
                Response.Redirect("FormInicioSesion.aspx");
            }

            if (FormMenu.PermisosUser2.PGuardar) { btnGuardar.Enabled = true; } else { btnGuardar.Enabled = false; }
            if (FormMenu.PermisosUser2.PModificar) { btnModificar.Enabled = true; } else { btnModificar.Enabled = false; }
            if (FormMenu.PermisosUser2.PEliminar) { btnEliminar.Enabled = true; } else { btnEliminar.Enabled = false; }
            
            //cbxPlacaTanq.DataSource = Tanq.devolver_tanqueroo();
            //cbxPlacaTanq.DataValueField = "PlacaTanq";
            //cbxPlacaTanq.DataTextField = "NumeroTanquero";
            //cbxPlacaTanq.DataBind();
            //cbxCedulaCli.DataSource = Clie.devolver_cliente();
            //cbxCedulaCli.DataValueField = "CedulaCliente";
            //cbxCedulaCli.DataTextField = "CedulaCliente";
            //cbxCedulaCli.DataBind();

            lblFecha.Text = Convert.ToString(DateTime.Now);
            user = FormInicioSesion.userNow;
            lblUser.Text = ("Bienvenid@: " + user + " | ");
            tipoUser = FormInicioSesion.tipoNow;
            lblTipoUser.Text = tipoUser;
            lblTipoUser.Enabled = false;

            txtNumFactura.Attributes.Add("onkeypress", "javascript:return ValidInt(event);");
            txtNumControl.Attributes.Add("onkeypress", "javascript:return ValidInt(event);");
            txtFechaEmision.Attributes.Add("onkeypress", "javascript:return ValidFecha(event);");
            txtFechaFactura.Attributes.Add("onkeypress", "javascript:return ValidFecha(event);");
            cbxCedulaCli.Attributes.Add("onkeypress", "javascript:return ValidCed(event);");
            cbxPlacaTanq.Attributes.Add("onkeypress", "javascript:return ValidPlaca(event);");
            txtMCFacturados.Attributes.Add("onkeypress", "javascript:return ValidInt(event);");
            txtValorCancelado.Attributes.Add("onkeypress", "javascript:return ValidDecimal(event);");
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNumFactura.Text == "" ||
                    txtNumControl.Text == "" ||                   
                    txtFechaFactura.Text=="" ||
                    txtFechaEmision.Text==""||
                    cbxCedulaCli.Text == "" ||
                    cbxPlacaTanq.Text == "" ||
                    txtMCFacturados.Text == "" ||
                    txtValorCancelado.Text == "")
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alertIns", "alert('Faltan campos por llenar');", true);                                        
                }
                else
                {
                    
                    DetalleFacturaClass DT = new DetalleFacturaClass();
                    DT.NumFactura = int.Parse(txtNumFactura.Text);
                    DT.NumControl = int.Parse(txtNumControl.Text);
                    DT.FechEmision = DateTime.Parse(txtFechaEmision.Text);
                    DT.FechFact = DateTime.Parse(txtFechaFactura.Text);
                    DT.CedRucClie = cbxCedulaCli.Text;
                    DT.PlacaTanquero = cbxPlacaTanq.Text;
                    DT.MetCubFact = int.Parse(txtMCFacturados.Text);
                    DT.valorCancelado = decimal.Parse(txtValorCancelado.Text);
                    Detalle.new_detalleFactura(DT);
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
            DetalleFacturaClass TraerDatos;
            try
            {
                if (Detalle.consulta_Factura(int.Parse(txtNumFactura.Text)) == false)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alertIns", "alert('No existe registro');", true);                                                            
                    txtNumFactura.Focus();
                }
                else
                {
                    TraerDatos = Detalle.find_Factura(int.Parse(txtNumFactura.Text));
                    txtNumFactura.Text = Convert.ToString(TraerDatos.NumFactura);
                    txtNumControl.Text = Convert.ToString(TraerDatos.NumControl);
                    txtFechaEmision.Text = Convert.ToString(TraerDatos.FechEmision);
                    txtFechaFactura.Text = Convert.ToString(TraerDatos.FechFact);
                    cbxCedulaCli.Text = Convert.ToString(TraerDatos.CedRucClie);
                    cbxPlacaTanq.Text = Convert.ToString(TraerDatos.PlacaTanquero);
                    txtMCFacturados.Text = Convert.ToString(TraerDatos.MetCubFact);
                    txtValorCancelado.Text = Convert.ToString(TraerDatos.valorCancelado);
                    txtNumFactura.Enabled = false;
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
                if (txtNumFactura.Text == "" ||
                    txtNumControl.Text == "" ||
                    txtFechaEmision.Text == "" ||
                    txtFechaFactura.Text == "" ||
                    cbxCedulaCli.Text == "" ||
                    cbxPlacaTanq.Text == "" ||
                    txtMCFacturados.Text == "" ||
                    txtValorCancelado.Text == "")
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alertIns", "alert('Faltan campos por llenar');", true); 
                }
                else
                {
                    Detalle.update_DetalleFactura(int.Parse(txtNumFactura.Text), int.Parse(txtNumControl.Text), 
                                                  DateTime.Parse(txtFechaEmision.Text), DateTime.Parse(txtFechaFactura.Text),
                                                  cbxCedulaCli.Text, cbxPlacaTanq.Text, int.Parse(txtMCFacturados.Text), decimal.Parse(txtValorCancelado.Text));
                    txtNumFactura.Enabled = true;
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
                Detalle.delete_DetalleFactura(int.Parse(txtNumFactura.Text));
                txtNumFactura.Enabled = true;
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
            txtNumFactura.Text = "";
            txtNumControl.Text = "";
            txtFechaEmision.Text = "";
            txtFechaFactura.Text = "";
            cbxCedulaCli.Text = "";
            cbxPlacaTanq.Text = "";
            txtMCFacturados.Text = "";
            txtValorCancelado.Text = "";
        }

        public static void RegisterStartupScript(Control control, Type type, string key, string script, bool addScriptTags)
        {

        }

        protected void cbxCedulaCli_PreRender(object sender, EventArgs e)
        {
            cbxCedulaCli.DataSource = Clie.devolver_cliente();
            cbxCedulaCli.DataValueField = "CedulaCliente";
            cbxCedulaCli.DataTextField = "CedulaCliente";
            cbxCedulaCli.DataBind();
        }

        protected void cbxPlacaTanq_PreRender(object sender, EventArgs e)
        {
            cbxPlacaTanq.DataSource = Tanq.devolver_tanqueroo();
            cbxPlacaTanq.DataValueField = "PlacaTanq";
            cbxPlacaTanq.DataTextField = "PlacaTanq";
            cbxPlacaTanq.DataBind();
        }

    }
}

