using System;
namespace Supermercadolab3
{
    public class Cajero : Persona
    {


        private string Horario = null;

        private int Codigo_cajero;




        public Cajero(string nombre, string apellido, int rut, string nacionalidad, string nacimiento) : base(nombre, apellido, rut, nacionalidad, nacimiento)
        {


        }


        public void Setcodigocajero(int codigo_cajero)
        {

            this.Codigo_cajero = codigo_cajero;

        }



        public int Getcodigocajero()
        {

            return this.Codigo_cajero;

        }


        public string Gethorario()
        {

            return this.Horario;

        }

        public string Mostracajero()
        {

            return "Nombre:" + this.Nombre + "Apellido:" + this.Apellido + "esta en caja";

        }





    }
}
