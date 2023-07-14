using System;

namespace Teste_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração das variáveis que serão utilizadas pelo programa.
            //O tipo delas é double porque as notas podem conter valores decimais.
            double notaSemestre1, notaSemestre2, media;

            //O uso do while permite que o sistema solicite a entrada novamente se o valor não for um número válido.
            while (true)
            {
                //O double.TryParse() é utilizado para tentar converter a entrada do usuário em um número válido.
                Console.WriteLine("Digite a nota do primeiro semestre:");
                if (double.TryParse(Console.ReadLine(), out notaSemestre1))
                {
                    //Se a conversão for bem-sucedida, o loop é interrompido pelo break.
                    break;
                }
                //Se a conversão for mal-sucedida, a mensagem de erro será exibida.
                Console.WriteLine("Valor inválido! Por favor, insira um número válido.");
            }

            while (true)
            {
                Console.WriteLine("Digite a nota do segundo semestre:");
                if (double.TryParse(Console.ReadLine(), out notaSemestre2))
                {
                    break;
                }
                Console.WriteLine("Valor inválido! Por favor, insira um número válido.");
            }

            //A média é calculada pela fórmula: (notaSemestre1 + notaSemestre2) / 2.
            media = (notaSemestre1 + notaSemestre2) / 2;

            //A média anual é exibida na tela usando Console.Write().
            //O símbolo $ indica que é uma interpolação de string, com isso podemos usar uma variável dentro da string.
            //A formatação :F1 é utilizada para exibir a média com apenas uma casa decimal.
            Console.Write($"Sua média é de {media:F1}");
        }
    }
}
