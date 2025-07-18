using Calculadora_de_Funcionario;
using System.Globalization;
namespace Calculadora
{
    public class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario;

            Console.WriteLine("Bem vindo ao sistema de salario do Funcionario");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("Por favor Digite o nome do Funcionario:");
            Console.Write("Nome: ");
            string? nome = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Por favor Digite o Salário do Funcionario:");
            Console.Write("Salário: ");
            double salariobruto = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();

            Console.Write("Terá imposto? S/N: ");
            char escolhaimposto = Convert.ToChar(Console.ReadLine());

            Console.WriteLine();
            if(escolhaimposto == 'S' || escolhaimposto == 's')
            {
                Console.WriteLine("De quanto sera o imposto?");
                Console.Write("Imposto: % ");
                double imposto = Convert.ToDouble(Console.ReadLine());
                funcionario = new Funcionario(nome, salariobruto, imposto);
            }
            else
            {
                funcionario = new Funcionario(nome, salariobruto);
            }


            
        }
    }
}