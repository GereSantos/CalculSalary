using System;
using System.Globalization;

namespace DataEmployee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee em = new Employee();
      

            Console.Write("Nome: ");
            em.Nome = (Console.ReadLine());
            Console.Write("Salário Bruto: ");
            em.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            em.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            em.SalarioLiquido();
            Console.WriteLine("Funcionário " + em);

            Console.WriteLine("Digite a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine());
            em.AumentarSalario(porcentagem);

            Console.WriteLine("Dados Atualizados: " + em);
            
        }
    }
}
