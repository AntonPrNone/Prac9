class Program
{
    static void Main()
    {
        Console.WriteLine("Введите длины сторон треугольника:");

        double side1, side2, side3;

        // Ввод и проверка длин сторон
        do
        {
            Console.Write("Сторона 1: ");
        } while (!double.TryParse(Console.ReadLine(), out side1) || side1 <= 0);

        do
        {
            Console.Write("Сторона 2: ");
        } while (!double.TryParse(Console.ReadLine(), out side2) || side2 <= 0);

        do
        {
            Console.Write("Сторона 3: ");
        } while (!double.TryParse(Console.ReadLine(), out side3) || side3 <= 0);

        // Проверка на возможность образования треугольника
        if (side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1)
        {
            // Определение вида треугольника
            if (side1 == side2 && side2 == side3)
            {
                Console.WriteLine("Треугольник равносторонний");
            }

            else if (side1 == side2 || side1 == side3 || side2 == side3)
            {
                Console.WriteLine("Треугольник равнобедренный");
            }

            else
            {
                Console.WriteLine("Треугольник разносторонний");
            }

            // Вычисление площади по формуле Герона
            double semiPerimeter = (side1 + side2 + side3) / 2;
            double area = Math.Sqrt(semiPerimeter * (semiPerimeter - side1) * (semiPerimeter - side2) * (semiPerimeter - side3));

            Console.WriteLine($"Площадь треугольника: {area}");
        }

        else
        {
            Console.WriteLine("Треугольник с такими сторонами не существует");
        }
    }
}
