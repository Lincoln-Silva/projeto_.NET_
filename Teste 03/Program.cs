using System;

namespace Teste_03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração das variáveis que serão utilizadas pelo programa, já inicializadas.
            string aluno = "", situacao = "";
            double notaSemestre1 = 0, notaSemestre2 = 0, media = 0;

            //Exibe mensagem de boas-vindas
            Console.WriteLine("Bem vindo ao Teste 03");

            while (true)
            {
                //Solicita ao usuário que informe o nome do aluno.
                Console.WriteLine("Informe o nome do Aluno:");
                aluno = Console.ReadLine();

                while (true)
                {
                    //Solicita a nota na prova.
                    Console.WriteLine($"Qual foi a nota do primeiro Semestre do aluno {aluno}?");
                    if (double.TryParse(Console.ReadLine(), out notaSemestre1))
                    {
                        //Interrompe o loop.
                        break;
                    }
                    //Exibe a mensagem de erro.
                    Console.WriteLine("Valor inválido! Por favor, insira um número válido.");
                }

                while (true)
                {
                    //Solicita a nota na prova.
                    Console.WriteLine($"Qual foi a nota do segundo Semestre do aluno {aluno}?");
                    if (double.TryParse(Console.ReadLine(), out notaSemestre2))
                    {
                        //Interrompe o loop.
                        break;
                    }
                    //Exibe a mensagem de erro.
                    Console.WriteLine("Valor inválido! Por favor, insira um número válido.");
                }
                //Calcula a média das notas.
                media = (notaSemestre1 + notaSemestre2) / 2;

                //Verifica se o aluno foi aprovado ou não
                if (media < 6.5)
                    situacao = "Reprovado";
                else
                    situacao = "Aprovado";

                //Exibe os resultados.
                Console.WriteLine($"Nome do aluno: {aluno}");
                Console.WriteLine($"Média:{media:G0}");
                Console.WriteLine($"O Aluno foi:{situacao}\n");
            }
        }
    }
}
