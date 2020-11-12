using System;

namespace condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            
            //Variaveis
            float notaUm, notaDois, notaTres, media;
            string nomeCompleto;

            //Entrada de dados
            Console.Write("Digite o nome do Aluno: ");
            nomeCompleto = Console.ReadLine();

            Console.WriteLine("---------------------------");

            Console.Write("Digite a primeira nota: ");
            notaUm = float.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            notaDois = float.Parse(Console.ReadLine());

            Console.Write("Digite a terceira nota: ");
            notaTres = float.Parse(Console.ReadLine());

            //Processamento
            Console.WriteLine("---------------------------");
            
            media = (notaUm+notaDois+notaTres)/3;

            //Exibir resultado
            if(media>5){
                //Verdadeiro
                Console.WriteLine("O Aluno "+nomeCompleto+" está APROVADO com a média de: "+media);
            }
            if(media<5){
                //Falso
                Console.WriteLine("O Aluno "+nomeCompleto+" está REPROVADO com a média de: "+media);
            }

        }
    }
}
