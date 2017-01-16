using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoTanqueIntermedioEpam.CapaNegocios;

namespace ProyectoTanqueIntermedioEpam.CapaPresentacion
{
    public partial class FormTanquero : System.Web.UI.Page
    {
        TanqueroClass Tanq = new TanqueroClass();
        ValidacionesClass Pla = new ValidacionesClass();
        FormInicioSesion ini = new FormInicioSesion();
        public string user;
        public string tipoUser;
        

        protected void Page_Load(object sender, EventArgs e)
        {
            if (FormInicioSesion.userNow == null)
            {
                Response.Redirect("FormInicioSesion.aspx");
            }

            if (FormMenu.PermisosUser8.PGuardar) { btnGuardar.Enabled = true; } else { btnGuardar.Enabled = false; }
            if (FormMenu.PermisosUser8.PModificar) { btnModificar.Enabled = true; } else { btnModificar.Enabled = false; }
            if (FormMenu.PermisosUser8.PEliminar) { btnEliminar.Enabled = true; } else { btnEliminar.Enabled = false; }

            lblFecha.Text = Convert.ToString(DateTime.Now);
            user = FormInicioSesion.userNow;
            lblUser.Text = ("Bienvenid@: " + user + " | ");
            tipoUser = FormInicioSesion.tipoNow;
            lblTipoUser.Text = tipoUser;
            lblTipoUser.Enabled = false;

            txtNumTanq.Attributes.Add("onkeypress", "javascript:return ValidInt(event);");
            txtMarca.Attributes.Add("onkeypress", "javascript:return ValidText(event);");
            txtCapacidad.Attributes.Add("onkeypress", "javascript:return ValidInt(event);");
            txtPlaca.Attributes.Add("onkeypress", "javascript:return ValidPlaca(event);");
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPlaca.Text == "" ||
                    txtCapacidad.Text == "" ||
                    txtMarca.Text == "" )
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alertIns", "alert('Faltan campos por llenar');", true);                   
                }
                else
                {
                    if (Pla.ValidacionPlaca(txtPlaca.Text))
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "alertIns", "alert('Cumple con el Patrón de la Placa \n Ejemplo: GOD-777 GOD-7777');", true);                       
                        //ValidacionesClass tanquero = new ValidacionesClass();
                        Tanq.PlacaTanq = txtPlaca.Text;
                        //Tan.NumeroTanquero = int.Parse(txtNumTanq.Text);
                        Tanq.Capacidad = int.Parse(txtCapacidad.Text);
                        Tanq.Marca=txtMarca.Text;
                        Tanq.new_Tanquero(Tanq);
                    }
                    else{
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "alertIns", "alert('NO cumple con el Patrón de la Placa \n Ejemplo: GOD-777 GOD-7777');", true);                                               
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
            TanqueroClass TraerDatos;
            try
            {
                if (Tanq.consulta_Tanquero(txtPlaca.Text) == false)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alertIns", "alert('No existe registro');", true);                    
                    txtPlaca.Focus();
                }
                else
                {
                    TraerDatos = Tanq.find_Tanquero(txtPlaca.Text);
                    txtPlaca.Text = TraerDatos.PlacaTanq;
                    txtNumTanq.Text = Convert.ToString(TraerDatos.NumeroTanquero);
                    txtCapacidad.Text = Convert.ToString(TraerDatos.Capacidad);
                    txtMarca.Text = Convert.ToString(TraerDatos.Marca);
                    txtPlaca.Enabled = false;
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
                if (txtPlaca.Text == "" ||
                    txtNumTanq.Text == "" ||
                    txtMarca.Text == "")
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alertIns", "alert('Faltan campos por llenar');", true);
                }
                else
                {
                    Tanq.update_Tanquero(txtPlaca.Text, int.Parse(txtCapacidad.Text), txtMarca.Text);
                    txtPlaca.Enabled = true;
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
                Tanq.delete_Tanquero(txtPlaca.Text);
                txtPlaca.Enabled = true;
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

        protected void txtPlaca_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();            
        }


        public void Limpiar()
        {
            txtPlaca.Text = "";
            txtNumTanq.Text = "";
            txtCapacidad.Text = "";
            txtMarca.Text = "";
        }


        public static void RegisterStartupScript(Control control, Type type, string key, string script, bool addScriptTags)
        {

        }

        //private void txtPlaca_Validated(object sender, EventArgs e)
        //{
        //    if (Tanq.ValidacionPlaca(txtPlaca.Text))
        //        //MessageBox.Show("Cumple con el Patrón de la Placa \n Ejemplo: GOD-777 GOD-7777");
        //        Label16.Text=("Cumple con el Patrón de la Placa \n Ejemplo: GOD-777 GOD-7777");
        //    else
        //        //MessageBox.Show("NO cumple con el Patrón de la Placa \n Ejemplo: GOD-777 GOD-7777");
        //        Label16.Text = ("NO cumple con el Patrón de la Placa \n Ejemplo: GOD-777 GOD-7777");
        //}
    }
}


