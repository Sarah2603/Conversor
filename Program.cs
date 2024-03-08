using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bem-vindo ao Conversor de Temperatura!");

        while (true)
        {
            Console.WriteLine("\nEscolha uma opção:");
            Console.WriteLine("1. Converter de Celsius para Fahrenheit");
            Console.WriteLine("2. Converter de Fahrenheit para Celsius");
            Console.WriteLine("3. Converter de Celsius para Kelvin");
            Console.WriteLine("4. Sair");

            int escolha = ObterEscolhaUsuario();

            if (escolha == 4)
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
                default:
                    Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                    break;
            }
        }
    }

    static int ObterEscolhaUsuario()
    {
        int escolha;
        while (!int.TryParse(Console.ReadLine(), out escolha) || escolha < 1 || escolha > 4)
        {
            Console.WriteLine("Por favor, digite uma opção válida (1 a 4).");
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

    static double CelsiusParaKelvin(double celsius)
    {
        return celsius + 273.15;
    }
}
