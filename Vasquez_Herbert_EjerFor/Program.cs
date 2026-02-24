//Vamos a hacer todos los ejercicios en un git, usando swich para poder elegir el ejercicio que quiera
Console.WriteLine("Bienvenido");
Console.WriteLine("Favor de elegir el programa que desee ver :D");
Console.WriteLine("Mostrar los números del 1 al 10.\r\nMostrar los números del 1 al 20 en la misma línea separados por espacio.\r\nMostrar los números del 10 al 1 en orden descendente.\r\nMostrar únicamente los números pares del 1 al 20.\r\nMostrar únicamente los números impares del 1 al 20.\r\nMostrar la palabra “Hola” 5 veces.\r\nMostrar los números del 1 al 10 junto con su cuadrado. Ejemplo: 3 → 9\r\nMostrar los números del 1 al 50 que sean múltiplos de 5.\r\nMostrar la suma de los números del 1 al 10.\r\nMostrar la suma de los números del 1 al 100.\r\nPedir un número al usuario y mostrar su tabla de multiplicar del 1 al 10.\r\nPedir un número y mostrar los números desde 1 hasta ese número.\r\nPedir un número y mostrar los números desde ese número hasta 1.\r\nPedir 3 números y mostrar la suma total.\r\nPedir 5 números y mostrar el promedio.\r\nPedir 5 números y mostrar cuántos son mayores que 10.\r\nPedir 5 números y mostrar cuántos son pares.\r\nPedir 5 números y mostrar el número mayor ingresado.\r\nPedir 5 números y mostrar el número menor ingresado.\r\nPedir una cantidad N de números e indicar cuántos son positivos.\r\nPedir una cantidad N de números e indicar cuántos son negativos.\r\nPedir N ventas e indicar el total vendido.\r\nPedir N notas y mostrar el promedio final.\r\nPedir N notas y mostrar si el promedio es aprobado (>=61) o reprobado.\r\nPedir un número y dibujar una escalera con asteriscos.");
Console.WriteLine("////////////////////////");
int opcion = int.Parse(Console.ReadLine());
Console.WriteLine("");
switch (opcion)
{
	case 1:
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("");
            Console.WriteLine(i);
        }
        break;
    case 2:
        Console.WriteLine("/////");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
            Console.WriteLine("");
        }
        break;
    case 3:
        Console.WriteLine("//////");
        for (int i = 10; i >= 1; i--)
        {
            Console.WriteLine(i);
            Console.WriteLine("");
        }
        break;
    case 4:
        Console.WriteLine("//////");
        for (int i = 0; i <= 20; i+= 2)
        {
            Console.WriteLine(i);
            Console.WriteLine("");
        }
        break;
    case 5:
        Console.WriteLine("//////");
        for (int i = 1; i <= 20; i += 2)
        {
            Console.WriteLine(i);
            Console.WriteLine("");
        }
        break;
    case 6:
        Console.WriteLine("/////");
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("hola");
        }
        break;
    case 7:
        Console.WriteLine("//////");
        for (int i = 1; i <= 10; i ++)
        {
            Console.WriteLine($"Numero {i} su cuadrado {(i*i)}");
            Console.WriteLine("");
        }
        break;
    case 8:
        Console.WriteLine("//////");
        for (int i = 0; i <= 50; i+=5)
        {
            Console.WriteLine($"Numero {i} ");
            Console.WriteLine("");
        }
        break;
    case 9:
        Console.WriteLine("//////");
        int x = 0;
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
            x = x+i;
        }
        Console.WriteLine(x);
        break;
    case 10:
        //se aplico una nueva variable ya que la detectava xd
        Console.WriteLine("//////");
        int y = 0;
        for (int i = 1; i <= 100; i++)
        {
            Console.WriteLine(i);
            y = y + i;
        }
        Console.WriteLine(y);
        break;
    case 11:
        Console.WriteLine("/////////");
        Console.WriteLine("Ingrese un numero");
        double numerroo = double.Parse(Console.ReadLine());
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("");
            Console.WriteLine(i*numerroo);
        }
        break;
    case 12:
        Console.WriteLine("/////////");
        Console.WriteLine("Ingrese un numero");
        double numerroo_hasta = double.Parse(Console.ReadLine());
        for (int i = 1; i <= numerroo_hasta; i++)
        {
            Console.WriteLine("");
            Console.WriteLine(i );
        }
        break;
    case 13:
        Console.WriteLine("/////////");
        Console.WriteLine("Ingrese un numero");
        int numerroo_hasta_menor = int.Parse(Console.ReadLine());
        for (int i = numerroo_hasta_menor; i >= 1; i--)
        {
            Console.WriteLine("");
            Console.WriteLine(i);
        }
        break;
        case 14:
        Console.WriteLine("//////");
        double z = 0;
        for (int i = 1; i <= 3; i++)
        {
            Console.WriteLine("");
            Console.WriteLine("Ingrese un numero");
            double numerosuma = double.Parse(Console.ReadLine());
            z = z + numerosuma;
        }
        Console.WriteLine($"la suma es {z}");
        break;
        case 15: //Pedir 5 números y mostrar el promedio.
        Console.WriteLine("//////");
        double xd = 0;
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("");
            Console.WriteLine("Ingrese un numero");
            double numerosuma = double.Parse(Console.ReadLine());
            xd = xd + numerosuma;
        }
        Console.WriteLine($"el promedio es {xd/5}");
        break;
        case 16:
        Console.WriteLine("//////");
        int numerosmayores = 0;
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Ingrese un numero");
            double numeroingresado = double.Parse(Console.ReadLine());
            if (numeroingresado > 10)
            {
                numerosmayores++;
            }
        }
        Console.WriteLine($"los numeros mayores son {numerosmayores}");
        break;
        case 17:
        Console.WriteLine("//////");
        int numerosimpares = 0;
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Ingrese un numero");
            double numeroingresado = double.Parse(Console.ReadLine());
            if (numeroingresado % 2 == 0 )
            {
                numerosimpares++;
            }
        }
        Console.WriteLine($"los numeros pares son: {numerosimpares}");
        break;

        case 18:
        Console.WriteLine("//////");
        double numeromayor = 0;
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Ingrese un numero");
            double numeroingresado = double.Parse(Console.ReadLine());
            if (numeroingresado > numeromayor)
            {
                numeromayor = numeroingresado;
            }
        }
        Console.WriteLine($"el numero mayor es: {numeromayor}");
        break;

        case 19:
        Console.WriteLine("//////");
        Console.WriteLine("Ingrese un numero");
        double numeromenor = double.Parse(Console.ReadLine());
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Ingrese un numero");
            double numeroingresado = double.Parse(Console.ReadLine());
            if (numeroingresado < numeromenor)
            {
                numeromenor = numeroingresado;
            }
        }
        Console.WriteLine($"el numero menor es: {numeromenor}");
        break;

        case 20:
        Console.WriteLine("//////");
        Console.WriteLine("Ingrese la cantidad de numeros");
        int cantidadnumero = int.Parse(Console.ReadLine());
        int numerospositivos = 0;
        Console.WriteLine("//////");
        for (int i = 1; i <= cantidadnumero; i++)
        {
            Console.WriteLine("Ingrese un numero");
            double numeroingresado = double.Parse(Console.ReadLine());
            if (numeroingresado > 0)
            {
                numerospositivos++;
            }
        }
        Console.WriteLine($"la cantidad de numeros positivos son: : {numerospositivos}");
        break;

        case 21:
        Console.WriteLine("//////");
        Console.WriteLine("Ingrese la cantidad de numeros");
        int cantidadnumerooos = int.Parse(Console.ReadLine());
        int numerosnegativos = 0;
        Console.WriteLine("//////");
        for (int i = 1; i <= cantidadnumerooos; i++)
        {
            Console.WriteLine("Ingrese un numero");
            double numeroingresado = double.Parse(Console.ReadLine());
            if (numeroingresado < 0)
            {
                numerosnegativos++;
            }
        }
        Console.WriteLine($"la cantidad de numeros negativos son: : {numerosnegativos}");
        break;

        case 22:
        Console.WriteLine("//////");
        Console.WriteLine("Ingrese la cantidad de ventas");
        int cantidadventas = int.Parse(Console.ReadLine());
        double totalvendido = 0;
        Console.WriteLine("//////");
        for (int i = 1; i <= cantidadventas; i++)
        {
            Console.WriteLine("Ingrese el costo de la venta");
            double venta = double.Parse(Console.ReadLine());
            totalvendido += venta;
        }
        Console.WriteLine($"la cantidad de venta sumada es : {totalvendido}");
        break;

        case 23:
        Console.WriteLine("//////");
        Console.WriteLine("Ingrese la cantidad de notas");
        int cantidadnotas = int.Parse(Console.ReadLine());
        double sumanotas = 0;
        Console.WriteLine("//////");
        for (int i = 1; i <= cantidadnotas; i++)
        {
            Console.WriteLine("Ingrese nota");
            double notas = double.Parse(Console.ReadLine());
            sumanotas += notas;
        }
        Console.WriteLine($"el promedio final es: {sumanotas/cantidadnotas}");
        break;
        case 24:
            break;
        case 25:
            break;
    default:
		break;
}