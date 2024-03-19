using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpostoRenda
{
    internal class Program
    {

        static void Main(string[] args)
        {
            double valor = 0;
            Console.WriteLine("Digite a forma de contratação (A)assalariado, (C)comissionado, (H)horista: ");
            string fc = Console.ReadLine();

            switch (fc)
            {
                case "A":
                    Console.WriteLine("Digite o valor do seu salário bruto: ");
                    double sb = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o valor dos descontos: ");
                    double d = double.Parse(Console.ReadLine());

                     valor = sb - d;
                    Console.WriteLine("o valor do assalariado é " +  valor);
                break;
                case "C":
                    Console.WriteLine("Digite a quantidade de peças: ");
                    double qp = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o valor por peça: ");
                    double p = double.Parse(Console.ReadLine());

                    valor = qp * p;
                    Console.WriteLine("o valor do comissionado é " + valor);
                break;
                case "H":
                    Console.WriteLine("Digite o valor da hora: ");
                    double h = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite a quantidade de horas trabalhadas: ");
                    double ht = double.Parse(Console.ReadLine());

                    valor = h * ht;
                    Console.WriteLine("o valor do horista é " + valor);
                break;
                    default:
                    Console.WriteLine("Opção Inválida");
                    break;
            }

            if (valor <= 2000)
            {
                double ir = valor - valor * 0.075 ;
                Console.WriteLine("O valor sem o imposto será: " +  ir);
            }
            else if (valor < 4000)
            {
                double ir = valor - valor * 0.12;
                Console.WriteLine("O valor sem o imposto será: " + ir);
            }
            else if (valor > 4000)
            {
                double ir = valor - valor * 0.15;
                Console.WriteLine("O valor sem o imposto será: " + ir);
            }
            else
            {
                Console.WriteLine("Opção inválida");
            }

            Console.ReadKey();
        }
    }
}
