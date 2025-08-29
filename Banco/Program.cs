using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //variables

            double MontoAr, SaldoInicialAr;
            int opcion;
            string NombreAr, ApellidoAr, DireccionAr, CedulaAr;

            //Creacion de la cuenta bancaria
            Console.Write("Estás a punto de crear una nueva cuenta bancaria, presiona cualquier tecla: ");
            Console.ReadKey();
            Console.Write("\nIngrese su nombre: ");
            NombreAr = Console.ReadLine();
            Console.Write("Ingrese su apellido: ");
            ApellidoAr = Console.ReadLine();
            Console.Write("Ingrese su direccion: ");
            DireccionAr = Console.ReadLine();
            Console.Write("Ingrese su cedula: ");
            CedulaAr = Console.ReadLine();
            Console.Write("Ingrese el saldo inicial: ");
            SaldoInicialAr = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el valor del primer deposito: $ ");
            MontoAr = Convert.ToDouble(Console.ReadLine());

            CuentaBancaria cliente = new CuentaBancaria(NombreAr, ApellidoAr, DireccionAr, CedulaAr, SaldoInicialAr);


            Console.Write("haz creado una nueva cuenta bancaria, felicitaciones, presiona cualquier tecla: ");
            Console.ReadKey();


            do {                 
                Console.WriteLine("Bienvenido al banco, " + NombreAr + " " + ApellidoAr);
                Console.WriteLine("\n1. Depositar");
                Console.WriteLine("2. Retirar");
                Console.WriteLine("3. Consultar saldo");
                Console.WriteLine("4. Mostrar datos de la cuenta");
                Console.WriteLine("5. Salir");
                Console.Write("Ingrese una opcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch(opcion)
                {
                    case 1:
                        {
                            Console.Write("Ingrese el monto a depositar: $ ");
                            MontoAr = Convert.ToDouble(Console.ReadLine());
                            cliente.Depositar(MontoAr);
                            Console.Write("Deposito exitoso, presiona cualquier tecla para continuar: ");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 2:
                        {
                            Console.Write("Ingrese el monto a retirar: $ ");
                            MontoAr = Convert.ToDouble(Console.ReadLine());
                            cliente.Retirar(MontoAr);
                            Console.Write("Retiro exitoso, presiona cualquier tecla para continuar: ");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 3:
                        {
                            cliente.ConsultarSaldo();
                            Console.Write("Presiona cualquier tecla para continuar: ");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine(cliente.ToString());
                            Console.Write("Presiona cualquier tecla para continuar: ");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 5:
                        {
                            Console.Write("Gracias por usar nuestro servicio, presiona cualquier tecla para salir: ");
                            Console.ReadKey();
                            break;
                        }
                    default:
                        {
                            Console.Write("Opcion no valida, presiona cualquier tecla para continuar: ");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
        }







            } while (opcion >= 1 && opcion <= 4);





        }
    }
}
