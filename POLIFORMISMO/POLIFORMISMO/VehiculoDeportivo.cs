using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POLIFORMISMO
{
    public class VehiculoDeportivo : vehiculo
    {
        //DEFINIR VARIABLE
        private int cilindraje;

        //CREAR CONSTRUCTOR
        public VehiculoDeportivo(int cilindraje, string matricula, string marca, string modelo) :
            base(matricula, marca, modelo)
        {
            this.cilindraje = cilindraje;
        }


        //METODO GETTER PARA RETORNAR EL NUMERO DE PUERTAS
        public int GetCilindraje()
        {
            return cilindraje;
        }


        public override string mostrarDatos()
        {
            return "Matricula: " + getMatricula() + "\nMarca: " + getMarca() +
                "\nModelo: " + getModelo() + "\nCilindraje: " + cilindraje;
        }
    }
}
