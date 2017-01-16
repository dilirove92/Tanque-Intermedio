//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using DespachoTanqueIntermedio.CapaDatos;
//using System.Windows.Forms;
//using System.Data.Objects;
//using System.Data.Objects.DataClasses;

//namespace DespachoTanqueIntermedio.CapaNegocios
//{
//    public class Tablas
//    {
//        BD_DespTanqInterEntities1 conexion { get; set; }
//        BD_DespTanqInterEntities1 bd = new BD_DespTanqInterEntities1();

//        public Tablas()
//        {
//            conexion = new BD_DespTanqInterEntities1();
//        }

//        public void Mostrar_datos(DataGridView grilla, TextBox NumFac)
//        {
//            try
//            {
//                grilla.Rows.Clear();
//                foreach (var item in bd.MostrarSoloDetallesFactura_por_NumeFactura(NumFac.Text))  //metodo mostrar entity
//                {
//                    grilla.Rows.Add(item.NumFactura, item.NumControl, item.FechEmision, item.FechFact, item.CedRucClie, item.NombreClie, item.DireccionClie, item.TelefonoClie, item.PlacaTanquero, item.MetrCubiFact, item.MetrCubiDesp, item.MetrCubiSobr, item.ValorCancelado);
//                }
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show(ex.Message);
//            }
//        }

//        public void RepoteDespacho_Fechas(DataGridView grilla, TextBox Fech1, TextBox Fech2)
//        {
//            try
//            {
//                grilla.Rows.Clear();
//                foreach (var item in bd.ReporteDespacho_entre_fechas(DateTime.Parse(Fech1.Text), DateTime.Parse(Fech2.Text))) //metodo mostrar entity
//                {
//                    grilla.Rows.Add(item.FechInicTras, item.FechFinTras, item.NumFactura, item.ReferRemis, item.MetrCubiDesp);
//                }
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show(ex.Message);
//            }
//        }

//        public void RepoteDespacho_Fecha(DataGridView grilla, TextBox Fech1)
//        {
//            try
//            {
//                grilla.Rows.Clear();
//                foreach (var item in bd.ReporteDespacho_por_Fecha(DateTime.Parse(Fech1.Text))) //metodo mostrar entity
//                {
//                    grilla.Rows.Add(item.FechInicTras, item.NumFactura, item.ReferRemis, item.MetrCubiDesp);
//                }
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show(ex.Message);
//            }
//        }

//        public void RepoteDespacho_NumFactura(DataGridView grilla, TextBox Numfactura)
//        {
//            try
//            {
//                grilla.Rows.Clear();
//                foreach (var item in bd.ReporteDespacho_por_NumFactura(Numfactura.Text)) //metodo mostrar entity
//                {
//                    grilla.Rows.Add(item.NumFactura, item.CedRucClie, item.NombreClie, item.MetrCubiDesp, item.MetrCubiSobr);
//                }
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show(ex.Message);
//            }
//        }

//        public void ReporteDespacho_NumRemision(DataGridView grilla, TextBox NumRemision)
//        {
//            try
//            {
//                grilla.Rows.Clear();
//                foreach (var item in bd.ReporteDespacho_por_NumRemision(int.Parse(NumRemision.Text))) //metodo mostrar entity
//                {
//                    grilla.Rows.Add(item.ReferRemis, item.NumFactura, item.FechInicTras, item.FechFinTras, item.HoraDespacho, item.CedRucClie, item.NombreClie, item.PuntoDestino, item.CedRucTran, item.NombreTran, item.MetrCubiDesp);
//                }
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show(ex.Message);
//            }
//        }

//        public void AudiDatosMedidor_Fecha(DataGridView grilla, TextBox dato)
//        {
//            try
//            {
//                grilla.Rows.Clear();
//                foreach (var item in bd.AudiDatosMedidor_por_Fecha(DateTime.Parse(dato.Text))) //metodo mostrar entity
//                {
//                    grilla.Rows.Add(item.IdMedidor, item.LectIni, item.LectFin, item.Fecha, item.Observacion, item.NombreUsua);
//                }
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show(ex.Message);
//            }
//        }

//        public void AudiDatosMedidor_por_NombreUsua(DataGridView grilla, TextBox NombreUsuario)
//        {
//            try
//            {
//                grilla.Rows.Clear();
//                foreach (var item in bd.AudiDatosMedidor_por_NombreUsua(NombreUsuario.Text)) //metodo mostrar entity
//                {
//                    grilla.Rows.Add(item.IdMedidor, item.LectIni, item.LectFin, item.Fecha, item.Observacion, item.NombreUsua);
//                }
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show(ex.Message);
//            }
//        }


//    }
//}

