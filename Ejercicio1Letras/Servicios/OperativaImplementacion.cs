namespace Ejercicio1Letras.Servicios
{
    internal class OperativaImplementacion : OperativaInterfaz
    {
        public string pedidaNombre()
        {
            Console.WriteLine("Indique tu nombre: ");
            string nombre = Console.ReadLine();
            return nombre;
        }
        public string pedidaPrimerApellido()
        {
            Console.WriteLine("Indique tu primer apellido: ");
            string primerApellido = Console.ReadLine();
            return primerApellido;
        }
        public string pedidaSegundoApellido()
        {
            Console.WriteLine("Indique tu primer apellido: ");
            string segundoApellido = Console.ReadLine();
            return segundoApellido;
        }
        public int validacionNombre(string nombre, string primerApellido, string segundoApellido)
        {
            int valor;
            if (nombre.Equals(primerApellido) || nombre.Equals(segundoApellido))
            {
                Console.WriteLine("El nombre coincide con alguno de los apellidos");
                valor = 1;
            }
            else
            {
                valor = 0;
            }
            return valor;
        }
        public double pedidaNumeroDni()
        {
            Console.WriteLine("Indique el numero de su DNI");
            double numeroDni = Convert.ToInt64(Console.ReadLine());
            return numeroDni;
        }
        public string pedidaLetraDni()
        {
            Console.WriteLine("Indique la letra de su DNI");
            string letraDni = Console.ReadLine();
            return letraDni;
        }
        public int dniCompletoyValidacion(double numero, string letra)
        {
            string dniCompleto = numero + letra;
            String[] letrasDni = { "T", "R", "W", "A", "G", "M", "Y", "F", "P", "D", "X", "B", "N", "J", "Z", "S", "Q",
            "V", "H", "L", "C", "K", "E"};
            double i = numero % 23;
            string letraBuena = letrasDni[(int)i];
            int valor;
            if (letraBuena != letra)
            {
                Console.WriteLine("El dni esta mal");
                valor = 1;
            }
            else
            {
                valor = 0;
            }
            return valor;
        }
        public int codigoPostalYValidacion()
        {
            Console.WriteLine("Indique su codigo postal");
            int codigoPostal = Convert.ToInt32(Console.ReadLine());
            int[] postalesDeSevilla = { 41001 , 41002 , 41003 , 41004 , 41005 , 41006 , 41007 , 41008 ,
            41009, 41010, 41011, 41012, 41013, 41014, 41015, 41016, 41017, 41018, 41019, 41020, 41092};
            for ( int i = 0; i < postalesDeSevilla.Length; i++ )
            {
                if (postalesDeSevilla[i] == codigoPostal)
                {
                    Console.WriteLine("Su codigo postal es de sevilla");
                }
            }
            return codigoPostal;
        }


    }
}
