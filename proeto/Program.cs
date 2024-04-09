using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proeto
{
    class projeto
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario();
            Gerente g0 = new Gerente();
            g0.nome = "NAo sei";
            g0.cadastrarSalarioGerente(1000);
            g0.consultaSalario();

            f1.nome = "fiu fiu";
            f1.cargo = "segurança";
           
            f1.atualizaSalario(1010);
            f1.consultaSalario();
            Console.ReadKey();
        }
    }
}
