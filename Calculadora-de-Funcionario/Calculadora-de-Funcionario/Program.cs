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
                Console.Write("Imposto: ");
                double imposto = Convert.ToDouble(Console.ReadLine());
                funcionario = new Funcionario(nome, salariobruto, imposto);

                Console.WriteLine();

                double salarioimposto = funcionario.SalarioImposto(imposto);
                Console.WriteLine($"Salario do {nome}, ja com o imposto fica: R$ {salarioimposto.ToString("F2", 
                    CultureInfo.InvariantCulture)}");
            }
            else
            {
                funcionario = new Funcionario(nome, salariobruto);
                Console.WriteLine();
                Console.WriteLine($"O salário sem imposto fica: R$ {salariobruto}");
            }

            Console.WriteLine();

            Console.WriteLine("Agora digite a porcentagem para aumentar o salário: ");
            Console.Write("Aumentar: %");
            double porcentagem = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            

            Console.WriteLine($"O salario de {nome} antes do aumento era de R$ {salariobruto.ToString("F2", 
                CultureInfo.InvariantCulture)}");
            Console.WriteLine();
            Console.WriteLine($"Agora é de R$ {funcionario.AumentarSalario(porcentagem).ToString("F2", 
                CultureInfo.InvariantCulture)}");
        }
    }
}