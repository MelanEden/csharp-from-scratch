/* namespace itm.csharp.basic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su nombre:");
            string nombre = Console.ReadLine();
            Console.WriteLine($"¡Hola, {nombre}! Por favor, elige un ejercicio del siguiente menú:");
            Menu.MostrarMenu();

            while (true)
            {
                string entrada = Console.ReadLine().ToLower();

                if (entrada == "q" || entrada == "exit")
                {
                    break; // Salir del bucle
                }

                if (int.TryParse(entrada, out int eleccion) && eleccion >= 1 && eleccion <= 15)
                {
                    // Aquí puedes agregar la lógica del switch para ejecutar los ejercicios...

                    Console.WriteLine("Presiona una tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                    Menu.MostrarMenu();
                }
                else
                {
                    Console.WriteLine("Opción no válida. Por favor, ingrese un número entre 1 y 15, o 'q' o 'exit' para salir.");
                }
            }

            Console.WriteLine("¡Hasta luego!");
        }
    } */

namespace itm.csharp.basic
{
    class Program
    
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su nombre:");
            string nombre = Console.ReadLine();
            Console.WriteLine($"¡Hola, {nombre}! Por favor, elige un ejercicio del siguiente menú:");
            Menu.MostrarMenu();

            while (true)
            {
                string entrada = Console.ReadLine().ToLower();

                if (entrada == "q" || entrada == "exit")
                {
                    break; // Salir del bucle
                }

                if (int.TryParse(entrada, out int eleccion) && eleccion >= 1 && eleccion <= 15)
                {
                    EjecutarEjercicio(eleccion);
                    Console.WriteLine("Presiona una tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                    Menu.MostrarMenu();
                }
                else
                {
                    Console.WriteLine("Opción no válida. Por favor, ingrese un número entre 1 y 15, o 'q' o 'exit' para salir.");
                }
            }

            Console.WriteLine("¡Hasta luego!");
        }

         static void EjecutarEjercicio(int numero)
        {
            switch (numero)
            {
                case 1:
                    new Challenge1().Run();
                    break;
                case 2:
                    new Challenge2().Run();
                    break;
                case 3:
                    new Challenge3().Run();
                    break;
                default:
                    Console.WriteLine("Ejercicio no implementado aún.");
                    break;
            }
        }
    }