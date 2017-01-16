using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoTanqueIntermedioEpam.CapaNegocios;

namespace ProyectoTanqueIntermedioEpam.CapaPresentacion
{
    public partial class FormGuiaRemisionGeneral : System.Web.UI.Page
    {
        ClientesClass ObjClientes = new ClientesClass();
        ValidacionesClass cli = new ValidacionesClass();
        DetalleFacturaClass Detalle = new DetalleFacturaClass();
        GuiaRemisionClass GRC = new GuiaRemisionClass();
        MetrosCubicosDespachadosClass MCD = new MetrosCubicosDespachadosClass();
        TanqueroClass TANQUE = new TanqueroClass();
        TransportistaClass TRANSPOR = new TransportistaClass();
        FormInicioSesion ini = new FormInicioSesion();
        public static string ValorMC = "Metros Cúbicos";
        public static int MCSVS;
        public static int sobrante;
        public string user;
        public string tipoUser;
        public static int NFactura;
        public static int NGuiaR;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (FormInicioSesion.userNow == null)
            {
                Response.Redirect("FormInicioSesion.aspx");
            }

            if (FormMenu.PermisosUser4.PGuardar) { btnGuardar.Enabled = true; } else { btnGuardar.Enabled = false; }
            if (FormMenu.PermisosUser4.PModificar) { btnModificar.Enabled = true; } else { btnModificar.Enabled = false; }
            if (FormMenu.PermisosUser4.PEliminar) { btnEliminar.Enabled = true; } else { btnEliminar.Enabled = false; }
            if (FormMenu.PermisosUser4.PImprimir) { btnImprimir.Enabled = true; } else { btnImprimir.Enabled = false; }                    

            if (!Page.IsPostBack)
            {
                txtCedTransportista.DataSource = TRANSPOR.devolver_transportista();
                txtCedTransportista.DataValueField = "CedulaTransportista";
                txtCedTransportista.DataTextField = "CedulaTransportista";
                txtCedTransportista.DataBind();
                txtCedTransportista.Items.Insert(0, "-Seleccione un transportista-");

                txtPlaca.DataSource = TANQUE.devolver_tanqueroo();
                txtPlaca.DataValueField = "PlacaTanq";
                txtPlaca.DataTextField = "PlacaTanq";
                txtPlaca.DataBind();
                txtPlaca.Items.Insert(0, "-Seleccione una placa-");
            }             
            
            lblFecha.Text = Convert.ToString(DateTime.Now);
            user = FormInicioSesion.userNow;
            lblUser.Text = ("Bienvenid@: " + user + " | ");
            tipoUser = FormInicioSesion.tipoNow;
            lblTipoUser.Text = tipoUser;
            lblTipoUser.Enabled = false;

            txtPuntoPartida.Text = "Tanque Intermedio EPAM";
            txtUnidad.Text = ValorMC;

            txtDetalle.Text = "Venta - Despacho";
            
            txtNumFactura.Attributes.Add("onkeypress", "javascript:return ValidInt(event);");
            cbxNumeroGuia.Attributes.Add("onkeypress", "javascript:return ValidInt(event);");
            txtNumControl.Attributes.Add("onkeypress", "javascript:return ValidInt(event);");
            txtFechaEmision.Attributes.Add("onkeypress", "javascript:return ValidFecha(event);");
            txtFechaFactura.Attributes.Add("onkeypress", "javascript:return ValidFecha(event);");
            txtMCFacturados.Attributes.Add("onkeypress", "javascript:return ValidInt(event);");
            txtValorCancelado.Attributes.Add("onkeypress", "javascript:return ValidDecimal(event);");
            txtFechaInicioT.Attributes.Add("onkeypress", "javascript:return ValidFecha(event);");
            txtFechaFinT.Attributes.Add("onkeypress", "javascript:return ValidFecha(event);");
            txtPuntoPartida.Attributes.Add("onkeypress", "javascript:return ValidDom(event);");
            txtHoraDespacho.Attributes.Add("onkeypress", "javascript:return ValidHora(event);");

            txtCedCliente.Attributes.Add("onkeypress", "javascript:return ValidCed(event);");
            txtNomCliente.Attributes.Add("onkeypress", "javascript:return ValidText(event);");
            txtApellidos.Attributes.Add("onkeypress", "javascript:return ValidText(event);");
            txtDireccionCli.Attributes.Add("onkeypress", "javascript:return ValidDom(event);");
            txtTelefonoCli.Attributes.Add("onkeypress", "javascript:return ValidTel(event);");
            txtPuntoDestino.Attributes.Add("onkeypress", "javascript:return ValidDom(event);");

