namespace itm.csharp.basic
{
    public class Challenge1
    {
public void Run()
        {
            Console.WriteLine("Ingrese un número:");
            int num = int.Parse(Console.ReadLine());
            if (num > 0) Console.WriteLine("Positivo")
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
