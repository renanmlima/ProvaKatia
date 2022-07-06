using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaKatia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] funcionario = new string[500];
            int[] matric = new int[500];
            double[] salario = new double[500];

            for(int i=0; i<500; i++)
            {
                int aux = i;
                Console.Write("Insira o nome do funcionario "
                    +(aux + 1) +" : ");
                funcionario[i] = Console.ReadLine();

                Console.Write("Insira a matricula: ");
                matric[i] = Convert.ToInt32(Console.ReadLine());

                Console.Write("Insira o salário atual R$");
                salario[i] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
            }

            Console.WriteLine();
            for (int j = 0; j < 500; j++)
            {
                if (salario[j] <8000)
                {
                    Console.WriteLine(funcionario[j] +", Matrícula: " +matric[j] +"\nReajuste de 3,5%\n\nSalário Antigo: R$" + salario[j]);
                    salario[j] = salario[j]*1.035;
                    Console.WriteLine("Salário Novo: R$"+salario[j] +"\n---------------------------------");
                    Console.WriteLine();
                }

                else
                {
                    Console.WriteLine( funcionario[j] + ", Matrícula: " +matric[j] +"\nReajuste de 2,5%\n\nSalario Antigo: R$" + salario[j]);
                    salario[j] = salario[j] * 1.025;
                    Console.WriteLine("Salário Novo: R$" + salario[j] +"\n---------------------------------");

                    Console.WriteLine();
;                }
            }

            Console.ReadLine();




        }
    }
}