            txtCedTransportista.Attributes.Add("onkeypress", "javascript:return ValidCed(event);");
            txtNomTransportista.Attributes.Add("onkeypress", "javascript:return ValidText(event);");
            txtApelTransportista.Attributes.Add("onkeypress", "javascript:return ValidText(event);");

            txtNTanquero.Attributes.Add("onkeypress", "javascript:return ValidInt(event);");
            txtMarca.Attributes.Add("onkeypress", "javascript:return ValidText(event);");
            txtCapacidad.Attributes.Add("onkeypress", "javascript:return ValidInt(event);");
            txtPlaca.Attributes.Add("onkeypress", "javascript:return ValidPlaca(event);");

            txtCantidad.Attributes.Add("onkeypress", "javascript:return ValidInt(event);");
            txtUnidad.Attributes.Add("onkeypress", "javascript:return ValidText(event);");
            txtDetalle.Attributes.Add("onkeypress", "javascript:return ValidText(event);");

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            ///Cliente, Detalle, Guia, Metros Cubicos

            try
            {
                if (Detalle.consulta_Factura(int.Parse(txtNumFactura.Text)) == false) { MCSVS = 0; } else { retornar_acumulado(); }
                if ((int.Parse(txtCantidad.Text) <= MCSVS) || Detalle.consulta_Factura(int.Parse(txtNumFactura.Text)) == false)
                {
                    if (ObjClientes.consulta_Clientes(txtCedCliente.Text) == false)
                    {
                        ClientesClass Usu = new ClientesClass();
                        if (cli.ValidacionCedula(txtCedCliente.Text) == true)
                        {
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "alertIns", "alert ('Cumple con el Patrón de la Cédula');", true);
                            Usu.CedulaCliente = txtCedCliente.Text;
                            Usu.NombreCliente = txtNomCliente.Text;
                            Usu.ApellidoCliente = txtApellidos.Text;
                            Usu.DireccionCliente = txtDireccionCli.Text;
                            Usu.TelefonoCliente = txtTelefonoCli.Text;
                            ObjClientes.new_Cliente(Usu);
                        }
                        else
                        {
                            Usu = ObjClientes.find_Clientes(txtCedCliente.Text);
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "alertIns", "alert('No cumple con el Patrón de la Cédula');", true);
                        }
                    }

                    if (Detalle.consulta_Factura(int.Parse(txtNumFactura.Text)) == false)
                    {
                        if (cli.ValidacionCedula(txtCedTransportista.SelectedValue))
                        {
                            DetalleFacturaClass DT = new DetalleFacturaClass();
                            DT.NumFactura = int.Parse(txtNumFactura.Text);
                            DT.NumControl = int.Parse(txtNumControl.Text);
                            DT.FechEmision = DateTime.Parse(txtFechaEmision.Text);
                            DT.FechFact = DateTime.Parse(txtFechaFactura.Text);
                            DT.CedRucClie = txtCedCliente.Text;
                            DT.PlacaTanquero = txtPlaca.Text;
                            DT.MetCubFact = int.Parse(txtMCFacturados.Text);
                            DT.valorCancelado = decimal.Parse(txtValorCancelado.Text);
                            Detalle.new_detalleFactura(DT);
                        }
                        else
                        {
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "alertIns", "alert('No cumple con el Patrón de la Cédula');", true);
                        }
                    }

                    GuiaRemisionClass GR = new GuiaRemisionClass();
                    //GR.GuiaRemision = int.Parse(txtGuiaRemision.Text);
                    GR.NumeFactura = int.Parse(txtNumFactura.Text);
                    GR.FechIniTrans = DateTime.Parse(txtFechaInicioT.Text);
                    GR.FechFinTrans = DateTime.Parse(txtFechaFinT.Text);
                    GR.HoraDespacho = txtHoraDespacho.Text;
                    GR.CedulaCliente = txtCedCliente.Text;
                    GR.PuntoDestino = txtPuntoDestino.Text;
                    GR.CedulaRucTransportista = txtCedTransportista.SelectedValue;
                    int NGR = GRC.new_GuiaRemision(GR);

