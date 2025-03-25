/* namespace itm.csharp.basic
{
    public class Challenge1
    {
public void Run()
        {
            Console.WriteLine("Ingrese un número:");
            int num = int.Parse(Console.ReadLine());
            if (num > 0) Console.WriteLine("Positivo");
            else if (num < 0) Console.WriteLine("Negativo");
            else Console.WriteLine("Es cero");
        }
    }

    public class Challenge2
    {
        public void Run()
        {
            Console.WriteLine("Ingrese primer número:" );
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese segundo número:" );
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"Suma: {num1 + num2}\nResta: {num1 - num2}\nMultiplicación: {num1 * num2}\nDivisión:{num1 / num2} ");

        }
    }

    public class Challenge3
    {
        public void Run()
        {
         Console.WriteLine("Ingrese un número:");
         int numero = int.Parse(Console.ReadLine());
          Console.WriteLine($"El cuadrado de {numero} es: {numero * numero}");
        }
    }

    }//Cierra toda la clase
 */

 public class Challenge1
    {
        public void Run()
        {
            Console.WriteLine("Ingrese un número:");
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                if (num > 0) Console.WriteLine("Positivo");
                else if (num < 0) Console.WriteLine("Negativo");
                else Console.WriteLine("Es cero");
            }
            else
            {
                Console.WriteLine("Entrada no válida.");
            }
        }
    }

    public class Challenge2
    {
        public void Run()
        {
            Console.WriteLine("Ingrese primer número:");
            if (double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.WriteLine("Ingrese segundo número:");
                if (double.TryParse(Console.ReadLine(), out double num2))
                {
                    Console.WriteLine($"Suma: {num1 + num2}\nResta: {num1 - num2}\nMultiplicación: {num1 * num2}\nDivisión: {(num2 != 0 ? (num1 / num2).ToString() : "No se puede dividir entre cero")}");
                }
                else
                {
                    Console.WriteLine("Entrada no válida para el segundo número.");
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida para el primer número.");
            }
        }
    }

    public class Challenge3
    {
        public void Run()
        {
            Console.WriteLine("Ingrese un número:");
            if (int.TryParse(Console.ReadLine(), out int numero))
            {
                Console.WriteLine($"El cuadrado de {numero} es: {numero * numero}");
            }
            else
            {
                Console.WriteLine("Entrada no válida.");
            }
        }
    }
}
