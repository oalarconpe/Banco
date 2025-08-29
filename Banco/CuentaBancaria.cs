using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class CuentaBancaria
    {


        //Campos
        private string Nombre, Apellido, Direccion, Cedula;
        private double Saldo;


        //Constructor
        public CuentaBancaria(string NombrePa, string ApellidoPa, string DireccionPa, string CedulaPa, double SaldoPa)
        {
            Nombre = NombrePa;
            Apellido = ApellidoPa;
            Direccion = DireccionPa;
            Cedula = CedulaPa;
            Saldo = SaldoPa;
        }

        //Metodos
        public void Depositar(double MontoPa)
        {
            Saldo += MontoPa;
        }

        public void Retirar(double MontoPa)
        {
            if (MontoPa > Saldo)
            {
                Console.WriteLine("Fondos insuficientes");
            }
            else
            {
                Saldo -= MontoPa;
            }
        }

        public void ConsultarSaldo()
        {
            Console.WriteLine("El saldo actual es: " + Saldo);
        }

        public override string ToString()
        {
            return "Nombre: " + Nombre + "\nApellido: " + Apellido + "\nDireccion: " + Direccion + "\nCedula: " + Cedula + "\nSaldo: " + Saldo;
        }







    }
}
