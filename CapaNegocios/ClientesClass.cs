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
    public class ClientesClass
    {
        BD_DespTanqInteEntities conexion { get; set; }
        BD_DespTanqInteEntities BD = new BD_DespTanqInteEntities();

        public string CedulaCliente { get; set; }
        public string NombreCliente { get; set; }
        public string ApellidoCliente { get; set; }
        public string DireccionCliente { get; set; }
        public string TelefonoCliente { get; set; }

        public ClientesClass()
        {
            conexion = new BD_DespTanqInteEntities();
        }

        public void new_Cliente(ClientesClass Us)
        {
            Cliente tabla = new Cliente();
            try
            {
                tabla.CedRucClie = Us.CedulaCliente;
                tabla.NombreClie = Us.NombreCliente;
                tabla.ApellidoClie = Us.ApellidoCliente;
                tabla.DireccionCli = Us.DireccionCliente;
                tabla.TelefonoCli = Us.TelefonoCliente;
                BD.AddToClientes(tabla);
                BD.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void update_Cliente(string Ced_Cli, string Nom_cli, string Ape_cli, string Direc_Cli, string Telef_User)
        {
            try
            {
                Cliente tabla = new Cliente();
                tabla = (from a in BD.Clientes
                         where a.CedRucClie == Ced_Cli
                         select a).FirstOrDefault();
                tabla.CedRucClie = Ced_Cli;
                tabla.NombreClie = Nom_cli;
                tabla.ApellidoClie = Ape_cli;
                tabla.DireccionCli = Direc_Cli;
                tabla.TelefonoCli = Telef_User;
                BD.Refresh(System.Data.Objects.RefreshMode.ClientWins, tabla);
                BD.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool consulta_Clientes(string Ced_Cliente)
        {
            Cliente tabla = BD.Clientes.FirstOrDefault(a => a.CedRucClie ==Ced_Cliente);
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


        public ClientesClass find_Clientes(string Ced_Cliente)
        {
            ClientesClass ClientesDatos = new ClientesClass();

            try
            {
                Cliente tabla = new Cliente();
                tabla = (from a in BD.Clientes
                         where a.CedRucClie == Ced_Cliente
                         select a).FirstOrDefault();
                ClientesDatos.CedulaCliente = tabla.CedRucClie;
                ClientesDatos.NombreCliente = tabla.NombreClie;
                ClientesDatos.ApellidoCliente = tabla.ApellidoClie;
                ClientesDatos.DireccionCliente = tabla.DireccionCli;
                ClientesDatos.TelefonoCliente = tabla.TelefonoCli;
                return ClientesDatos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public void delete_Cliente(string Ced_Cli)
        {
            try
            {
                Cliente tabla = new Cliente();
                tabla = (from a in BD.Clientes
                         where a.CedRucClie == Ced_Cli
                         select a).FirstOrDefault();
                BD.DeleteObject(tabla);
                BD.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public List<ClientesClass> devolver_cliente()
        {
            List<ClientesClass> lista_cliente_TanqInter = new List<ClientesClass>();

            foreach (var item in BD.Clientes)
            {
                ClientesClass cliente = new ClientesClass();
                cliente.CedulaCliente = item.CedRucClie;
                cliente.NombreCliente = item.NombreClie;
                cliente.ApellidoCliente = item.ApellidoClie;
                cliente.DireccionCliente = item.DireccionCli;
                cliente.TelefonoCliente = item.TelefonoCli;
                lista_cliente_TanqInter.Add(cliente);
            }
            return lista_cliente_TanqInter;
        }

    }
}
