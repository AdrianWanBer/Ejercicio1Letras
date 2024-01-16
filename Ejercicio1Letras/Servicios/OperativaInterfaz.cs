namespace Ejercicio1Letras.Servicios
{
    internal interface OperativaInterfaz
    {
        public string pedidaNombre();

        public string pedidaPrimerApellido();

        public string pedidaSegundoApellido();

        public int validacionNombre(string nombre, string primerApellido, string segundoApellido);

        public double pedidaNumeroDni();

        public string pedidaLetraDni();

        public int dniCompletoyValidacion(double numero, string letra);

        public int codigoPostalYValidacion();
    }
}
