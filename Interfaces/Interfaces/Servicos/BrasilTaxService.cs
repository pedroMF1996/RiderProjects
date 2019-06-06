namespace Interface2.Servicos 
{
    public class BrasilTaxService
    {
        public double Tax(double amount)
        {
            return (amount <= 100.00)? amount * 0.2 : amount * 0.15;
        }
    }
}