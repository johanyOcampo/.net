using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POLIFORMISMO
{
    public class VehiculoTurismo : vehiculo
    {
        //DEFINIMOS LA VARIABLE
        private int nroPuertas;


        //CREAMOS EL CONSTRUCTOR 
        public VehiculoTurismo(int nroPuertas, string matricula, string marca, string
            modelo)
            :base(matricula, marca, modelo)
        {
            this.nroPuertas = nroPuertas;
        }

        //METODO GETTER PARA RETORNAR EL NUMERO DE PUERTAS
        public int GetNpuertas()
        {
            return nroPuertas;
        }

        public override string mostrarDatos()
        {
            return "Matricula: " + getMatricula() + "\nMarca: " + getMarca() + 
                "\nModelo: " + getModelo() + "\nNroPuertas: " + nroPuertas;
        }
    }

}
