using System;
using MaquinaCafe;

class Program
{
    static void Main()
    {
        var maquina = new MaquinaCafe.MaquinaCafe();
        string resultado = maquina.PrepararCafe("Grande", 2);
        Console.WriteLine(resultado);
    }
}
