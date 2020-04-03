using System;
namespace Supermercadolab3
{
    public class Persona
    {
        protected int RUT;
        protected string Nombre;
        protected string Apellido;
        protected DateTime Nacimiento;
        protected string Nacionalidad;






        public Persona(string nombre, string apellido, int rut, string nacionalidad ,string nacimiento)
        {

            this.Nombre = nombre;
            this.Apellido = apellido;
            this.RUT = rut;
            this.Nacionalidad = nacionalidad;
            this.Nacimiento = DateTime.Parse(nacimiento);

        }




        public void  Mostrarinformacion()
        {

            Console.WriteLine("Nombre: {0}, Apellido: {1}, Rut : {2}, Nacionalidad: {3}", Nombre, Apellido, RUT, Nacionalidad);
            
        }











    }
}

