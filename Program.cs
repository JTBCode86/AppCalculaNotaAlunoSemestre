using System;
using System.Globalization;

namespace AppCalculaNotaAlunoSemestre
{
    /// <summary>
    /// Exercicios - Fixação - POO - Classes
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            Console.WriteLine("Nome do aluno: ");
            aluno.nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas: ");
            aluno.nota1 = double.Parse(Console.ReadLine());
            aluno.nota2 = double.Parse(Console.ReadLine());
            aluno.nota3 = double.Parse(Console.ReadLine());

            Console.WriteLine("NOTA FINAL = " + aluno.calculaNotaFinal().ToString("F2", CultureInfo.InvariantCulture));
            
            if (aluno.aprovado())
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + aluno.notaRestante().ToString("F2", CultureInfo.InvariantCulture)+ " PONTOS");
            }
            Console.ReadLine();
        }
    }
}
