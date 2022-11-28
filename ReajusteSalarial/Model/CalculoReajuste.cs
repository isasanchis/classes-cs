using ReajusteSalarial.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReajusteSalarial.Model
{
    public class CalculoReajuste : ICalculoReajuste
    {
        public double Reajuste { get; set; }

        public double salario;
        public double reajuste;
        public int anos;

        ColaboradoresAntigos colaboradoresAntigos;

        public void Calculo()
        {
            Console.WriteLine("Digite o salário atual:");
            salario = Convert.ToDouble(Console.ReadLine());
            if (salario >= 7000)
            {
                Console.WriteLine("Seu novo salário com reajuste é: R$" + salario * 1.1);
                colaboradoresAntigos = new ColaboradoresAntigos(salario, anos);
            }
            else
            {
                Console.WriteLine("Escolha o reajuste desejado (5%, 10% ou 15%):");
                Reajuste = Convert.ToDouble(Console.ReadLine());

                switch (Reajuste)
                {
                    case 5:
                        Console.WriteLine("Seu novo salário com reajuste é: R$" + (salario * 1.05));
                        break;
                    case 10:
                        Console.WriteLine("Seu novo salário com reajuste é: R$" + (salario * 1.1));
                        break;
                    case 15:
                        Console.WriteLine("Seu novo salário com reajuste é: R$" + (salario * 1.15));
                        break;
                }
                colaboradoresAntigos = new ColaboradoresAntigos(salario, anos);

            }
        }

        public void MostraAnos()
        {
            bool saida = false;
            do
            {
                Console.WriteLine("Há quantos anos você está na empresa? (Digite apenas o número)");
                anos = int.Parse(Console.ReadLine());
                if (anos < 0)
                {
                    Console.WriteLine("Digite um número válido!");
                }
                else if (anos >= 3)
                {
                    {
                        Calculo();
                    }
                }
                else
                {
                    Console.WriteLine("Colaboradores novos (menos de 3 anos), não são elegíveis a reajuste.");
                }

                Console.WriteLine("Deseja encerrar? (s/n)");
                string escolhaContinuar = Console.ReadLine();

                switch (escolhaContinuar)
                {
                    case "s":
                        saida = true;
                        break;

                    case "n":
                        saida = false;
                        break;
                }
            } while (!saida);
        }

        void ICalculoReajuste.CalculoReajuste()
        {
            throw new NotImplementedException();
        }
    }
}