                    MetrosCubicosDespachadosClass MD = new MetrosCubicosDespachadosClass();
                    MD.NumGuia = NGR;
                    MD.NumFactura = int.Parse(txtNumFactura.Text);
                    MD.MCDespachados = int.Parse(txtCantidad.Text);
                    if (MCSVS == 0) { MD.MCSobrantes = int.Parse(txtMCFacturados.Text) - int.Parse(txtCantidad.Text); }
                    else { MD.MCSobrantes = MCSVS - int.Parse(txtCantidad.Text); }
                    MCD.new_MCDespachados(MD);

                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alertIns", "alert('El registro se guardó correctamente');", true);
                }
                else
                {
                    //ScriptManager.RegisterStartupScript(this, this.GetType(), "alertIns", "alert('Cantidad de metros cúbicos excede \nal valor restante de la factura \no ya no tiene metros cúbicos );", true);
                    lblMensaje.Text = "Cantidad de metros cúbicos excede al valor restante de la factura o ya no tiene metros cúbicos";
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        public void retornar_acumulado()
        {
            DetalleFacturaClass MCS = Detalle.find_Factura(int.Parse(txtNumFactura.Text));
            int MCSVC = 0, MCSVD = 0;
            //MCSVS = 0;
            MCSVC = MCS.MetCubFact;
            MCSVD = MCD.devolver_Sobrante(int.Parse(txtNumFactura.Text));
            MCSVS = MCSVC - MCSVD;
        }


        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtNumFactura.Text.Equals(null))
                {
                    retornar_acumulado();
                    //ScriptManager.RegisterStartupScript(this, this.GetType(), "alertIns", "alert('Esta Factura tiene'+MCSVS+' Metros Cúbicos por despachar');", true);                   
                    lblMensaje.Text = (Convert.ToString("Esta Factura tiene " + MCSVS + " Metros Cúbicos por despachar "));

                    cbxNumeroGuia.DataSource = GRC.devolver_guias(int.Parse(txtNumFactura.Text));
                    cbxNumeroGuia.DataValueField = "GuiaRemision";
                    cbxNumeroGuia.DataTextField = "GuiaRemision";
                    cbxNumeroGuia.DataBind();
                    cbxNumeroGuia.Items.Insert(0, "-Seleccione una guía-");

                    //Mejor implementar el campo metros cubicos sobrantes oki
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alertIns", "alert('Factura no existe');", true);
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
                ObjClientes.update_Cliente(txtCedCliente.Text, txtNomCliente.Text, txtApellidos.Text, txtDireccionCli.Text,
                                       txtTelefonoCli.Text);

                Detalle.update_DetalleFactura(int.Parse(txtNumFactura.Text), int.Parse(txtNumControl.Text),
                                              DateTime.Parse(txtFechaEmision.Text), DateTime.Parse(txtFechaFactura.Text),
                                              txtCedCliente.Text, txtPlaca.Text, int.Parse(txtMCFacturados.Text),
                                              decimal.Parse(txtValorCancelado.Text));

                GRC.update_GuiaRemision(int.Parse(cbxNumeroGuia.SelectedValue), int.Parse(txtNumFactura.Text),
                                        DateTime.Parse(txtFechaInicioT.Text), DateTime.Parse(txtFechaFinT.Text),
                                        txtHoraDespacho.Text, txtCedCliente.Text, txtPuntoDestino.Text, txtCedTransportista.SelectedValue);

                MCD.update_MCDespachados(int.Parse(cbxNumeroGuia.SelectedValue), int.Parse(txtNumFactura.Text), int.Parse(txtCantidad.Text),
                                         sobrante);

                ScriptManager.RegisterStartupScript(this, this.GetType(), "alertIns", "alert('El registro se modificó correctamente');", true);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            //No se debería Eliminar-ANALIZAR
            try
            {
                ObjClientes.delete_Cliente(txtCedCliente.Text);
                Detalle.delete_DetalleFactura(int.Parse(txtNumFactura.Text));
                GRC.delete_GuiaRemision(int.Parse(cbxNumeroGuia.SelectedValue));
                MCD.delete_MCDespachados(int.Parse(cbxNumeroGuia.SelectedValue));

                ScriptManager.RegisterStartupScript(this, this.GetType(), "alertIns", "alert('El registro se eliminó correctamente');", true);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        protected void btnSalir_Click(object sender, EventArgs e)
        {
            FormReportes.QueReporte = "";
            NFactura = 0;
            NGuiaR = 0;
            Response.Redirect("FormMenu.aspx");
        }

        protected void btnImprimir_Click(object sender, EventArgs e)
        {
            NFactura = int.Parse(txtNumFactura.Text);
            NGuiaR = int.Parse(cbxNumeroGuia.SelectedValue);
            FormReportes.QueReporte = "GuiaRemision";
            Response.Redirect("HojaDeReportes.aspx");
            //Falta eso
        }
                

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();                       
        }


        public void Limpiar()
        {
            txtNumFactura.Text = "";
            cbxNumeroGuia.Items.Clear();
            txtNumControl.Text = "";
            txtFechaEmision.Text = "";
            txtFechaFactura.Text = "";
            txtMCFacturados.Text = "";
            txtValorCancelado.Text = "";
            txtFechaInicioT.Text = "";
            txtFechaFinT.Text = "";
            txtPuntoPartida.Text = "";
            txtHoraDespacho.Text = "";

            txtCedCliente.Text = "";
            txtNomCliente.Text = "";
            txtApellidos.Text = "";
            txtDireccionCli.Text = "";
            txtTelefonoCli.Text = "";
            txtPuntoDestino.Text = "";

            txtNomTransportista.Text = "";
            txtApelTransportista.Text = "";

            txtMarca.Text = "";
            txtCapacidad.Text = "";
            txtNTanquero.Text = "";

            txtCantidad.Text = "";
            txtUnidad.Text = "";
            txtDetalle.Text = "";

            txtNumFactura.Enabled = true;
            habilitar();
            MCSVS = 0;

        }

        public void habilitar()
        {
            cbxNumeroGuia.Enabled = true;
            txtCedCliente.Enabled = true;
            txtCedTransportista.Enabled = true;
            txtNumControl.Enabled = true;
            txtPlaca.Enabled = true;
        }


        public static void RegisterStartupScript(Control control, Type type, string key, string script, bool addScriptTags)
        {

        }           
               

        protected void txtCedTransportista_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (TRANSPOR.consulta_Transportista(txtCedTransportista.Text) == true)
                {
                    TransportistaClass TraerDatosTranspor = new TransportistaClass();
                    TraerDatosTranspor = TRANSPOR.find_Transportista(txtCedTransportista.SelectedValue);
                    txtNomTransportista.Text = TraerDatosTranspor.NombreTransportista;
                    txtApelTransportista.Text = TraerDatosTranspor.ApellidoTransportista;
                    txtCedTransportista.Text = TraerDatosTranspor.CedulaTransportista;
                }
            }
            catch (Exception ex)
            {
                throw;
            }  
        }


        protected void txtPlaca_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (TANQUE.consulta_Tanquero(txtPlaca.Text) == true)
                {
                    TanqueroClass TraerDatosTanque = new TanqueroClass();
                    TraerDatosTanque = TANQUE.find_Tanquero(txtPlaca.SelectedValue);
                    txtCapacidad.Text = Convert.ToString(TraerDatosTanque.Capacidad);
                    txtMarca.Text = TraerDatosTanque.Marca;
                    txtNTanquero.Text = Convert.ToString(TraerDatosTanque.NumeroTanquero);
                    txtPlaca.Text = TraerDatosTanque.PlacaTanq;
                }
            }
            catch (Exception ex)
            {
                throw;
            }         
        }

        protected void cbxNumeroGuia_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClientesClass TraerDatosC = new ClientesClass();
            GuiaRemisionClass TraerDatosG = new GuiaRemisionClass();
            DetalleFacturaClass TraerDatosF = new DetalleFacturaClass();
            MetrosCubicosDespachadosClass TraerDatosMC = new MetrosCubicosDespachadosClass();
            TanqueroClass TraerDatosTanq = new TanqueroClass();
            TransportistaClass TraerDatosTrans = new TransportistaClass();

            try
            {
                if (GRC.consulta_NGuia(int.Parse(cbxNumeroGuia.Text)) == true)
                {
                    //......
                    TraerDatosG = GRC.find_Guia(int.Parse(cbxNumeroGuia.Text));
                    cbxNumeroGuia.Text = Convert.ToString(TraerDatosG.GuiaRemision);
                    //txtNumFactura.Text = Convert.ToString(TraerDatosG.NumeFactura);
                    txtFechaInicioT.Text = Convert.ToString(TraerDatosG.FechIniTrans);
                    txtFechaFinT.Text = Convert.ToString(TraerDatosG.FechFinTrans);
                    txtHoraDespacho.Text = Convert.ToString(TraerDatosG.HoraDespacho);
                    txtCedCliente.Text = Convert.ToString(TraerDatosG.CedulaCliente);
                    txtPuntoDestino.Text = Convert.ToString(TraerDatosG.PuntoDestino);
                    txtCedTransportista.SelectedItem.Text = Convert.ToString(TraerDatosG.CedulaRucTransportista);
                    //cbxNumeroGuia.Enabled = false;

                    TraerDatosF = Detalle.find_Factura(int.Parse(txtNumFactura.Text));
                    txtNumFactura.Text = Convert.ToString(TraerDatosF.NumFactura);
                    txtNumControl.Text = Convert.ToString(TraerDatosF.NumControl);
                    txtFechaEmision.Text = Convert.ToString(TraerDatosF.FechEmision);
                    txtFechaFactura.Text = Convert.ToString(TraerDatosF.FechFact);
                    txtCedCliente.Text = Convert.ToString(TraerDatosF.CedRucClie);
                    txtPlaca.Text = Convert.ToString(TraerDatosF.PlacaTanquero);
                    txtMCFacturados.Text = Convert.ToString(TraerDatosF.MetCubFact);
                    txtValorCancelado.Text = Convert.ToString(TraerDatosF.valorCancelado);
                    txtNumFactura.Enabled = false;

                    TraerDatosC = ObjClientes.find_Clientes(txtCedCliente.Text);
                    txtCedCliente.Text = Convert.ToString(TraerDatosC.CedulaCliente);
                    txtNomCliente.Text = Convert.ToString(TraerDatosC.NombreCliente);
                    txtApellidos.Text = Convert.ToString(TraerDatosC.ApellidoCliente);
                    txtDireccionCli.Text = Convert.ToString(TraerDatosC.DireccionCliente);
                    txtTelefonoCli.Text = Convert.ToString(TraerDatosC.TelefonoCliente);
                    txtCedCliente.Enabled = false;

                    TraerDatosTrans = TRANSPOR.find_Transportista(TraerDatosG.CedulaRucTransportista);
                    txtNomTransportista.Text = TraerDatosTrans.NombreTransportista;
                    txtApelTransportista.Text = TraerDatosTrans.ApellidoTransportista;
                    txtCedTransportista.SelectedItem.Value = TraerDatosTrans.CedulaTransportista;

                    TraerDatosTanq = TANQUE.find_Tanquero(txtPlaca.Text);
                    txtPlaca.SelectedItem.Value = TraerDatosTanq.PlacaTanq;
                    txtCapacidad.Text = Convert.ToString(TraerDatosTanq.Capacidad);
                    txtMarca.Text = TraerDatosTanq.Marca;
                    txtNTanquero.Text = Convert.ToString(TraerDatosTanq.NumeroTanquero);

                    TraerDatosMC = MCD.find_MCD(int.Parse(cbxNumeroGuia.SelectedValue));
                    txtNumFactura.Text = Convert.ToString(TraerDatosMC.NumFactura);
                    txtCantidad.Text = Convert.ToString(TraerDatosMC.MCDespachados);
                    sobrante = TraerDatosMC.MCSobrantes;
                }                
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                //Esto es para el botón de clientes
                if (ObjClientes.consulta_Clientes(txtCedCliente.Text) == true)
                {
                    ClientesClass TraerDatosCli = new ClientesClass();
                    TraerDatosCli = ObjClientes.find_Clientes(txtCedCliente.Text);
                    txtNomCliente.Text = Convert.ToString(TraerDatosCli.NombreCliente);
                    txtApellidos.Text = Convert.ToString(TraerDatosCli.ApellidoCliente);
                    txtDireccionCli.Text = Convert.ToString(TraerDatosCli.DireccionCliente);
                    txtTelefonoCli.Text = Convert.ToString(TraerDatosCli.TelefonoCliente);
                    txtCedCliente.Enabled = false;
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alertIns", "alert('No existe ese registro de cliente');", true);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        
       
    }
}