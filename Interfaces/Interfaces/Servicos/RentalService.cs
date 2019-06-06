using System;
using Interface2.Entities;

namespace Interfaces.Servicos
{
    public class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        private BrasilTaxService _brasilTaxService = new BrasilTaxService();

        public RentalService(double pricePerHour, double pricePerDay)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
        }

        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            double basicPayment = 0.00;
            
            basicPayment = (duration.TotalHours<=12)?
                (PricePerHour*Math.Ceiling(duration.TotalHours)):
                (PricePerDay*Math.Ceiling(duration.TotalDays));

            double tax = _brasilTaxService.Tax(basicPayment);
            
            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}