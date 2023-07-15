using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;

namespace ConsoleApp1
{
    class Program
    
    {
        static void Main(string[] args)
        {
            string tipoVehiculo, servicio, esFiel,reinicio;
            decimal valor;
            PedirDatos(out tipoVehiculo, out servicio, out esFiel);
            valor = CalcularValor(tipoVehiculo, servicio, esFiel);
            
            MostrarResultados(valor, reinicio);
            }
static void PedirDatos(out string tipoVehiculo, out string servicio,out string esFiel)

{
    do
    {
        Console.WriteLine("Tipo vehiculo: [M]oto, [A]utomovil, [C]amioneta?........");
        tipoVehiculo = Console.ReadLine();
        tipoVehiculo = tipoVehiculo.ToUpper();
        if (tipoVehiculo != "M" &&
            tipoVehiculo != "A" &&
            tipoVehiculo != "C")
        {
            Console.WriteLine("Opcion no valida");
        }
    } while (tipoVehiculo != "M" && 
             tipoVehiculo != "A" && 
             tipoVehiculo != "C" );

    do
    {
        Console.WriteLine("Servicio: [S]encillo, [B]rillante, [P]remium? ");
        servicio = Console.ReadLine();
        servicio = servicio.ToUpper();
        if (servicio != "S" &&
            servicio != "B" &&
            servicio != "P")
        {
            Console.WriteLine("Opcion no valida");
        }
    }
while (servicio != "S" && 
servicio != "B" && 
servicio != "P" );
    do
    {
          Console.WriteLine("Tiene targeta de fidelidad: [S]i, [N]o..............");
          esFiel = Console.ReadLine();
          esFiel = esFiel.ToUpper();
          if (esFiel != "S" &&
              esFiel != "N" )
          {
              Console.WriteLine("Opcion no valida");
          }
    }
    while (esFiel != "S" && 
           esFiel != "N" );
        }

static decimal CalcularValor(string tipoVehiculo, string servicio, string esFiel)
{
    decimal valor;
    if (tipoVehiculo == "M")
    {
        if (servicio == "S") valor = 70;
        else if (servicio == "B") valor = 120;
        else valor = 150;
    }
    else if (tipoVehiculo == "P")
    {
        if (servicio == "S") valor = 90;
        else if (servicio == "B") valor = 140;
        else valor = 170;  
    }
    else
    {
        if (servicio == "C") valor = 100;
        else if (servicio == "B") valor = 160;
        else valor = 190; 
    }

    if (esFiel == "S") valor = valor * 0.9M;
    //iva
    valor = valor * 1.16M;
    return valor;

}

static void MostrarResultados(decimal valor, string reinicio)
{
    Console.WriteLine("El valor a pagar es: ${0}", valor);
    Console.ReadKey();
            Console.WriteLine("[Y] Ingresar otro auto, [E] Salir");
            Console.ReadKey();
            reinicio.ToUpper();
            if (reinicio != "Y" &&
              reinicio != "E")
            {
                Console.WriteLine("Opcion no valida");
            }if (reinicio == Y) Program.Restart(); ;
            else 
        }
    }
}