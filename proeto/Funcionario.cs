using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proeto
{
    class Funcionario:Pessoa
    {
        public int registro;
        public string setor;
        public string cargo;
        private double salario;


        public void cadastrarSalario(double sal)
        {
            
            if(sal < 0)
            {
                this.salario = 1000;

            }
            else
            {
                this.salario = sal;
            }
        }

        public void atualizaSalario(double sal)
        {
            if (this.salario < sal)
            {
                Console.WriteLine("Valor menor que salario atual");
                this.consultaSalario();

            }
            else
            {
                this.salario = sal; 
            }

        }

        public void consultaSalario()
        {
            Console.WriteLine("Funcionario:{0}",this.salario);
            Console.WriteLine();
        }
    }
}
