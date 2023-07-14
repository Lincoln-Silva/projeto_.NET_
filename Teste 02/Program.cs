using System;

namespace Teste_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração das variáveis que serão utilizadas pelo programa, já inicializadas.
            string nome = "";
            double nota = 0, totalNota = 0, media = 0;
            int quantidadeProvas = 0;

            //Solicita ao usuário que informe o seu nome.
            Console.WriteLine("Bem vindo ao Teste 02, para iniciarmos qual é o seu nome?");
            nome = Console.ReadLine();

            while (true)
            {             
                while (true)
                {
                    //Solicita a nota na prova.
                    Console.WriteLine("{0} por favor, nos informe qual foi sua nota na prova?", nome);
                    if (double.TryParse(Console.ReadLine(), out nota))
                    {
                        //Interrompe o loop.
                        break;
                    }
                    //Exibe a mensagem de erro.
                    Console.WriteLine("Valor inválido! Por favor, insira um número válido.");
                }

                //Soma o valor da nota ao Total de Nota.
                totalNota += nota;

                //Aumenta a quantidade de provas em 1.
                quantidadeProvas++;

                //Calcula a média das notas.
                media = totalNota / quantidadeProvas;

                //Exibe os resultados.
                Console.WriteLine("Nome: {0}", nome);
                Console.WriteLine("Quantidade de provas: {0}", quantidadeProvas);
                Console.WriteLine("Total de Nota:{0}", totalNota);
                Console.WriteLine("Sua média é de {0}\n", media);
            }
        }
    }
}
