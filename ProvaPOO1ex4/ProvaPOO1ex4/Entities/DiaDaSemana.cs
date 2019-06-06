namespace ProvaPOO1ex4.Entities
{
    public abstract class DiaDaSemana
    {
        public static double DiaDaSemana(int mes, int D, int A, int S)
        {
            double result = 0.0;
            result = ((((2.6 * mes) - 0.1) + D - A + (A / 4) + (S / 4) - (2 * S)) % 7);
            return result;
        }
    }
}