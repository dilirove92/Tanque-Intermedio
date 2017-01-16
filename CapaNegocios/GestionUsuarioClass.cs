using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProyectoTanqueIntermedioEpam.CapaDatos;

namespace ProyectoTanqueIntermedioEpam.CapaNegocios
{
    public class GestionUsuarioClass
    {
        BD_DespTanqInteEntities conexion { get; set; }
        BD_DespTanqInteEntities BD = new BD_DespTanqInteEntities();

        public int IdPermisosUsuarios { get; set; }
        public string CuentaUsuario { get; set; }
        public string NombreTabla { get; set; }
        public bool PAcceso { get; set; }
        public bool PGuardar { get; set; }
        public bool PModificar { get; set; }
        public bool PEliminar { get; set; }
        public bool PImprimir { get; set; }

        public GestionUsuarioClass()
        {
            conexion = new BD_DespTanqInteEntities();
        }

        public void new_Permisos(GestionUsuarioClass User)
        {
            UsuariosPermiso tabla = new UsuariosPermiso();
            try
            {
                tabla.IdPerUsu = User.IdPermisosUsuarios;
                tabla.Usuario = User.CuentaUsuario;
                tabla.Tabla = User.NombreTabla;
                tabla.Acceso = User.PAcceso;
                tabla.Guardar = User.PGuardar;
                tabla.Modificar = User.PModificar;
                tabla.Eliminar = User.PEliminar;
                tabla.Imprimir = User.PImprimir;
                BD.AddToUsuariosPermisos(tabla);
                BD.SaveChanges();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        public void delete_Permisos(string user)
        {
            try
            {
                UsuariosPermiso tabla = new UsuariosPermiso();
                tabla = (from a in BD.UsuariosPermisos
                         where a.Usuario == user
                         select a).FirstOrDefault();
                BD.DeleteObject(tabla);
                BD.SaveChanges();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        public void update_Permisos(string User, string NomTabla, bool PermitirAcceso,
                            bool PermisoGuardar, bool PermisoModificar, bool PermisoEliminar, bool PermisoImprimir)
        {
            try
            {
                UsuariosPermiso tabla = new UsuariosPermiso();
                tabla = (from a in BD.UsuariosPermisos
                         where a.Usuario == User && a.Tabla == NomTabla
                         select a).FirstOrDefault();
                tabla.Usuario = User;
                tabla.Tabla = NomTabla;
                tabla.Acceso = PermitirAcceso;
                tabla.Guardar = PermisoGuardar;
                tabla.Modificar = PermisoModificar;
                tabla.Eliminar = PermisoEliminar;
                tabla.Imprimir = PermisoImprimir;
                BD.Refresh(System.Data.Objects.RefreshMode.ClientWins, tabla);
                BD.SaveChanges();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        public bool consulta_Permiso(string user)
        {
            UsuariosPermiso tabla = BD.UsuariosPermisos.FirstOrDefault(a => a.Usuario == user);
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

        public List<GestionUsuarioClass> devolver_permisos(string User, string Table)
        {
            List<GestionUsuarioClass> lista_propietario_negocio = new List<GestionUsuarioClass>();

            foreach (var item in BD.UsuariosPermisos)
            {
                GestionUsuarioClass Permiso = new GestionUsuarioClass();
                Permiso.IdPermisosUsuarios = item.IdPerUsu;
                Permiso.CuentaUsuario = item.Usuario;
                Permiso.NombreTabla = item.Tabla;
                Permiso.PAcceso = item.Acceso;
                Permiso.PGuardar = item.Guardar;
                Permiso.PModificar = item.Modificar;
                Permiso.PEliminar = item.Eliminar;
                Permiso.PImprimir = item.Imprimir;
                if (item.Usuario == User && item.Tabla == Table)
                {
                    lista_propietario_negocio.Add(Permiso);
                }
                return lista_propietario_negocio;
            }
            return null;
        }

        public GestionUsuarioClass devolver_permisos1(string User, string Table)
        {
            foreach (var item in BD.UsuariosPermisos)
            {
                GestionUsuarioClass Permiso = new GestionUsuarioClass();
                Permiso.IdPermisosUsuarios = item.IdPerUsu;
                Permiso.CuentaUsuario = item.Usuario;
                Permiso.NombreTabla = item.Tabla;
                Permiso.PAcceso = item.Acceso;
                Permiso.PGuardar = item.Guardar;
                Permiso.PModificar = item.Modificar;
                Permiso.PEliminar = item.Eliminar;
                Permiso.PImprimir = item.Imprimir;
                if (Permiso.CuentaUsuario == User && Permiso.NombreTabla == Table)
                {
                    return Permiso;
                }
            }
            return null;
        }


        public Boolean devolver_permisos2(string User)
        {
            int contar = 0;
            foreach (var item in BD.UsuariosPermisos)
            {
                GestionUsuarioClass Permiso = new GestionUsuarioClass();
                Permiso.CuentaUsuario = item.Usuario;
                if (Permiso.CuentaUsuario == User)
                {
                    contar += 1;
                }
            }
            if (contar == 10)
                return true;
            else
                return false;
        }

    }
}
