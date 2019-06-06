namespace Udemy009.Classes
{
    public class OutsourcedEmployee : Employee
    {
        private double _AdditionalCharge;

        public double AdditionalCharge => _AdditionalCharge;
        
        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge) : base(name, hours, valuePerHour)
        {
            _AdditionalCharge = additionalCharge;
        }

        public sealed override double Payment()
        {
            return base.Payment() + (AdditionalCharge * 1.1);
        }
    }
}