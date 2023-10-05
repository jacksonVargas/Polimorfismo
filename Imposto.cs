using System;

class Imposto 
{
    public virtual void ValeAlimentacao(double salario)
    {
        Console.WriteLine("Desconto total vale alimentação R$" + (salario * 0.1));
    }

    public void Valetransporte(double salario)
    {
        Console.WriteLine("Desconto total do vale transporte R$" + (salario * 0.15));
    }
}