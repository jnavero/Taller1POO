namespace EjemploPOO
{

    //Creamos una clase padre abstracta.
    //Para obligar la implementación en diferentes lugares.
    public abstract class Vehiculo
    {
        public enum TipoEstado
        {
            NoDefinido,
            Parado,
            Arrancado,
            Acelerando,
            Frenando
        }

        protected TipoEstado Estado { get; set; }

        public abstract void Arrancar();
        public abstract void Acelerar();
        public abstract void Frenar();
        public abstract void Parar();
    }
}
