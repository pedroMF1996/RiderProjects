using System.Globalization;

namespace IComparable.Entities
{
    public class Employee:System.IComparable
    {

        public string Nome { get; set; }
        public double Salario { get; set; }

        public Employee(string csvEmployee)
        {
            string[] vect = csvEmployee.Split(',');
            Nome = vect[0];
            Salario = double.Parse(vect[1], CultureInfo.InvariantCulture);
        }
        
        public int CompareTo(object obj)
        {
            Employee outro = (Employee) obj;
            return Salario.CompareTo(outro.Salario);
        }

        public override string ToString()
        {
            return $"{Nome}, {Salario.ToString("f2",CultureInfo.InvariantCulture)}";
        }
    }
}