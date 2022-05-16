// See https://aka.ms/new-console-template for more information
            double c, f;

            Console.Write("Ingrese la cantidad en celsius: ");
            c = Convert.ToDouble(Console.ReadLine());
            
            f = (c * 9 / 5) + 32;

            Console.WriteLine("Grados Fahrenhait es igual a: " + f);
