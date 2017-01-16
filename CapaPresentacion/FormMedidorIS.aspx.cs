using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoTanqueIntermedioEpam.CapaNegocios;

namespace ProyectoTanqueIntermedioEpam.CapaPresentacion
{
    public partial class FormMedidorIS : System.Web.UI.Page
    {        
        
        MedidorClass Medid = new MedidorClass();
        Medidor2Class Medid2 = new Medidor2Class();
        FormInicioSesion ini = new FormInicioSesion();
        LoginClass Loginn = new LoginClass();
        UsuarioClass Us = new UsuarioClass();
        public string user;
        public string tipoUser;
        public int MCToday = 0;
        public int MCSaveNow = 0;
        public static int id;
        public static int Lectura_Fin;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (FormInicioSesion.userNow == null)
            {
                Response.Redirect("FormInicioSesion.aspx");
            }

            lblFecha.Text = Convert.ToString(DateTime.Now);
            txtFecha.Text = Convert.ToString(DateTime.Now);
            txtFecha.Enabled = false;
            user = FormInicioSesion.userNow;
            txtUsuario.Text = user;
            txtUsuario.Enabled = false;
            tipoUser = FormInicioSesion.tipoNow;
            lblTipoUser.Text = tipoUser;
            lblTipoUser.Enabled = false;
            if (FormInicioSesion.salir == 0) 
            { 
                txtLecturaIni.Text = Convert.ToString(Medid.devolver_MC_TanqueIntermedio());
                txtLFinalAnterior.Text = Convert.ToString(Medid.devolver_MC_TanqueIntermedio());
            }
            txtLFinalAnterior.Enabled = false;
            txtLecturaFin.Enabled = false;

            txtLFinalAnterior.Attributes.Add("onkeypress", "javascript:return ValidInt(event);");
            txtLecturaIni.Attributes.Add("onkeypress", "javascript:return ValidInt(event);");
            txtLecturaFin.Attributes.Add("onkeypress", "javascript:return ValidInt(event);");
            txtFecha.Attributes.Add("onkeypress", "javascript:return ValidFecha(event);");
            txtMCAdicionales.Attributes.Add("onkeypress", "javascript:return ValidInt(event);");
            txtObservacion.Attributes.Add("onkeypress", "javascript:return ValidText(event);");
            txtUsuario.Attributes.Add("onkeypress", "javascript:return ValidText(event);");
            
            FormInicioSesion.HoraFin = DateTime.Now.Hour.ToString() + ':' + DateTime.Now.Minute.ToString();

            if (FormInicioSesion.salir == 1)
            {
                MedidorClass Datos = new MedidorClass();
                MCToday = Medid.devolver_despachados(FormInicioSesion.FechaSesion.ToString().Substring(0,10),
                                                     FormInicioSesion.Horainicio,
                                                     FormInicioSesion.HoraFin);
                MCSaveNow = MCToday;
                Datos = Medid2.find_Medidor(id);
                Lectura_Fin = Datos.LecturaFinal;
                txtLecturaIni.Text = Convert.ToString(Datos.LecturaInicial);
                txtFecha.Text = Convert.ToString(Datos.Fecha);
                txtLecturaFin.Enabled = false;
                txtMCAdicionales.Enabled = true;
                calcular_LecturaFin(MCSaveNow);
                FormInicioSesion.salir = 2;
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (FormInicioSesion.salir == 2)
                {
                    if ((MCSaveNow > MCToday) && txtObservacion.Text=="")
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "alertIns", "alert('Ingrese observación');", true);
                     }
                    else
                    {
                        Medid2.update_DetallesMedidor(id, int.Parse(txtLecturaIni.Text), int.Parse(txtLecturaFin.Text), 
                                                      DateTime.Parse(txtFecha.Text), txtObservacion.Text, txtUsuario.Text);
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "alertIns", "alert('El registro se modificó correctamente');", true);


                        Loginn.End_Login(FormInicioSesion.IdLogin, FormInicioSesion.userNow, FormInicioSesion.FechaSesion, DateTime.Now);
                        FormInicioSesion.userNow = null;
                        Response.Redirect("FormInicioSesion.aspx");
                    }
                }
                else
                {
                    if (txtLecturaIni.Text == null || txtUsuario.Text == null)
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "alertIns", "alert('Faltan campos por llenar');", true);
                    }
                    else
                    {

                        MedidorClass Md = new MedidorClass();
                        //Md.ID = int.Parse(txtID.Text);
                        Md.LecturaInicial = int.Parse(txtLecturaIni.Text);
                        Md.LecturaFinal = int.Parse(txtLecturaIni.Text);
                        Md.Fecha = DateTime.Parse(txtFecha.Text);
                        Md.observacion = txtObservacion.Text;
                        Md.NomUsuario = txtUsuario.Text;
                        id=Medid.new_DetallesMedidor(Md);
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "alertIns", "alert('El registro se guardó correctamente');", true);
                        //Limpiar();

                        Response.Redirect("FormMenu.aspx");
                        Response.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        protected void btnMCAdicionales_Click(object sender, ImageClickEventArgs e)
        {
            if (txtMCAdicionales.Text != null)
            {
                MCSaveNow = MCSaveNow + int.Parse(txtMCAdicionales.Text);
                calcular_LecturaFin(MCSaveNow);
                txtMCAdicionales.Text = "";
            }
        }

        public void calcular_LecturaFin(int numero)
        {
            Lectura_Fin = Lectura_Fin - numero;
            txtLecturaFin.Text = Convert.ToString(Lectura_Fin);
            txtLecturaFin.ForeColor = System.Drawing.Color.Black;
        }
    }
}