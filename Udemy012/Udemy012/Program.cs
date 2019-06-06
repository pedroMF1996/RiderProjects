using System;
using  Udemy012.Entitys;
using Udemy012.Entitys.Exceptions;
namespace Udemy012
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Reservatio reservatio = null;
                Console.Write("Room number: ");
                int num = Int32.Parse(Console.ReadLine() ?? throw new DomainException("Entrada sem dados."));
                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkin =
                    DateTime.Parse(Console.ReadLine() ?? throw new DomainException("Entrada sem dados."));
                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime checkout =
                    DateTime.Parse(Console.ReadLine() ?? throw new DomainException("Entrada sem dados."));
                if (checkout > checkin)
                {
                    reservatio = new Reservatio(num, checkin, checkout);
                    Console.WriteLine($"Reservation: {reservatio}");

                    Console.WriteLine();

                    Console.WriteLine("Entre com os dados para atualizar a reserva: ");
                    Console.Write("Check-in date (dd/MM/yyyy): ");
                    DateTime checkinx =
                        DateTime.Parse(Console.ReadLine() ?? throw new DomainException("Entrada sem dados."));

                    Console.Write("Check-out date (dd/MM/yyyy): ");
                    DateTime checkoutx =
                        DateTime.Parse(Console.ReadLine() ?? throw new DomainException("Entrada sem dados."));

                    reservatio.UpdateDates(checkinx, checkoutx);

                    Console.WriteLine(reservatio);
                }
                else
                {
                    throw new DomainException(
                        "Erro na reserva, a data de check out deve ser posterior a data de check in.");
                }
            }
            catch (DomainException e)
            {
                Console.WriteLine($"Error in reservation: {e.Message}");
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Format error: {e.Message}");
            }
            catch (Exception ee)
            {
                Console.WriteLine($"Error: {ee.Message}");
            }
            
        }
    }
}