Console.Write("Digite o lado a, bora: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o lado b, bora: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o lado c, bora: ");
        double c = Convert.ToDouble(Console.ReadLine());

        if (a <= 0 || b <= 0 || c <= 0)
        {
            Console.WriteLine("Todos os lados devem ser maiores que zero!");
            return;
        }

        if (a < b + c && a > Math.Abs(b - c) &&
            b < a + c && b > Math.Abs(a - c) &&
            c < a + b && c > Math.Abs(a - b))
        {
            if (a == b && b == c)
            {
                Console.WriteLine("Triângulo Equilátero");
            }
            else if (a != b && b != c && a != c)
            {
                Console.WriteLine("Triângulo Escaleno");
            }
            else
            {
                Console.WriteLine("Triângulo Isósceles");
            }

            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            Console.WriteLine($"Área do triângulo: {area:F2}");
        }
        else
        {
            Console.WriteLine("Os valores informados não formam um triângulo.");
        }