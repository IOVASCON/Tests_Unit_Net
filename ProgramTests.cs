using Xunit;
using System.IO;
using System;

namespace ExemploTDD.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void Main_DeveEscreverResultadoNoConsole()
        {
            var output = new StringWriter();
            Console.SetOut(output);

            Program.Main(new string[] { });

            var resultado = output.ToString();
            Assert.Contains("2 + 3 = 5", resultado);
            Assert.Contains("5 - 3 = 2", resultado);
        }
    }
}
