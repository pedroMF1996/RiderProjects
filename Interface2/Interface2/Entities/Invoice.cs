using System.Globalization;

namespace Interface2.Entities
{
    public class Invoice
    {

        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public double TotalPayment
        {
            get { return BasicPayment + Tax; }
        }

        public override string ToString()
        {
            return $"Invoice: " +
                   $"\nBasic payment: {BasicPayment.ToString("f2",CultureInfo.InvariantCulture)}" +
                   $"\nTax: {Tax.ToString("f2",CultureInfo.InvariantCulture)}" +
                   $"\nTotal payment: {TotalPayment.ToString("f2",CultureInfo.InvariantCulture)}";
        }
    }
}