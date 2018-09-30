using System;

namespace ConsolePoupança
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaPoupança poupador1 = new ContaPoupança(2000.00);
            ContaPoupança poupador2 = new ContaPoupança(3000.00);

            Console.WriteLine("poupador1, 1°mes");
            Console.WriteLine(poupador1.calcularJuroMensal());
            Console.WriteLine("poupador2, 1°mes");
            Console.WriteLine(poupador2.calcularJuroMensal());
            ContaPoupança.alterarTaxaDeJuros(0.05);
            Console.WriteLine("poupador1, 2°mes");
            Console.WriteLine(poupador1.calcularJuroMensal());
            Console.WriteLine("poupador2, 2°mes");
            Console.WriteLine(poupador2.calcularJuroMensal());




            Console.WriteLine("\n\n\nPressione qualquer tecla para sair ...");
            Console.ReadKey(true);
        }
    }
}
