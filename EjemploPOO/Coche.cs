using System;

namespace EjemploPOO
{

    //Ejemplo Estados de un coche.
    //Heredamos de vehiculo
    //En este ejemplo veremos, Herencia, Abstraccion, sobrecarga, sobreescritura y manejo de errores.
    //Ejercicio propuesto:
    //Modificar esta clase que permita meter varios coches (un array) y cada uno de esos coches tenga un estado (tipoEstado)
    //Poder consultar el estado de cada uno de los coches mediante una funcion que liste dichos coches.
    public class Coche : Vehiculo
    {
        public Coche()
        {
            Estado = TipoEstado.Parado;
        }

        public Coche(TipoEstado estado)
        {
            Estado = estado;
        }
        
        public override void Acelerar()
        {
            if (Estado != TipoEstado.Parado)
            {
                Estado = TipoEstado.Acelerando;
            }
            else
            {
                throw new CambioEstadoException("No puedes acelerar un coche que está parado");
            }
        }

        public override void Arrancar()
        {
            if (Estado == TipoEstado.Parado)
            {
                Estado = TipoEstado.Arrancado;
            }
            else
            {
                throw new Exception("El coche ya está arrancado...");
            }
        }

        public override void Frenar()
        {
            if (Estado != TipoEstado.Parado)
            {
                Estado = TipoEstado.Arrancado;
            }
            else
            {
                throw new Exception("El coche está parado...");
            }
        }

        public override void Parar()
        {
            if (Estado != TipoEstado.Parado)
            {
                Estado = TipoEstado.Parado;
            }
            else
            {
                throw new Exception("El coche está parado...");
            }
        }
    }
}
