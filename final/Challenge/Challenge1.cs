namespace itm.csharp.basic
{
    public class Challenge1
    {
        public void Run()
        {
            Console.WriteLine("Ingrese un número:");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la potencia a la elevará el número:");
            int potencia = int.Parse(Console.ReadLine());
            double resultado = Math.Pow(numero, potencia);

            Console.Write($"{numero} elevado a la potencia {potencia} es: {resultado}");
        }
    }


    public class Challenge2
    {
        public void Run()
        {
            Console.WriteLine("Ingrese primer número:");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese segundo número:");
            double num2 = double.Parse(Console.ReadLine());
            double result = 0;

            if (num1 >= num2)
            {
                result = num1 * 2;
            }
            else
            {
                result = num2 * 3;
            }
            Console.WriteLine($"El resultado es: {result}");
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

    /* Pide al usuario el radio de un círculo y calcula su perímetro*/

    public class Challenge4
    {
        public void Run()
        {
            float radio = 0.0F;
            float perimetro = 0.0F;
            Console.WriteLine("Ingrese el radio del circulo:");
            radio = float.Parse(Console.ReadLine());
            perimetro = (float)(Math.PI * 2 * radio);
            Console.WriteLine($"El perimetro del círculo con radio {radio:F2} es: {perimetro:F2}");
        }
    }

    /*Solicita al usuario un número entre 1 y 7 y muestra el día de la
    semana correspondiente, pero solo considerando los días laborables*/

    public class Challenge5
    {
        public void Run()
        {
            Console.WriteLine("Ingrese un número entre 1 y 7:");
            int dia = int.Parse(Console.ReadLine());

            switch (dia)
            {
                case 1: Console.WriteLine("Lunes"); break;
                case 2: Console.WriteLine("Martes"); break;
                case 3: Console.WriteLine("Miercoles"); break;
                case 4: Console.WriteLine("Jueves"); break;
                case 5: Console.WriteLine("Viernes"); break;
                case 6: Console.WriteLine("Sabado"); break;
                case 7: Console.WriteLine("Domingo"); break;
                default: Console.WriteLine("Número no válido"); break;
            }
        }
    }


    /*: Solicita al usuario su salario anual y, si este excede los 12000,
    muestra el impuesto a pagar que es el 15% del excedente.*/

    public class Challenge6
    {
        public void Run()
        {
            Console.WriteLine("Ingrese su salario mensual:");
            double salario = double.Parse(Console.ReadLine());
            double impuesto = salario > 12000 ? 0.15 * (salario - 12000) : 0;
            Console.WriteLine($"El impuesto a pagar es: {impuesto}");

        }
    }

    /*Solicita dos números y muestra el residuo de la división del primero entre el segundo.*/

    public class Challenge7
    {
        public void Run()
        {
            try
            {
                Console.WriteLine("Número a dividir:");
                double n = double.Parse(Console.ReadLine());
                Console.WriteLine("Divisor:");
                double divisor = double.Parse(Console.ReadLine());
                double Remainder(double n, double divisor) => n % divisor;
                Console.WriteLine($"El residuo de {n} % {divisor} es: {Remainder(n, divisor)}");

            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("No se puede dividir por cero!");
            }
            catch (Exception)
            {
                Console.WriteLine("Error al realizar la operación!");
            }
        }
    }

    /*Calcula y muestra la suma de los números pares entre 1 y 50*/

    public class Challenge8
    {
        public void Run()
        {
            int suma = 0;
            for (int i = 2; i <= 50; i += 2)
            {
                suma += i;
            }
            Console.WriteLine($"La suma de números impares entre 1 y 50 es: {suma}");
        }
    }

    /*Solicita al usuario los valores para dos fracciones y muestra la diferencia entre esas fracciones*/

    public class Challenge9
    {
        public void Run()
        {
            Console.WriteLine("Ingrese numerador de la primera fracción:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese denominar de la primera fracción");
            int den1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese numerador de la segunda fracción:");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese denominar de la primera fracción");
            int den2 = int.Parse(Console.ReadLine());

            try
            {
                Fraccion fraccion1 = new Fraccion(num1, den1);
                Fraccion fraccion2 = new Fraccion(num2, den2);

                Fraccion resultado = fraccion1.Sumar(fraccion2);

                Console.WriteLine($"La resta de {fraccion1} y {fraccion2} es: {resultado}");

            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }

    public class Fraccion
    {
        public int Numerador { get; private set; }

        public int Denominador { get; private set; }

        public Fraccion(int numerador, int denominador)
        {
            if (denominador == 0)
            {
                throw new ArgumentException("El denominador no puede ser cero.");
            }

            Numerador = numerador;
            Denominador = denominador;
        }

        public Fraccion Sumar(Fraccion otra)
        {
            int nuevoNumerador = Numerador * otra.Denominador - otra.Numerador * Denominador;
            int nuevoDenominador = Denominador * otra.Denominador;
            return new Fraccion(nuevoNumerador, nuevoDenominador);
        }

        public override string ToString()
        {
            return $"{Numerador} / {Denominador}";
        }
    }

    /*Pide una palabra al usuario y muestra la longitud de esa palabra*/

    public class Challenge10
    {
        public void Run()
        {
            Console.WriteLine("Introduce una palabra:");
            string palabra = Console.ReadLine();
            int longitud = palabra.Length;
            Console.WriteLine($"La palabra invertida es: {longitud}");
        }
    }

    /*Pide al usuario cuatro números y muestra el promedio.*/

    public class Challenge11
    {
        public void Run()
        {
            Console.WriteLine("Introduce el primer número:");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el segundo número:");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el tercer número:");
            double num3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el cuarto número:");
            double num4 = double.Parse(Console.ReadLine());

            double promedio = (num1 + num2 + num3 + num4) / 4;
            Console.WriteLine($"El promedio de los 4 número es: {promedio}");
        }
    }

    /*Pide al usuario cinco números y muestra el más pequeño*/

    public class Challenge12
    {
        public void Run()
        {
            List<int> numeros = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Introducce el numero {i + 1}:");
                numeros.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine($"El número más pequeño de la lista es: {numeros.Min()}");
        }
    }

    /*: Pide una palabra al usuario y devuelve el número de vocales en esa palabra.*/

    public class Challenge13
    {
        public void Run()
        {
            Console.WriteLine("Introduce una palabra:");
            string palabra = Console.ReadLine().ToLower();
            int contarVocales = 0;

            foreach (char letra in palabra)
            {

                if ("aeiou".Contains(letra))
                {
                    contarVocales++;
                }
            }
            Console.WriteLine("El número de vocales es: " + contarVocales);
            Console.ReadLine();
        }
    }


    /*Pide un número al usuario y devuelve el factorial de ese número.*/

    public class Challenge14
    {
        public void Run()
        {
            Console.WriteLine("Por favor ingresa un número positivo");

            int fac = int.Parse(Console.ReadLine());
            int resultado = 1;

            for (int i = 1; i <= fac; i++)
            {
                resultado *= i;
            }

            Console.WriteLine($"El factorial de {fac} es : {resultado}");

            Console.ReadKey();
        }
    }

    /*Pide un número al usuario y verifica si está en el rango de 10 a 20*/

    public class Challenge15
    {
        public void Run()
        {
            Console.WriteLine("Introduce un número:");
            int numero = int.Parse(Console.ReadLine());

            if (numero >= 10 && numero <= 20)
            {
                Console.WriteLine($"El número {numero} está en el rango de 10 a 20.");
            }
            else
            {
                Console.WriteLine($"El número {numero} está fuera del rango de 10 a 20.");
            }
        }
    }

}
