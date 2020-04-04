using System;
namespace Supermercadolab3
{
    public class Productos
    {
        public string Nombreproducto;
        public int Precio;
        public string Marca;
        public int Stock;

        public Productos(string nombreproducto, int precio, string marca, int stock)
        {

            this.Nombreproducto = nombreproducto;
            this.Precio = precio;
            this.Marca = marca;
            this.Stock = stock;

        }

        public void Mostarinformacion()
        {
            Console.WriteLine("Nombre producto:{0}, Precio: {1}, Marca: {2}, Stock: {3}", Nombreproducto, Precio, Marca, Stock);

        }

        public string Getnombreproducto()
        {

            return Nombreproducto;
        }

        public bool Comprar()
        {
            if (Stock > 0)
            {

                Stock--;
                return true;

            }
            else
            {
                return false;
            }


        }







    }

}