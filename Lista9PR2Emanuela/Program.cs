using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista9PR2Emanuela
{
    internal class Program
    {
        public static void Exercicio1()
        {
            int[] vet2;


            Console.WriteLine("entre com o tamanho");
            int t = int.Parse(Console.ReadLine());

            vet2 = new int[t];
            Random rand = new Random();

            float soma = 0;

            for (int i = 0; i < t; i++)
            {
                vet2[i] = rand.Next(10, 50);
                soma = soma + vet2[i];

            }
            Console.WriteLine("A média é = " + soma / (float)t);


            for (int i = 0; i < t; i++)
            {
                Console.WriteLine("posicão[{0}] = {1}", i, vet2[i]);
            }

        }
        public static void Exercicio2()
        {
            int[] vet2;

            Console.WriteLine("entre com o tamanho");
            int t = int.Parse(Console.ReadLine());

            vet2 = new int[t];
            Random rand = new Random();

            float somapar = 0, somaimpar = 0;

            for (int i = 0; i < t; i++)
            {
                vet2[i] = rand.Next(10, 50);

                if (vet2[i] % 2 == 0)
                {
                    somapar = somapar + vet2[i];    
                }
                else
                {
                    somaimpar = somaimpar + vet2[i];
                }

            }
           
            Console.WriteLine("A soma dos números pares é = " + somapar);
            Console.WriteLine("A soma dos números impares é = " + somaimpar);



            for (int i = 0; i < t; i++)
            {
                Console.WriteLine("posicão[{0}] = {1}", i, vet2[i]);
            }
        }
        public static void Exercicio3()
        {
            int[] vet2;

            Console.WriteLine("entre com o tamanho");
            int t = int.Parse(Console.ReadLine());

            vet2 = new int[t];
            Random rand = new Random();          

            for (int i = 0; i < t; i++)
            {
                vet2[i] = rand.Next(10, 50);  

            }
           
            for (int i = 0; i < t; i++)
            {
                Console.WriteLine("posicão[{0}] = {1}", i, vet2[i]);
            }
            
            Console.WriteLine("/n");

            for (int i = t - 1; i >= 0; i--)
            {
                
                Console.WriteLine("posicão[{0}] = {1}", i, vet2[i]);
            }

        }
        public static void Exercicio4()
        {
            int[] vet2;

            Console.WriteLine("entre com o tamanho");
            int t = int.Parse(Console.ReadLine());

            vet2 = new int[t];
            Random rand = new Random();

            float soma = 0;

            for (int i = 0; i < t; i++)
            {
                vet2[i] = rand.Next(10, 50);
                soma = soma + vet2[i];

            }
            Console.WriteLine("A média é = " + soma / (float)t);


            for (int i = 0; i < t; i++)
            {
                Console.WriteLine("posicão[{0}] = {1}", i, vet2[i]);
            }
        }
      

        static void Main(string[] args)
        {
            int opcao;

            do
            {
                Console.WriteLine("====================================");
                Console.WriteLine("     Para Sair - digite 0           ");
                Console.WriteLine("Para executar exercício 1 - digite 1");
                Console.WriteLine("Para executar exercício 2 - digite 2");
                Console.WriteLine("Para executar exercício 3 - digite 3");
                Console.WriteLine("Para executar exercício 4 - digite 4");
                Console.WriteLine("Para executar exercício 5 - digite 5");
                Console.WriteLine("Para executar exercício 6 - digite 6");
                Console.WriteLine("Para executar exercício 7 - digite 7");
                Console.WriteLine("====================================");

                opcao = int.Parse(Console.ReadLine()); //lê a opção escolhida 

                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Obrigada, tchau!");
                        break;

                    case 1:
                        Exercicio1();
                        break;

                    case 2:
                        Exercicio2();
                        break;

                    case 3:
                        Exercicio3();
                        break;

                    case 4:
                        Exercicio4();
                        break;

                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }

               
            } while (opcao != 0);
        }
        
    }
}
  