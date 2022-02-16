using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace calculadoras
{
    /// <summary>
    /// Descripción breve de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod(Description = "Suma de numeros")]
        public double Suma(double nro1, double nr2)
        {
            double resultado;
            resultado = nro1 + nr2;
            return resultado;
        }

   
        private double Factorial(int n)
        {
            if (n == 0) return 1;
            else return n * Factorial(n-1);
        }
        [WebMethod(Description = "Factorial de un numero")]
        public double Fact(int n)
        {
            return Factorial(n);
        }

        [WebMethod(Description = "Resta de numeros")]
        public double Resta(double nro1, double nr2)
        {
            double resultado;
            resultado = nro1 - nr2;
            return resultado;
        }

        [WebMethod(Description = "Multiplicacion de numeros")]
        public double Multipllicar(double nro1, double nr2)
        {
            double resultado;
            resultado = nro1 * nr2;
            return resultado;
        }

        [WebMethod(Description = "Division de numeros")]
        public double Division(double nro1, double nr2)
        {
            double resultado;
            resultado = nro1 / nr2;
            return resultado;
        }

        [WebMethod(Description = "Potencia de numeros")]
        public double Potencia(double nro1, double nr2)
        {
            return Math.Pow(nro1,nr2);
        }
        [WebMethod(Description = "Raiz de dos numeros")]
        public double Raiz(double nro1)
        {
            return Math.Sqrt(nro1);
        }

        [WebMethod(Description = "Maximo comun de dos numeros")]
        public double Minimo(double nro1, double nr2)
        {
            int c = 2;
            int mcd = 1;
            while (c <= nro1 && c <= nr2)
            {
                while (nro1 % c == 0 && nr2 % c == 0) {
                    mcd = mcd * c;
                    nro1 = nr2 / c;
                    nr2 = nro1 / c;
                }
                c = c + 1;
            }
            return mcd;
        }
        [WebMethod(Description = "Sen de dos numeros")]
        public double Seno(double nro1)
        {
            return Math.Sin(nro1);
        }
        [WebMethod(Description = "Coseno de dos numeros")]
        public double Coseno(double nro1)
        {
            return Math.Cos(nro1);
        }
    }
}
