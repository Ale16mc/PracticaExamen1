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
            Enumerado operacion = convertir
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
    }
}
