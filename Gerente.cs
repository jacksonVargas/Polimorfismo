using System;

class Gerente : Imposto
{
    public override void ValeAlimentacao(double salario)
    {
        Console.WriteLine("Desconto do gerente vale alimentação R$" + (salario * 0.12));
    }
}