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
    public class TransportistaClass
    {        
        BD_DespTanqInteEntities conexion { get; set; }
        BD_DespTanqInteEntities BD = new BD_DespTanqInteEntities();

        public string CedulaTransportista { get; set; }
        public string NombreTransportista { get; set; }
        public string ApellidoTransportista { get; set; }

        public TransportistaClass()
        {
            conexion = new BD_DespTanqInteEntities();
        }

        public void new_Transportista(TransportistaClass Trans)
        {
            Transportista tabla = new Transportista();
            try
            {
                tabla.CedRucTran = Trans.CedulaTransportista;
                tabla.NombreTran = Trans.NombreTransportista;
                tabla.ApellidoTRan = Trans.ApellidoTransportista;
                BD.AddToTransportistas(tabla);
                BD.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void update_Transportista(string CedulaT, string NombreT, string ApellidoT)
        {
            try
            {
                Transportista tabla = new Transportista();
                tabla = (from a in BD.Transportistas
                         where a.CedRucTran == CedulaT
                         select a).FirstOrDefault();
                tabla.CedRucTran = CedulaT;
                tabla.NombreTran = NombreT;
                tabla.ApellidoTRan = ApellidoT;
                BD.Refresh(System.Data.Objects.RefreshMode.ClientWins, tabla);
                BD.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool consulta_Transportista(string Ced_Transportista)
        {
            Transportista tabla = BD.Transportistas.FirstOrDefault(a => a.CedRucTran == Ced_Transportista);
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


        public TransportistaClass find_Transportista(string Ced_Transportista)
        {
            TransportistaClass TransportistaDatos = new TransportistaClass();

            try
            {
                Transportista tabla = new Transportista();
                tabla = (from a in BD.Transportistas
                         where a.CedRucTran == Ced_Transportista
                         select a).FirstOrDefault();
                TransportistaDatos.CedulaTransportista = tabla.CedRucTran;
                TransportistaDatos.NombreTransportista = tabla.NombreTran;
                TransportistaDatos.ApellidoTransportista = tabla.ApellidoTRan;
                return TransportistaDatos;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public void delete_transportista(string ced_trans)
        {
            try
            {
                Transportista tabla = new Transportista();
                tabla = (from a in BD.Transportistas
                         where a.CedRucTran == ced_trans
                         select a).FirstOrDefault();
                BD.DeleteObject(tabla);
                BD.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public List<TransportistaClass> devolver_transportista()
        {
            List<TransportistaClass> lista_transportista_TanqInter = new List<TransportistaClass>();

            foreach (var item in BD.Transportistas)
            {
                TransportistaClass transportista = new TransportistaClass();
                transportista.CedulaTransportista = item.CedRucTran;
                transportista.NombreTransportista = item.NombreTran;
                transportista.ApellidoTransportista = item.ApellidoTRan;
                lista_transportista_TanqInter.Add(transportista);
            }
            return lista_transportista_TanqInter;
        }

    }
}
