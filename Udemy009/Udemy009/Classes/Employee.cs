using System;
using System.Globalization;

namespace Udemy009.Classes
{
    public class Employee : IComparable
    {
        private string _Name;
        private int _Hours;
        protected Double _ValuePerHour;

        public string Name => _Name;

        public int Hours => _Hours;

        public double ValuePerHour => _ValuePerHour;
        
        public Employee(string name, int hours, double valuePerHour)
        {
            _Name = name;
            _Hours = hours;
            _ValuePerHour = valuePerHour;
        }

        public virtual double Payment()
        {
            return (Hours * ValuePerHour);
        }

        public int CompareTo(object obj)
        {
            Employee outro = obj as Employee;
            return String.Compare(Name, outro.Name, StringComparison.Ordinal);
        }
    
        public override string ToString()
        {
            return $"{Name} - {Payment().ToString("C", CultureInfo.InvariantCulture)}";
        }
    }
}