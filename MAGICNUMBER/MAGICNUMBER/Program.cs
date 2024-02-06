using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Добре дошли в играта 'Магическо число'!");
        Console.WriteLine("Опитайте се да познаете числото от 1 до 100.");

        Random random = new Random();
        int targetNumber = random.Next(1, 101);
        int attempts = 0;
        int guess = 0;

        while (guess != targetNumber)
        {
            Console.Write("Въведете вашето предположение: ");
            if (!int.TryParse(Console.ReadLine(), out guess))
            {
                Console.WriteLine("Моля, въведете валидно цяло число.");
                continue;
            }

            attempts++;

            if (guess < targetNumber)
            {
                Console.WriteLine("По-горе! Опитайте пак.");
            }
            else if (guess > targetNumber)
            {
                Console.WriteLine("По-надолу! Опитайте пак.");
            }
            else
            {
                Console.WriteLine($"Браво! Вие познахте числото {targetNumber} след {attempts} опита!");
            }
        }

        Console.WriteLine("Играта приключи. Благодарим ви за участието!");
    }
}
