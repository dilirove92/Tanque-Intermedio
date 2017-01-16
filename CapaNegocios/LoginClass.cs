using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProyectoTanqueIntermedioEpam.CapaDatos;
using System.Windows.Forms;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoTanqueIntermedioEpam.CapaNegocios
{
    public class LoginClass
    {        
        BD_DespTanqInteEntities conexion { get; set; }
        BD_DespTanqInteEntities BD = new BD_DespTanqInteEntities();

        public string User { get; set; }
        public DateTime FechaIni { get; set; }
        public DateTime FechaFin { get; set; }

        public LoginClass()
        {
            conexion = new BD_DespTanqInteEntities();
        }

        public int new_Login(LoginClass login)
        {
            int idlogin=0;
            InicioSesion tabla = new InicioSesion();
            try
            {
                tabla.NombreUsua = login.User;
                tabla.FecHorIni = login.FechaIni; 
                tabla.FechHorFin = login.FechaFin;
                BD.AddToInicioSesions(tabla);
                BD.SaveChanges();
                idlogin = tabla.IdIS;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return idlogin;
        }
        
        public void End_Login(int login, string user, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                InicioSesion tabla = new InicioSesion();
                tabla = (from a in BD.InicioSesions
                         where a.IdIS == login
                         select a).FirstOrDefault();
                tabla.IdIS = login;
                tabla.NombreUsua = user;
                tabla.FecHorIni = FechaIni;
                tabla.FechHorFin = FechaFin;
                BD.Refresh(System.Data.Objects.RefreshMode.ClientWins, tabla);
                BD.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
