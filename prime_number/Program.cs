int number = 0, divisors_qtt = 1, again = 0;

do
{
    Console.Clear();
    divisors_qtt = 1;

    Console.Write("Informe um número para saber se ele é um número primo: ");
    number = int.Parse(Console.ReadLine());
    
    for (int i = 1; i < number; i++)
    {
        if (number % i == 0)
        {
            divisors_qtt++;
        }

        if (divisors_qtt == 3)
        {
            Console.WriteLine($"{number} não é um número primo.");
            break;
        }
    }

    if (divisors_qtt == 2)
    {
        Console.WriteLine($"{number} é um número primo.");
    }

    Console.WriteLine("Gostaria de testar outro número?");
    Console.WriteLine("Digite 1 para SIM");
    Console.WriteLine("Digite 2 para NÃO");
    again = int.Parse(Console.ReadLine());
} while (again == 1);