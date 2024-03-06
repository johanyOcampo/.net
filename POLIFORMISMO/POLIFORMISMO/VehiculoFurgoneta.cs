using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POLIFORMISMO
{
    public class VehiculoFurgoneta : vehiculo
    {
        // DEFINIR LA VARIABLE
        private double carga;

        //CREAR CONTRUCTOR
        public VehiculoFurgoneta(double carga, string matricula, string marca, string modelo)
            : base(matricula, marca, modelo)
        {
            this.carga = carga;
        }

        //METODO GETTER PARA RETORNAR EL NUMERO DE PUERTAS
        public double GetCarga()
        {
            return carga;
        }

        public override string mostrarDatos()
        {
            return "Matricula: " + getMatricula() + "\nMarca: " + getMarca() +
                "\nModelo: " + getModelo() + "\nCarga: " + carga;
        }
    }
}
