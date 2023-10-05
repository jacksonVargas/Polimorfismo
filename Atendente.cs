using System;

class Atendente : Imposto
{
    public override void ValeAlimentacao(double salario)
    {
        Console.WriteLine("Desconto do atendente vale alimentação R$" + (salario * 0.5));
    }
}