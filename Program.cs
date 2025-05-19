Console.WriteLine("\n\t\t\tBem-vindo(a) ao Banco de Empréstimos!");

Console.WriteLine("\nPor favor, digite o valor que deseja.");
double vEmprestimo = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("\nPor favor, digite a quantidade de parcelas desejada.");
int qParcelas = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("\nPor favor, digite a sua renda mensal.");
double vRenda = Convert.ToDouble(Console.ReadLine());

double vParcela = vEmprestimo / qParcelas;

double limite = vRenda * 0.3;

Console.WriteLine("\n\nAnalisando... Aguarde...");

if (vParcela <= limite)
{
    Console.WriteLine("\nEmpréstimo Autorizado!");
}
else
{
    Console.WriteLine("\nEmpréstimo Negado.");
}
