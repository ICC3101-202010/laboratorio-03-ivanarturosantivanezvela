using System;
namespace Supermercadolab3
{
    public class Caja
    {
        private int Codigocaja = 0;
        private bool Estado = false;
        private Cajero Personaacargo;
        private double recaudacion = 0;


        public Caja(int codigocaja)
        {

            this.Codigocaja = codigocaja;
        }
        public int Getcodigocaja()
        {
            return this.Codigocaja;

        }
        public bool Getestado()
        {
            return this.Estado;
        }

        public  Cajero Getcajeroencaja()
        {

            return this.Personaacargo;

        }
        public void Nuevocajero(Cajero cajeronuevo)
        {
            this.Personaacargo = cajeronuevo;

        }

        public string Vercaja()
        {
            string est;
            

            if (this.Getestado())
            {
                est = "Abierta";

            }
            else
            {
                est = "Cerrado";
            }
            if (this.Personaacargo!= null)
            {

                Cajero cajero = this.Getcajeroencaja();
                return "Caja Nº: " + this.Getcodigocaja() + " --> Estado de la caja: " + est + " --> Cajero a cargo: " + (string)cajero.Mostracajero();

            }
            else
            {
				return "Caja Nº: " + this.Getcodigocaja() + " --> Estado de la caja: " + est;
			}


            


        }






    }
}
