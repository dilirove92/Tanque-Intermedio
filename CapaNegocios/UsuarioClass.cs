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
    public class UsuarioClass
    {
        BD_DespTanqInteEntities conexion { get; set; }
        BD_DespTanqInteEntities BD = new BD_DespTanqInteEntities();

        public string NomUsuario { get; set; }
        public string ApeUsuario { get; set; }
        public string Usuario { get; set; }
        public string ContraseñaUs { get; set; }
        public string CedulaUs { get; set; }
        public string TipoUsuario { get; set;}

        public UsuarioClass()
        {
            conexion = new BD_DespTanqInteEntities();
        }

        public void new_Usuario(UsuarioClass Us)
        {
            Usuario tabla = new Usuario();
            try
            {
                tabla.Usua = Us.Usuario;
                tabla.ContrasenaUsua = Us.ContraseñaUs;
                tabla.CedRucUsua = Us.CedulaUs;
                tabla.NombreUsuario = Us.NomUsuario;
                tabla.ApellidoUsuario = Us.ApeUsuario;
                tabla.TipoUsuario = Us.TipoUsuario;
                BD.AddToUsuarios(tabla);
                BD.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void update_user(string user, string Pass, string Ced_User, string Nom_user, string Ape_user, string Tipo_Usuario)
        {
            try
            {
                Usuario tabla = new Usuario();
                tabla = (from a in BD.Usuarios
                         where a.Usua == user
                         select a).FirstOrDefault();
                tabla.Usua = user;
                tabla.ContrasenaUsua = Pass;
                tabla.CedRucUsua = Ced_User;
                tabla.NombreUsuario = Nom_user;
                tabla.ApellidoUsuario = Ape_user;
                tabla.TipoUsuario = Tipo_Usuario;
                BD.Refresh(System.Data.Objects.RefreshMode.ClientWins, tabla);
                BD.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool consulta_Usuario(string Usuario)
        {
            Usuario tabla = BD.Usuarios.FirstOrDefault(a => a.Usua == Usuario);
            try
            {
                if (!tabla.Equals(null))
                {
                    return true;
                }
            }
            catch (Exception)
            { }
            return false;
        }


        public UsuarioClass find_Usuario(string Usuario)
        {
            UsuarioClass UsuarioDatos = new UsuarioClass();

            try
            {
                Usuario tabla = new Usuario();
                tabla = (from a in BD.Usuarios
                         where a.Usua == Usuario
                         select a).FirstOrDefault();
                UsuarioDatos.Usuario = tabla.Usua;
                UsuarioDatos.ContraseñaUs = tabla.ContrasenaUsua;
                UsuarioDatos.CedulaUs = tabla.CedRucUsua;
                UsuarioDatos.NomUsuario = tabla.NombreUsuario;
                UsuarioDatos.ApeUsuario = tabla.ApellidoUsuario;
                UsuarioDatos.TipoUsuario = tabla.TipoUsuario;
                return UsuarioDatos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public void delete_user(string user)
        {
            try
            {
                Usuario tabla = new Usuario();
                tabla = (from a in BD.Usuarios
                         where a.Usua == user
                         select a).FirstOrDefault();
                BD.DeleteObject(tabla);
                //BD.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
