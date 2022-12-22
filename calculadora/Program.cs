using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    internal class Program
    {
        enum menu { Soma = 1, Subtração, Divisão, Multiplicação, Potencia, Raiz, Sair}

        static void Main(string[] args) 
        {
            bool sair = false;
            while(!sair)//Enquanto o usuario NÃO(!) ESCOLHER SAIR exiba o menu
            {
                Console.WriteLine("Seja bem vindo(a), selecione uma das opções:");
                Console.WriteLine("1 - Soma\n2 - Subtração\n3 - Divisão\n4 - Multiplicação\n5 - Potencia\n6 - Raiz\n7 - Sair");

                menu opcao = (menu)int.Parse(Console.ReadLine());

                switch (opcao)
                {

                    case menu.Soma:
                        soma();
                        break;

                    case menu.Subtração:
                        subtração();
                        break;

                    case menu.Divisão:
                        divisão();
                        break;

                    case menu.Multiplicação:
                        multiplicação();
                        break;

                    case menu.Potencia:
                        potencia();
                        break;

                    case menu.Raiz:
                        raiz();
                        break;

                    case menu.Sair:
                        sair = true;
                        break;
                }
                
                Console.Clear();
                                
            }



            

        }
        static void soma()
        {

            Console.WriteLine("Essa é uma soma de dois numeros!");
            Console.WriteLine("Digite o primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            int c = a + b;
            Console.WriteLine($"O resultado é: {c}");
            Console.WriteLine("Presione ENTER para voltar ao menu");
            Console.ReadLine();

        }
        static void subtração()
        {

            Console.WriteLine("Essa é uma subtração de dois numeros!");
            Console.WriteLine("Digite o primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            int c = a - b;
            Console.WriteLine($"O resultado é: {c}");
            Console.WriteLine("Presione ENTER para voltar ao menu");
            Console.ReadLine();

        }
        static void divisão()
        {

            Console.WriteLine("Essa é uma divisão de dois numeros!");
            Console.WriteLine("Digite o primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            float c = a / (float)b;
            Console.WriteLine($"O resultado é: {c}");
            Console.WriteLine("Presione ENTER para voltar ao menu");
            Console.ReadLine();

        }
        static void multiplicação()
        {

            Console.WriteLine("Essa é uma multiplicação de dois numeros!");
            Console.WriteLine("Digite o primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            int c = a * b;
            Console.WriteLine($"O resultado é: {c}");
            Console.WriteLine("Presione ENTER para voltar ao menu");
            Console.ReadLine();

        }
        static void potencia()
        {

            Console.WriteLine("Essa é uma potencia de um numero!");
            Console.WriteLine("Digite a base: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o expoente: ");
            int b = int.Parse(Console.ReadLine());
            int c = (int)Math.Pow(a, b);
            Console.WriteLine($"O resultado é: {c}");
            Console.WriteLine("Presione ENTER para voltar ao menu");
            Console.ReadLine();

        }
        static void raiz()
        {

            Console.WriteLine("Essa é uma raiz de um numero!");
            Console.WriteLine("Digite o numero: ");
            int a = int.Parse(Console.ReadLine());
            double b = Math.Sqrt(a);
            Console.WriteLine($"O resultado é: {b}");
            Console.WriteLine("Presione ENTER para voltar ao menu");
            Console.ReadLine();

        }
    }
}
