using System;

namespace EjemploPOO
{
    class Program
    {

        //Clase para explicar objetos y excepciones personalizadas...
        static void Main(string[] args)
        {
            Coche c = new Coche();
            try
            {
                c.Arrancar();
                Console.WriteLine("El coche ha arrancado");
                c.Parar();
                Console.WriteLine("El coche ha parado");
                c.Acelerar(); //Dará un error
            }
            catch (CambioEstadoException ex)
            {
                Console.WriteLine("El vehiculo no hace lo que quieres: {0}", ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Se ha producido un error: {0}", ex.Message);
            }

            Console.ReadKey();
        }
    }
}
