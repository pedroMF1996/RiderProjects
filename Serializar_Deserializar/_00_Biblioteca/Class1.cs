namespace _00_Biblioteca
{
    public class Usucario
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return $"Nome: {Nome}, Email: {Email}, CPF: {CPF}\n";
        }
    }
}