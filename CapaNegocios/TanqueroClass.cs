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
    public class TanqueroClass
    {        
        BD_DespTanqInteEntities conexion { get; set; }
        BD_DespTanqInteEntities BD = new BD_DespTanqInteEntities();

        public string PlacaTanq { get; set; }
        public int NumeroTanquero { get; set; }
        public int Capacidad { get; set; }
        public string Marca { get; set; }

        public TanqueroClass()
        {
            conexion = new BD_DespTanqInteEntities();
        }

        public void new_Tanquero(TanqueroClass Tq)
        {
            Tanquero tabla = new Tanquero();
            try
            {
                tabla.PlacaTanquero = Tq.PlacaTanq;
                //tabla.TanqueroNum = Tq.NumeroTanquero;
                tabla.Capacidad = Tq.Capacidad;
                tabla.Marca = Tq.Marca;
                BD.AddToTanqueroes(tabla);
                BD.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void update_Tanquero(string Placa,int Capacidad, string Marca)
        {
            try
            {
                Tanquero tabla = new Tanquero();
                tabla = (from a in BD.Tanqueroes
                         where a.PlacaTanquero == Placa
                         select a).FirstOrDefault();
                tabla.PlacaTanquero = Placa;
                //tabla.TanqueroNum = NumTanq;
                tabla.Capacidad = Capacidad;
                tabla.Marca =Marca;
                BD.Refresh(System.Data.Objects.RefreshMode.ClientWins, tabla);
                BD.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool consulta_Tanquero(string Placa)
        {
            Tanquero tabla = BD.Tanqueroes.FirstOrDefault(a => a.PlacaTanquero == Placa);
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


        public TanqueroClass find_Tanquero(string Placa)
        {
            TanqueroClass TanqueroDatos = new TanqueroClass();

            try
            {
                Tanquero tabla = new Tanquero();
                tabla = (from a in BD.Tanqueroes
                         where a.PlacaTanquero == Placa
                         select a).FirstOrDefault();
                TanqueroDatos.PlacaTanq = tabla.PlacaTanquero;
                TanqueroDatos.NumeroTanquero = tabla.TanqueroNum;
                TanqueroDatos.Capacidad = tabla.Capacidad;
                TanqueroDatos.Marca = tabla.Marca;
                return TanqueroDatos;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public void delete_Tanquero(string placa)
        {
            try
            {
                Tanquero tabla = new Tanquero();
                tabla = (from a in BD.Tanqueroes
                         where a.PlacaTanquero== placa
                         select a).FirstOrDefault();
                BD.DeleteObject(tabla);
                BD.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public List<TanqueroClass> devolver_tanqueroo()
        {
            List<TanqueroClass> lista_tanquero_TanqInter = new List<TanqueroClass>();

            foreach (var item in BD.Tanqueroes)
            {
                TanqueroClass Tanquerito = new TanqueroClass();
                Tanquerito.PlacaTanq = item.PlacaTanquero;
                Tanquerito.NumeroTanquero = item.TanqueroNum;
                Tanquerito.Capacidad = item.Capacidad;
                Tanquerito.Marca = item.Marca;
                lista_tanquero_TanqInter.Add(Tanquerito);
            }
            return lista_tanquero_TanqInter;
        }
    }
}
