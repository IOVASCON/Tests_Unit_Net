namespace ExemploTDD
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var calculadora = new Calculadora();
            System.Console.WriteLine($"2 + 3 = {calculadora.Adicionar(2, 3)}");
            System.Console.WriteLine($"5 - 3 = {calculadora.Subtrair(5, 3)}");
        }
    }
}
