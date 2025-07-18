using System.Globalization;
namespace Calculadora_de_Funcionario
{
    internal class Funcionario
    {
        public string Nome {  get; set; }
        public double SalarioBruto {  get; private set; }
        public double Imposto { get; set; }

        public Funcionario(string nome, double salarioBruto) //Nao tem imposto
        {
            Nome = nome;
            SalarioBruto = salarioBruto;
        }

        public Funcionario(string nome, double salarioBruto, double imposto) : this(nome, salarioBruto) //Tem imposto
        {
            Imposto = imposto;
        }


        public double SalarioImposto(double imposto)
        {
            return SalarioBruto -= Imposto;
        }

        public double AumentarSalario(double porcentagem)
        {
            double aumentarporcentagem = porcentagem / 100 + 1;
            return SalarioBruto * aumentarporcentagem;
        }
    }
}
