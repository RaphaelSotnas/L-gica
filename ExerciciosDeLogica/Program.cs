using System;
using System.Collections.Generic;
using System.Linq;

namespace ExerciciosDeLogica
{
    class Program
    {
        static void Main()
        {
            //CalculandoMedia();
            //VerificandoParidade();
            //string[] palavras = new string[3] { "is", "valid", "right" };
            //MaioresDeIdade();
            //SalarioReajustado();
            CalculandoAltura();
        }

        public static void CalculandoMedia()
        {
            Console.WriteLine("Vamos calcular a média da idades de 5 crianças.");
            Console.WriteLine("Digite a primeira idade");
            var idade1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a segunda idade");

            var idade2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a terceira idade");

            var idade3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a quarta idade");

            var idade4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a quinta idade");

            var idade5 = Convert.ToDouble(Console.ReadLine());

            var soma = (idade1 + idade2 + idade3 + idade4 + idade5);
            var resultado = soma / 5;

            Console.WriteLine("A soma das idades é igual a " + resultado);
        }

        public static void VerificandoParidade()
        {
            Console.WriteLine("Informe o número para verificar-mos se é par ou ímpar.");
            var numero = Convert.ToDouble(Console.ReadLine());
            if (numero < 0)
            {
                Console.WriteLine("Esse número é negativo, por favor coloque números positivos");
            }

            var divisao = numero % 2;
            if (divisao == 1)
            {
                Console.WriteLine("Esse número é ímpar");
            }
            else
            {
                Console.WriteLine("Esse número é Par!");
            }
        }


        public static void MaioresDeIdade()
        //verificar se a pessoa é maior de idade! tenho um limite de até 10 pessoas para verificar
        {
            int quantidade = 0;
            int indicador = 0;
            while (indicador < 10)
            {
                indicador = indicador + 1;

                Console.WriteLine("Qual a sua idade?");
                int idade = Convert.ToInt32(Console.ReadLine());

                if (idade >= 18)
                {
                    Console.WriteLine("Você é maior de idade!");
                    quantidade = quantidade + 1;
                }
                else
                {
                    Console.WriteLine("Você é menor de idade!");
                }
            }

            Console.WriteLine("Existem" + quantidade + "Maiores de Idade!");
        }



        public static void SalarioReajustado()
        //ajustar o salário de 10 funcionários.
        //salários acima de 300, reajuste de 50%
        //salários abaixo de 300, realuste de 30% 
        {
            double salario = 0;
            int indicador = 1;
            for (indicador = 1; indicador <= 10; indicador++)
            {
                Console.WriteLine("Qual seu salário?");

                var salarioFornecido = Convert.ToDouble(Console.ReadLine());
                if (salario <= 300)
                {
                    salario = salarioFornecido * 1.3;
                }

                if (salario > 300)
                {
                    salario = salarioFornecido * 1.5;
                }

                Console.WriteLine("Seu novo salário é de: " + salario);
            }
        }

        public static void CalculandoAltura()
        {
            List<Alunos> alunosDaEscola = new List<Alunos>();

            for (int indicador = 0; indicador < 2; indicador++)
            {
                Console.WriteLine("Por favor, digite o número da sua matrícula com 3 dígitos");
                int matriculaFornecida = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Por favor, digite sua altura em cm");
                double alturaFornecida = Convert.ToDouble(Console.ReadLine());

                Alunos aluno = new Alunos();
                aluno.numero = matriculaFornecida;
                aluno.altura = alturaFornecida;

                alunosDaEscola.Add(aluno);
            }

            var alunosDaEscolaNova = alunosDaEscola.OrderBy(x => x.altura);
            var alturaDoAlunoBaixo = alunosDaEscolaNova.FirstOrDefault();
            var matriculaDoAlunoBaixo = alunosDaEscolaNova.FirstOrDefault();

            Console.WriteLine("O aluno mais baixo tem: " + alturaDoAlunoBaixo.altura);
            Console.WriteLine("A matrícula do aluno mais baixo é: " + matriculaDoAlunoBaixo.numero);

            var alturaDoAlunoAlto = alunosDaEscolaNova.Last();
            var matriculaDoAlunoAlto = alunosDaEscolaNova.Last();

            Console.WriteLine("O aluno mais alto tem: " + alturaDoAlunoAlto.altura);
            Console.WriteLine("A matrícula do aluno mais alto é: " + matriculaDoAlunoAlto.numero);


        }
    }
}
