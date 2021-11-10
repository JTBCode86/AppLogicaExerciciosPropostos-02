using System;

namespace AppLogicaExerciciosPropostos_02
{
    class Program
    {
        /// <summary>
        /// Exercícios sobre Estrutura Condicional (if-else)
        /// Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.
        /// </summary>
        public static string validarNuParImpar(int numero) 
        {
            string validacao;
            if (numero%2 == 0)
            {
                validacao = "PAR";
            }
            else
            {
                validacao = "IMPAR";
            }
            return validacao;
        }

        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Entre com um valor: ");
            numero = int.Parse(Console.ReadLine());
            string resultadoValidacao = validarNuParImpar(numero);
            Console.Clear();
            Console.WriteLine("Seu numero é: {0}", resultadoValidacao);
            Console.ReadLine();
        }
    }
}
