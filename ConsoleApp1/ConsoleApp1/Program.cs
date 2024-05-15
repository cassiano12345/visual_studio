using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        enum cor { azul, verde, amerelo } //criar uma variavel com valores estaticos
        enum opcao { Criar=1, Deletar, Editar, Listar, Atualizar }

        static void fore()
        {
            string[] palavras = { "Carro", "Avião", "Navio", "Comboio", "Submarino" };

            foreach(string paralvra in palavras)
            {
                Console.WriteLine(paralvra);
            }
            Console.WriteLine("Fim da linha!!!");

        }

        static void Main(string[] args)
        {
            fore();
            Console.ReadLine();
            //teste_enum();
            //cor crofavorita = cor.azul;// tipo de variavel definida em cima
            //switch_();
            //Console.ReadLine();
            //Programa_Nome();
            //Programa_Idade();
            //somar(2, 10, 4);
            //Console.WriteLine(somar(2, 10, 4));
            //array_lista();
            //Console.ReadLine();
        }

        static void teste_enum()
        {
            Console.WriteLine("Selecione uma opção");
            Console.WriteLine("1-Criar\n2-Deletar\n3-Editar\n4-Listar\n5-Atualizar");
            int index = int.Parse(Console.ReadLine());
            opcao opcaoselecionada = (opcao)index;

            Console.WriteLine(opcaoselecionada);
            Console.ReadLine();

        }

        static void Programa_Idade() {
            //Programa para caulcular a idade
            int idade;
            Console.WriteLine("Digite a sua idade");
            idade = int.Parse(Console.ReadLine());

            if(idade >= 0 && idade <= 11)
            {
                Console.WriteLine("Voce é uma criança");
            }
            else if (idade >= 12 && idade <= 18)
            {
                Console.WriteLine("Voce é uma adolescente");
            }
            else
            {
                Console.WriteLine("Voce é um idoso");
            }

            Console.ReadLine();
        }

        static void Programa_Nome()
        {
            //Program para mostrar o nome
            //int valor1, valor2, resultado;
            string meuTexto;
            Console.WriteLine("Ola mundo!");
            Console.WriteLine("Digite o seu nome");
            meuTexto = Console.ReadLine();
            Console.WriteLine("O meu nome é: " + meuTexto);
            Console.ReadLine();
        }

        static int somar(int a , int b , int c) {
            int resultado = a + b + c;
            return resultado;
        }

        static void array_lista()
        {
            List<int> xpto = new List<int>() { 6, 7, 8, 9, 10 };
            int[] numeros = { 1, 2, 3, 4, 5 };
            string[] produtos = new string[5] {
            "PS5",
            "PS4",
            "PS3",
            "PS2",
            "PS1"
            };
            /*
            for (int i = 0; i < produtos.Length; i++)
            {
                Console.WriteLine(produtos[i]);
            }
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
            }*/
            for (int i = 0; i < xpto.Count; i++)
            {
                Console.WriteLine(xpto[i]);
            }
        }

        static void switch_()
        {
            string cor;
            Console.WriteLine ("Digite uma cor");
            cor=Console.ReadLine();

            switch (cor){

                case "Vermelho":
                    Console.WriteLine("A sua cor favorita é Vermelho");
                    break;
                case "Branco":
                    Console.WriteLine("A sua cor favorita é Branco");
                    break;
                case "Verde":
                    Console.WriteLine("A sua cor favorita é Verde");
                    break;
                case "Azul":
                    Console.WriteLine("A sua cor favorita é Azul");
                    break;
                default:
                    Console.WriteLine("A sua cor favorita não consta da Lista");
                    break;
            }
        }

        
    }
}
