using System;

namespace Supermercadolab3
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Persona persona1 = new Persona("ivan", "santivanez", 193242006, "chilena", "Jan 1, 2009");
            persona1.Mostrarinformacion();
            /*var date1 =  DateTime.Now.ToString("MM/dd/yyyy");
             Console.WriteLine(date1);*/
        }
    }
}
