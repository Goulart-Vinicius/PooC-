using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoPooC_;
internal class ContaBancaria
{
    public int numeroIndicador;
    public string titular;
    public float saldo;
    public string senha;

    public void showinformations()
    {
        Console.WriteLine($"Titular : {titular}");
        Console.WriteLine($"Saldo : R${saldo}");
        Console.WriteLine($"Numero indicador : {numeroIndicador}");
        Console.WriteLine($"Senha : {senha}");
    }
}
