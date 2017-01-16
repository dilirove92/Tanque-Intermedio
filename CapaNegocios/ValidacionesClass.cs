using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using ProyectoTanqueIntermedioEpam.CapaDatos;

namespace ProyectoTanqueIntermedioEpam.CapaNegocios
{
    public class ValidacionesClass
    {
        BD_DespTanqInteEntities conexion { get; set; }
        BD_DespTanqInteEntities BD = new BD_DespTanqInteEntities();

        public ValidacionesClass()
        {
            conexion = new BD_DespTanqInteEntities();
        }

        public bool ValidacionPlaca(string parametro)
        {
            Regex expresion = new Regex("^([A-Z]{3}-[0-9]{3,4})$");

            if (expresion.IsMatch(parametro))
                return true;
            else
                return false;
        }

        public bool ValidacionCedula(string parametro)
        {
            Regex expresion = new Regex("^([0-9]{9}-[0-9]{1})$");

            if (expresion.IsMatch(parametro))
            {
                var Cedula = parametro.Substring(0, 9);
                var Verificador = parametro.Substring(10, 1);
                var suma = 0;
                var mod = 0;
                var res = 0;
                var temp = "";
                var unos = "";
                var dos = "";
                var el_numero = 0;

                for (int i = 0; i < Cedula.Length; i++)
                {
                    mod = 0;
                    if ((i % 2) == 0) { mod = 2; } else { mod = 1; }
                    el_numero = int.Parse(Cedula.Substring(i, 1));
                    res = el_numero * mod;
                    if (res > 9)
                    {
                        temp = res.ToString();
                        unos = temp.Substring(0, 1);
                        dos = temp.Substring(1, 1);
                        res = int.Parse(unos) + int.Parse(dos);
                    }
                    suma += res;
                }
                el_numero = (10 - (suma % 10)) % 10;
                if (el_numero == int.Parse(Verificador))
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
        
    }
}
