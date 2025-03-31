namespace itm.csharp.basic
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

}

public class Challenge2
{
    public void Run()
    {
        Console.WriteLine("Ingrese primer número:");
        double num1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese segundo número:");
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

/* Pide al usuario el radio de un círculo y calcula su perímetro*/

public class Challenge4
{
    public void run()
    {
        Console.WriteLine("Ingrese el radio del circulo:");
        double radio = double.Parse(Console.ReadLine());
        double area = Math.PI * radio * radio;
        Console.WriteLine($"El área del círculo con radio {radio} es: {area}");
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
            default Console.WriteLine("Número no válido"); break;
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
        double impuesto = salario > 1000 ? 0.1 * salario : 0;
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
            Console.WriteLine($"Resultado: {n / divisor}");

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
        for (int i = 1; i <= 50; i += 2)
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

            Console.WriteLine($"La suma de {fraccion1} y {fraccion2} es: {resultado}");

        }
        catch (Exception e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }

    }
}



