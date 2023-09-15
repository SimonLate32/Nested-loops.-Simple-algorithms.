using System;

class Program
{
    static void Main()
    {

        Console.WriteLine("Введите размер фигуры (s):"); // Размер фигуры, при которой программа выдаст фигуру = 10
        int s = int.Parse(Console.ReadLine());

        if (s >= 2 && s % 2 == 0)
        {
            PrintFigure(s);
        }
        else
        {
            Console.WriteLine("Введите правильный s (размер фигуры), который должен соответствовать s>=2 и s-четное число.");
        }
    }

    static void PrintFigure(int s)
    {
        if (s % 2 != 0 || s < 2)
        {
            Console.WriteLine("Введите правильное значение s (должно быть четным и не менее 2).");
            return;
        }

        int h = s / 2; // Высота верхней части фигуры
        int w = s;    // Ширина фигуры

        // Верхняя часть фигуры
        for (int i = 1; i <= h; i++)
        {
            // Отступы перед числами
            for (int j = 0; j < h - i; j++)
            {
                Console.Write(" ");
            }

            // Вывод чисел в возрастающем порядке
            for (int j = 0; j < i; j++)
            {
                Console.Write(j);
            }

            Console.WriteLine();
        }

        // Нижняя часть фигуры
        for (int i = h - 1; i >= 0; i--)
        {
            // Отступы перед числами
            Console.Write("     ");
            for (int j = 0; j < h - i; j++)
            {
                Console.Write("");
            }

            // Вывод чисел в убывающем порядке
            for (int j = i; j >= 0; j--)
            {
                Console.Write(j);
            }

            Console.WriteLine();
        }
    }
}