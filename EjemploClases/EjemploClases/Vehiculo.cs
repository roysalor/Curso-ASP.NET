using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aplicacionVehiculosWeb
{
    public class Vehiculo
    {
        private int n_puertas = 0;
        private string marca = "";
        

        public Vehiculo(int num_puertas, string nombre_marca)
        {
            n_puertas = num_puertas;
            marca = nombre_marca;
        }

        public string getMarca() 
        {
            return marca;
        }

        public int getNumeroPuertas() 
        {
            return n_puertas;
        }
 

    }
}