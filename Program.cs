using System;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Imposto estagiario = new Estagiario();
            estagiario.ValeAlimentacao(1500);
            estagiario.Valetransporte(1500);
            Console.WriteLine("--------------------");

            Imposto atendente = new Atendente();
            atendente.ValeAlimentacao(2500);
            atendente.Valetransporte(2500);
            Console.WriteLine("--------------------");

            Imposto gerente = new Gerente();
            gerente.ValeAlimentacao(5000);
            gerente.Valetransporte(5000);
        }
    }
}
