using System;
using System.Collections.Generic; // Adicionando a declaração de uso para List<T>

class Program
{
    private static readonly List<double> historico = new List<double>(); // Corrigindo o tipo da variável historico

    static void Main()
    {
        Console.WriteLine("Bem-vindo ao Conversor de Temperatura!");

        while (true)
        {
            Console.WriteLine("\nEscolha uma opção:");
            Console.WriteLine("1. Converter de Celsius para Fahrenheit");
            Console.WriteLine("2. Converter de Fahrenheit para Celsius");
            Console.WriteLine("3. Converter de Celsius para Kelvin");
            Console.WriteLine("4. Histórico");
            Console.WriteLine("5. Sair"); // Corrigindo o número da opção

            int escolha = ObterEscolhaUsuario();

            if (escolha == 5)
            {
                Console.WriteLine("Obrigado por usar o Conversor de Temperatura. Até mais!");
                break;
            }

            Console.Write("Digite a temperatura a ser convertida: ");
            double temperatura = double.Parse(Console.ReadLine());

            double resultado;

            switch (escolha)
            {
                case 1:
                    resultado = CelsiusParaFahrenheit(temperatura);
                    Console.WriteLine($"{temperatura}°C é equivalente a {resultado}°F");
                    break;
                case 2:
                    resultado = FahrenheitParaCelsius(temperatura);
                    Console.WriteLine($"{temperatura}°F é equivalente a {resultado}°C");
                    break;
                case 3:
                    resultado = CelsiusParaKelvin(temperatura);
                    Console.WriteLine($"{temperatura}°C é equivalente a {resultado}K");
                    break;
                case 4:
                    AdicionarAoHistorico(temperatura);
                    ExibirHistorico();
                    break;
                default:
                    Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                    break;
            }
        }
    }

    static int ObterEscolhaUsuario()
    {
        int escolha;
        while (!int.TryParse(Console.ReadLine(), out escolha) || escolha < 1 || escolha > 5) // Corrigindo o intervalo
        {
            Console.WriteLine("Por favor, digite uma opção válida (1 a 5).");
        }
        return escolha;
    }

    static double CelsiusParaFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    static double FahrenheitParaCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }

    static double CelsiusParaKelvin(double celsius) => celsius + 273.15;

    static void AdicionarAoHistorico(double temperatura)
    {
        historico.Add(temperatura);
        if (historico.Count > 5)
        {
            historico.RemoveAt(0);
        }
    }

    static void ExibirHistorico()
    {
        Console.WriteLine("\nÚltimas 5 temperaturas convertidas:");
        for (int i = 0; i < historico.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {historico[i]}");
        }
    }
}
