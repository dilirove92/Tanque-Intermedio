using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoTanqueIntermedioEpam.CapaNegocios;

namespace ProyectoTanqueIntermedioEpam.CapaPresentacion
{
    public partial class FormInicioSesion : System.Web.UI.Page
    {
        LoginClass Logins = new LoginClass();
        UsuarioClass Usuarios = new UsuarioClass();
        GestionUsuarioClass UsuarioPermiso = new GestionUsuarioClass();
        public static string userNow;
        public static string tipoNow;
        public static int salir;
        public static DateTime FechaSesion;
        public static string Horainicio;
        public static string HoraFin;
        public static int IdLogin;

        protected void Page_Load(object sender, EventArgs e)
        {
            userNow = null;
            salir = 0;
            txtUser.Attributes.Add("onkeypress", "javascript:return ValidText(event);");            
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUser.Text == "" ||
                    txtPass.Text == "")
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alertIns", "alert('Faltan campos por llenar');", true);                                                      
                }
                else
                {

                    UsuarioClass TraerDatos;
                    if (Usuarios.consulta_Usuario(txtUser.Text) == true)
                    {
                        TraerDatos = Usuarios.find_Usuario(txtUser.Text);
                        if (txtPass.Text.Equals(TraerDatos.ContraseñaUs))
                        {
                            if (UsuarioPermiso.devolver_permisos2(txtUser.Text) == true)
                            {
                                LoginClass Log = new LoginClass();
                                Log.User = txtUser.Text;
                                Log.FechaIni = DateTime.Now;
                                Log.FechaFin = DateTime.Now; 
                                IdLogin=Logins.new_Login(Log);
                                userNow = txtUser.Text;
                                tipoNow = TraerDatos.TipoUsuario;
                                FechaSesion = DateTime.Now;
                                Horainicio = DateTime.Now.Hour.ToString() + ':' + DateTime.Now.Minute.ToString();

                                Response.Redirect("FormMedidorIS.aspx");
                                Response.Close();
                            }
                            else
                            {
                                ScriptManager.RegisterStartupScript(this, this.GetType(), "alertIns", "alert('Falta Asignar Permisos');", true);
                            }
                        }
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "alertIns", "alert('Usuario o contraseña no válida.');", true); 
                        //Mostrar mensaje de contraseña erronea
                    }
                }
             
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }


        public static void RegisterStartupScript(Control control, Type type, string key, string script, bool addScriptTags)
        {

        }


    }
}