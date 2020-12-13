using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsole
{

    public class Contabilidad
    {
        public double getSaldos(double saldoInicial)
        {
            double aux = saldoInicial + 1000 + saldoInicial * 0.1;
            return aux;
        }

        public string Saludos(string nombre = "Juan Pérez") //parámetros opcionales
        {
            return "Hola " + nombre + ", bienvenidos al Sistema de Contabilidad!!!";
        }


        public string Mes(int mes)
        {
            string aux = "";
            switch (mes)
            {
                case 1:
                    aux = "Enero"; break;
                case 2:
                    aux = "Febrero"; break;
                case 3:
                    aux = "Marzo"; break;
                case 4:
                    aux = "Abril"; break;
                case 5:
                    aux = "Mayo"; break;
                case 6:
                    aux = "Junio"; break;
                case 7:
                    aux = "Julio"; break;
                case 8:
                    aux = "Agosto"; break;
                case 9:
                    aux = "Septiembre"; break;
                case 10:
                    aux = "Octubre"; break;
                case 11:
                    aux = "Noviembre"; break;
                case 12:
                    aux = "Diciembre"; break;
                default:
                    aux = "Mes no válido"; break;

            } //fin switch
            return aux;
        }
        public string GetFecha(int d, int m, int an)
        {
            string aux1 = "Value";
            string aux2 = "False";
            if (d <= 31 && m <= 12 && an <= 2020)

                return aux1;

            else
            {
                return aux2;
            }

        }
    }
}

