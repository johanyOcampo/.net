using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POLIFORMISMO
{
    public class vehiculo
    {
        protected string matricula;
        protected string marca;
        protected string modelo;



        public vehiculo(string matricula, string marca, string modelo)
        {
            this.matricula = matricula;
            this.marca = marca;
            this.modelo = modelo;
        }


        public string getMatricula()
        {
            return matricula;
        }

        public string getMarca()
        {
            return marca;
        }

        public string getModelo()
        {
            return modelo;
        }

        //METODO QUE VA CAMBIAR DE ACUERDO A LA CLASE, RETORNA LA MATRICULA, LA MARCA, Y MODELO
        public virtual string mostrarDatos()
        {   //HACERLO VISIBLE AL USUARIO
            return "Matricula: " + matricula + "\nMarca: " + marca + "\nModelo: " + modelo;
        }
    }
}
