using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string seleccion = "";
            string bucle;
            bool showMenu = true;


            while (showMenu == true)
            {
                while (!(seleccion == "1" || seleccion == "2" || seleccion == "3" || seleccion == "4"))
                {
                    Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                    Console.WriteLine("║    Lab. Desarrollo de Software I    |   IDS - Ismael Porfirio Martínez Encarnación   |   ID: 1077546   ║");
                    Console.WriteLine("║ 1. QUE MUESTRE LOS NÚMEROS DESCENDENTES DEL 1 AL 100 DE DOS EN DOS                                     ║");
                    Console.WriteLine("║ 2. QUE PIDA UN NÚMERO Y MUESTRE LA TABLA DEL 1 AL 12 DE DICHO NÚMERO                                   ║");
                    Console.WriteLine("║ 3. QUE PREGUNTE LA CANTIDAD DE MONTOS, PIDA DICHOS MONTOS Y CALCULE LA SUMATORIO Y EL PROMEDIO         ║");
                    Console.WriteLine("║ 4. QUE PIDA UN NOMBRE Y SE REPITA MIENTRAS NO SEA [jose] O LA CANTIDAD DE NOMBRE INGRESADO SEA MENOR 7 ║");
                    Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════╝");

                    //INDICAR OPCION A SELECCIONAR
                    Console.Write("Favor de indicar ¿Cuál subprograma desea correr (1-4): ");
                    seleccion = Console.ReadLine();
                    Console.Clear();
                }

                switch (seleccion)
                {
                    case "1":

                        int i = 100;
                        int Cont = 100;

                        Console.WriteLine("1. QUE MUESTRE LOS NÚMEROS DESCENDENTES DEL 1 AL 100 DE DOS EN DOS\n");

                        //INDICAR EL TIPO DE BUCLE A MOSTRAR
                        Console.Write("Digite el tipo de bucle (While, Do/While, For)?: ");
                        bucle = Console.ReadLine();

                        //BUCLE DO/WHILE
                        if (bucle.Equals("Do/While"))
                        {
                            do
                            {
                                Console.WriteLine(Cont);
                                Cont -= 2;
                            }
                            while (Cont >= 0);
                        }

                        //BUCLE WHILE
                        if (bucle.Equals("While"))
                        {
                            while (Cont >= 0)
                            {
                                Console.WriteLine(Cont);
                                Cont -= 2;
                            }
                        }
                        //BUCLE FOR
                        if (bucle.Equals("For"))
                        {
                            for (i = 0; i <= 100; i -= 2)
                            {
                                Console.WriteLine(i);
                            }
                        }
                        Console.ReadKey();
                        seleccion = "";
                        Console.Clear();
                        break;

                    case "2":

                        int producto;
                        int j;
                        int a;
                        int b = 1;

                        Console.WriteLine("2. QUE PIDA UN NÚMERO Y MUESTRE LA TABLA DEL 1 AL 12 DE DICHO NÚMERO\n");

                        //INDICAR EL TIPO DE BUCLE A MOSTRAR
                        Console.Write("Digite el tipo de bucle (While, Do/While, For)?: ");
                        bucle = Console.ReadLine();

                        //BUCLE DO/WHILE
                        if (bucle.Equals("Do/While"))
                        {
                            Console.Write("Digite numero de la tabla: ");
                            a = Convert.ToInt32(Console.ReadLine());

                            do
                            {
                                producto = a * b;
                                Console.WriteLine($"{a}x{b} = {producto}");
                                b++;
                            }
                            while (b <= 12);
                        }

                        //BUCLE WHILE
                        if (bucle.Equals("While"))
                        {
                            Console.Write("Digite numero de la tabla: ");
                            a = Convert.ToInt32(Console.ReadLine());

                            while (b <= 12)
                            {
                                producto = a * b;
                                Console.WriteLine($"{a}x{b} = {producto}");
                                b++;
                            }
                        }

                        //BUCLE FOR
                        if (bucle.Equals("For"))
                        {
                            Console.Write("Digite numero de la tabla: ");
                            a = Convert.ToInt32(Console.ReadLine());

                            for (j = 1; j <= 12; j++)
                            {

                                producto = a * b;
                                Console.WriteLine($"{a}x{b} = {producto}");
                                b++;
                            }
                        }
                        Console.ReadKey();
                        seleccion = "";
                        Console.Clear();
                        break;

                    case "3":

                        int e = 1;
                        double montos;
                        int cantidad;
                        double sumatoria = 0;
                        double promedio;

                        Console.WriteLine("3. QUE PREGUNTE LA CANTIDAD DE MONTOS, PIDA DICHOS MONTOS Y CALCULE LA SUMATORIO Y EL PROMEDIO\n");

                        //INDICAR EL TIPO DE BUCLE A MOSTRAR
                        Console.Write("Digite el tipo de bucle (While, Do/While, For)?: ");
                        bucle = Console.ReadLine();

                        //BUCLE DO/WHILE
                        if (bucle.Equals("Do/While"))
                        {
                            Console.Write("Digite la cantidad de montos: ");
                            cantidad = Convert.ToInt32(Console.ReadLine());
                            do
                            {
                                Console.Write($"Favor de digitar su monto {e}: ");
                                montos = Convert.ToDouble(Console.ReadLine());

                                sumatoria += montos;
                                e++;
                            }
                            while (e <= cantidad);
                        }

                        //BUCLE WHILE
                        if (bucle.Equals("While"))
                        {
                            Console.Write("Digite la cantidad de montos: ");
                            cantidad = Convert.ToInt32(Console.ReadLine());

                            while (e <= cantidad)
                            {

                                Console.Write($"Favor de digitar su monto {e}: ");
                                montos = Convert.ToDouble(Console.ReadLine());

                                sumatoria += montos;
                                e++;
                            }
                        }

                        //BUCLE FOR

                        if (bucle.Equals("For"))
                        {
                            Console.Write("Digite la cantidad de montos: ");
                            cantidad = Convert.ToInt32(Console.ReadLine());

                            for (e = 1; e <= cantidad; e++)
                            {
                                Console.Write($"Favor de digitar su monto {e}: ");
                                montos = Convert.ToDouble(Console.ReadLine());

                                sumatoria += montos;
                            }

                            promedio = sumatoria / cantidad;

                            Console.WriteLine($"Sumatoria = {sumatoria}");
                            Console.WriteLine($"promedio = {promedio}");
                        }
                        Console.ReadKey();
                        seleccion = "";
                        Console.Clear();
                        break;

                    case "4":

                        int Cont2 = 1;
                        string nombre;
                        int intentos = 7;
                        int y;

                        Console.WriteLine("4. QUE PIDA UN NOMBRE Y SE REPITA MIENTRAS NO SEA [jose] O LA CANTIDAD DE NOMBRE INGRESADO SEA MENOR7\n");

                        //INDICAR EL TIPO DE BUCLE A MOSTRAR
                        Console.Write("Digite el tipo de bucle (While, Do/While, For)?: ");
                        bucle = Console.ReadLine();

                        //BUCLE DO/WHILE
                        if (bucle.Equals("Do/While"))
                        {
                            do
                            {
                                Console.Write($"{Cont2}. Favor de digitar el nombre: ");
                                nombre = Console.ReadLine().ToLower();

                                if (nombre == ("jose"))
                                {
                                    Console.WriteLine($"\nHola [{nombre}], bienvenido :D\n");
                                    Cont2 = 7;
                                }
                   
                                else if (Cont2 == 7 && nombre != "jose")
                                {
                                    Console.WriteLine("Lo sentimos, ya no tienes más intentos");
                                }
                                Cont2++;
                            }
                            while (Cont2 <= intentos);
                        }

                        //BUCLE WHILE
                        if (bucle.Equals("While"))
                        {
                            while (Cont2 <= intentos)
                            {
                                Console.Write($"{Cont2}. Favor de digitar el nombre: ");
                                nombre = Console.ReadLine().ToLower();

                                if (nombre.Equals("jose"))
                                {
                                    Console.WriteLine($"\nHola [{nombre}], bienvenido :D\n");
                                    Cont2 = 7;
                                }

                                else if (Cont2 == 7 && nombre != "jose")
                                {
                                    Console.WriteLine("Lo sentimos, ya no tienes más intentos");
                                }
                                Cont2++;
                            }
                        }

                        //BUCLE FOR
                        if (bucle.Equals("For"))
                        {
                            for (y = 1; y <= intentos; y++)
                            {
                                Console.Write($"{y}. Favor de digitar el nombre: ");
                                nombre = Console.ReadLine().ToLower();

                                if (nombre.Equals("jose"))
                                {
                                    Console.WriteLine($"\nHola [{nombre}], bienvenido :D\n");
                                    y = 7;
                                }

                                else if (y == 7 && nombre != "jose")
                                {
                                    Console.WriteLine("Lo sentimos, ya no tienes más intentos");
                                }
                            }

                        }
                        Console.ReadKey();
                        seleccion = "";
                        Console.Clear();

                        break;
                }
            } 
        }
    }
}
