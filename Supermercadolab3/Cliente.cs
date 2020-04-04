using System;
namespace Supermercadolab3
{
    public class Cliente:Persona
    {
        public Cliente(string nombre, string apellido, int rut, string nacionalidad, string nacimiento) : base(nombre, apellido, rut, nacionalidad, nacimiento)
        {


        }

        public string Mostrarcliente()
        {
            return "Cliente: " + this.Nombre + " " + this.Apellido;

        }





    }
}
