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
    public class MedidorClass
    {        
        BD_DespTanqInteEntities conexion { get; set; }
        BD_DespTanqInteEntities BD = new BD_DespTanqInteEntities();

        //public int ID { get; set; }
        public int LecturaInicial { get; set; }
        public int LecturaFinal { get; set; }
        public DateTime Fecha{ get; set; }
        public string observacion { get; set; }
        public string NomUsuario { get; set; }

        public MedidorClass()
        {
            conexion = new BD_DespTanqInteEntities();
        }

        public int new_DetallesMedidor(MedidorClass Med)
        {
            Medidor tabla = new Medidor();
            int ID = 0;
            try
            {
                //tabla.IdMedidor = Med.ID;
                tabla.LectIni = Med.LecturaInicial;
                tabla.LectFin = Med.LecturaFinal;
                tabla.Fecha = Med.Fecha;
                tabla.Observacion = Med.observacion;
                tabla.NombreUsua = Med.NomUsuario;
                BD.AddToMedidors(tabla);
                BD.SaveChanges();
                ID = tabla.IdMedidor;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ID;
        }

        public int devolver_despachados(string fecha, string HoraInicio, string HoraFin)
        {
            int suma = 0;
            var query = BD.MC_Despachados_Hoy(fecha, HoraInicio, HoraFin);
            foreach (var item in query)
            {
                MetrosCubicosDespachadosClass MetrosC = new MetrosCubicosDespachadosClass();
                MetrosC.MCDespachados = item.MetrCubiDesp;
                suma += MetrosC.MCDespachados;
            }
            return suma;
        }

        public int devolver_MC_TanqueIntermedio()
        {
            int MC = 0;
            var query = BD.Ultimo_Valor_Medidor();
            foreach (var item in query)
            {
                MC = item.LectFin;
            }
            return MC;
        }

        //public void update_DetallesMedidor(int Medidor, int LecturaIni, int LecturaFin,
        //                                  DateTime Fecha, string Observacion, string User)
        //{
        //    try
        //    {
        //        Medidor tabla = new Medidor();
        //        tabla = (from a in BD.Medidors
        //                 where a.IdMedidor == Medidor
        //                 select a).FirstOrDefault();
        //        tabla.LectIni = LecturaIni;
        //        tabla.LectFin = LecturaFin;
        //        tabla.Fecha = Fecha;
        //        tabla.Observacion = Observacion;
        //        tabla.NombreUsua = User;
        //        BD.Refresh(System.Data.Objects.RefreshMode.ClientWins, tabla);
        //        BD.SaveChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //public void delete_DetallesMedidor(int num_med)
        //{
        //    try
        //    {
        //        Medidor tabla = new Medidor();
        //        tabla = (from a in BD.Medidors
        //                 where a.IdMedidor == num_med
        //                 select a).FirstOrDefault();
        //        BD.DeleteObject(tabla);
        //        BD.SaveChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //public bool consulta_Medidor(int Num_Medidor)
        //{
        //    Medidor tabla = BD.Medidors.FirstOrDefault(a => a.IdMedidor == Num_Medidor);
        //    try
        //    {
        //        if (!tabla.Equals(null))
        //        {
        //            return true;
        //        }
        //    }
        //    catch (Exception)
        //    { }
        //    return false;
        //}


        //public MedidorClass find_Medidor(int Num_Medidor)
        //{
        //    MedidorClass MedidorDatos = new MedidorClass();

        //    try
        //    {
        //        Medidor tabla = new Medidor();
        //        tabla = (from a in BD.Medidors
        //                 where a.IdMedidor == Num_Medidor
        //                 select a).FirstOrDefault();
        //        MedidorDatos.ID = tabla.IdMedidor;
        //        MedidorDatos.LecturaInicial = tabla.LectIni;
        //        MedidorDatos.LecturaFinal = tabla.LectFin;
        //        MedidorDatos.Fecha = tabla.Fecha;
        //        MedidorDatos.observacion = tabla.Observacion;
        //        MedidorDatos.NomUsuario = tabla.NombreUsua;
        //        return MedidorDatos;

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    return null;
        //}
    }
}
