using System;

namespace Examen
{
    public class Program
    {
        static void Main(string[] args)
        {
        startConductor:
            Console.WriteLine(" ");
            Console.WriteLine("Ingrese los datos del conductor:");
            Conductor conductor = new Conductor();
            Console.WriteLine("Nombre:");
            conductor.Nombre_completo = Console.ReadLine();
            Console.WriteLine("Cedula:");
            conductor.Cedula = Console.ReadLine();
            Console.WriteLine("Direccion:");
            conductor.Direccion = Console.ReadLine();
            Console.WriteLine("Tipo de licencia:");
            conductor.Licencia = Console.ReadLine();
            Console.WriteLine("Fecha de nacimiento:");
            conductor.Fecha_de_nacimiento = Console.ReadLine();

            if (string.IsNullOrEmpty(conductor.Nombre_completo) || string.IsNullOrEmpty(conductor.Cedula) 
                || string.IsNullOrEmpty(conductor.Direccion) || string.IsNullOrEmpty(conductor.Licencia) 
                || string.IsNullOrEmpty(conductor.Fecha_de_nacimiento)) 
            {
                Console.WriteLine("Te falto llenar un espacio, por favor comience de nuevo.");
                goto startConductor;
            }

        startAgente:
            Console.WriteLine(" ");
            Console.WriteLine("Ingrese los datos del agente:");
            Agente agente = new Agente();
            Console.WriteLine("Nombre:");
            agente.Nombre_completo = Console.ReadLine();
            Console.WriteLine("Codigo de empleado:");
            agente.Codigo_de_empleado = Console.ReadLine();
            Console.WriteLine("Direccion:");
            agente.Direccion = Console.ReadLine();
            Console.WriteLine("Fecha de ingreso:");
            agente.Fecha_de_ingreso = Console.ReadLine();

            if (string.IsNullOrEmpty(agente.Nombre_completo) || string.IsNullOrEmpty(agente.Codigo_de_empleado)
                || string.IsNullOrEmpty(agente.Direccion) || string.IsNullOrEmpty(agente.Fecha_de_ingreso))
            {
                Console.WriteLine("Te falto llenar un espacio, por favor comience de nuevo.");
                goto startAgente;
            }

        startVehiculo:
            Console.WriteLine(" ");
            Console.WriteLine("Ingrese los datos del vehiculo:");
            Vehiculo vehiculo = new Vehiculo();
            Console.WriteLine("Placa:");
            vehiculo.Placa = Console.ReadLine();
            Console.WriteLine("Marca:");
            vehiculo.Marca = Console.ReadLine();
            Console.WriteLine("Modelo:");
            vehiculo.Modelo = Console.ReadLine();
            Console.WriteLine("Color:");
            vehiculo.Color = Console.ReadLine();
            Console.WriteLine("Numero de chasis:");
            vehiculo.Numero_de_chasis = Console.ReadLine();
            Console.WriteLine("Año:");
            vehiculo.Year = Console.ReadLine();

            if (string.IsNullOrEmpty(agente.Nombre_completo) || string.IsNullOrEmpty(agente.Codigo_de_empleado)
                || string.IsNullOrEmpty(agente.Direccion) || string.IsNullOrEmpty(agente.Fecha_de_ingreso))
            {
                Console.WriteLine("Te falto llenar un espacio, por favor comience de nuevo.");
                goto startAgente;
            }

        startInfraccion:
            Console.WriteLine("Ingrese el numero de infracciones cometidas:");
            int cantidad_infracciones = Convert.ToInt32(Console.ReadLine());
            T_infraccion infraccion = new T_infraccion(0);
            Console.WriteLine("");
            for (int x = 0; x < cantidad_infracciones; x++)
            {
                Console.WriteLine("Indique cual fue la infraccion:");
                Console.WriteLine("A) Obstruccion de transito   B) Pase de semaforo en rojo");
                Console.WriteLine("C) Usar el celular           D) Conducir sin el cinturon");
                Console.WriteLine("E) Licencia vencida");
                string tipo_de_infraccion = Console.ReadLine();
                if (tipo_de_infraccion == "A")
                {
                    infraccion.obstruccion();
                }
                if (tipo_de_infraccion == "B")
                {
                    infraccion.semaforo();
                }
                if (tipo_de_infraccion == "C")
                {
                    infraccion.celular();
                }
                if (tipo_de_infraccion == "D")
                {
                    infraccion.cinturon();
                }
                if (tipo_de_infraccion == "E")
                {
                    infraccion.lic_vencida();
                }
            }
            infraccion.Total();
        }
    }
}