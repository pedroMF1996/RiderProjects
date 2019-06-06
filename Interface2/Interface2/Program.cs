using System;
using System.Globalization;
using Interface2.Entities;
using Interface2.Servicos;

namespace Interface2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*
             * Problema:
             * locação -    por hora até 12 horas
             *              por dia a cima de 12 horas
             * Além do valor da locação é acrecentado ao preço o imposto conforme regras do país
             * 20% valores até $100
             * 15% valores a cima de $100
             */
            
            /*
             * Solução do problema com interface
             */
            try
            {
                Console.WriteLine("Entre com os dados do aluguél");
                Console.Write("Car model: ");
                string model = Console.ReadLine();
                Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
                DateTime start = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
                Console.Write("Return (dd/MM/yyyy hh:mm): ");
                DateTime finish = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
                

                Console.Write("Entre com o preço por hora: ");
                double hour = Double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.Write("Entre com o preço por dia: ");
                double day = Double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                
                CarRental carRental = new CarRental(start, finish, new Vehicle(model));
                
                RentalService rentalService = new RentalService(hour, day, new BrasilTaxService());
                
                rentalService.ProcessInvoice(carRental);

                Console.WriteLine(carRental.Invoice);
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}