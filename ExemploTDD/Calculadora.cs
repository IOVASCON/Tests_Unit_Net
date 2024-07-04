namespace ExemploTDD
{
    public class Calculadora
    {
        public int Adicionar(int a, int b) => a + b;
        public int Subtrair(int a, int b) => a - b;
        public int Multiplicar(int a, int b) => a * b;
        public int Dividir(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException("Divisor não pode ser zero.");
            return a / b;
        }
    }
}
