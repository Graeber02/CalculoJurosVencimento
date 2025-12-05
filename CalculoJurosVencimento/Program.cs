using System;

class Program
{
    static void Main()
    {
        Console.Write("Informe o valor original: R$ ");
        decimal valorOriginal = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Informe a data de vencimento (dd/MM/yyyy): ");
        DateTime dataVencimento = DateTime.Parse(Console.ReadLine());

        DateTime hoje = DateTime.Today;

        /*Calcula dias de atraso*/
        int diasAtraso = (hoje - dataVencimento).Days;

        if (diasAtraso <= 0)
        {
            Console.WriteLine("\nO título não está em atraso. Valor devido: R$ " + valorOriginal);
        }
        else
        {
            /*Juros de 2.5% ao dia*/
            decimal taxaDiaria = 0.025m;//ao usar o sufixo 'm', não é necessário converter
            //decimal taxaDiaria = Convert.ToDecimal(0.025);

            decimal juros = valorOriginal * taxaDiaria * diasAtraso;
            decimal valorFinal = valorOriginal + juros;

            Console.WriteLine($"\nDias de atraso: {diasAtraso}");
            Console.WriteLine($"Valor dos juros: R$ {juros:F2}");//F2 ajusta para 2 casas decimais
            Console.WriteLine($"Valor atualizado a pagar: R$ {valorFinal:F2}");
        }
    }
}