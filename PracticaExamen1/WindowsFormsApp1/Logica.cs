using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Logica
    {
        public string PeriTiangulo(string lado1, string lado2, string lado3, string elOperador)
        {
            double Evalua1 = Convert.ToDouble(lado1);
            double Evalua2 = Convert.ToDouble(lado2);
            double Evalua3 = Convert.ToDouble(lado3);
            Enumerado operacion = convertir(elOperador);
            double? elresultado = realiza(Evalua1,Evalua2,Evalua3, operacion);
            string resultadoConvertido;
            if (elresultado != null)
            {
                resultadoConvertido = elresultado.ToString();
            }
            else
            {
                resultadoConvertido = "Error de calculo";
            }
            return resultadoConvertido;
        }
    

    private Enumerado convertir(String elOperador)
    {
        Enumerado resultado;
        switch (elOperador)
        {
            case "Perimetro":
            case "Peri":
                resultado = Enumerado.Perimetro;
                break;
            case "Area":
            case "are":
                resultado = Enumerado.area;
                break;
            default:
                resultado = Enumerado.desconocido;
                break;

        }
        return resultado;
    }

        private double? realiza (double lado1, double lado2, double lado3, Enumerado elOperador)
        {
            double? elRsultado = 0.0;
            switch (elOperador)
            {
                case Enumerado.Perimetro:
                    {
                        double mayor = 0;
                        if (lado1>mayor)
                        {
                            mayor = lado1;
                        }
                        else
                        {
                            if (lado2>mayor)
                            {
                                mayor = lado2;
                            }
                            else
                            {
                                mayor = lado3;
                            }
                        }
                        if ((lado1+lado2+lado3-mayor)>mayor)
                        {
                            elRsultado = (lado1 + lado2 + lado3);
                        }
                        else
                        {
                            elRsultado = null;
                        }
                       
                        break;
                    }
                case Enumerado.area:
                    {
                        break;
                    }
                case Enumerado.desconocido:
                    {
                        elRsultado = null;
                        break;
                    }
            }

            return elRsultado;
        }
    }


}
