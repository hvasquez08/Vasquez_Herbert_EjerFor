//Vamos a hacer todos los ejercicios en un git, usando swich para poder elegir el ejercicio que quiera
Console.WriteLine("Bienvenido");
Console.WriteLine("Favor de elegir el programa que desee ver :D");
Console.WriteLine("Mostrar los números del 1 al 10.\r\nMostrar los números del 1 al 20 en la misma línea separados por espacio.\r\nMostrar los números del 10 al 1 en orden descendente.\r\nMostrar únicamente los números pares del 1 al 20.\r\nMostrar únicamente los números impares del 1 al 20.\r\nMostrar la palabra “Hola” 5 veces.\r\nMostrar los números del 1 al 10 junto con su cuadrado. Ejemplo: 3 → 9\r\nMostrar los números del 1 al 50 que sean múltiplos de 5.\r\nMostrar la suma de los números del 1 al 10.\r\nMostrar la suma de los números del 1 al 100.\r\nPedir un número al usuario y mostrar su tabla de multiplicar del 1 al 10.\r\nPedir un número y mostrar los números desde 1 hasta ese número.\r\nPedir un número y mostrar los números desde ese número hasta 1.\r\nPedir 3 números y mostrar la suma total.\r\nPedir 5 números y mostrar el promedio.\r\nPedir 5 números y mostrar cuántos son mayores que 10.\r\nPedir 5 números y mostrar cuántos son pares.\r\nPedir 5 números y mostrar el número mayor ingresado.\r\nPedir 5 números y mostrar el número menor ingresado.\r\nPedir una cantidad N de números e indicar cuántos son positivos.\r\nPedir una cantidad N de números e indicar cuántos son negativos.\r\nPedir N ventas e indicar el total vendido.\r\nPedir N notas y mostrar el promedio final.\r\nPedir N notas y mostrar si el promedio es aprobado (>=61) o reprobado.\r\nPedir un número y dibujar una escalera con asteriscos.");
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
        break;
    case 12:
        break;
    case 13:
        break;
        case 14:
            break;
        case 15:
            break;
        case 16:
            break;
        case 17:
            break;
        case 18:
            break;
        case 19:
            break;
        case 20:
            break;
        case 21:
            break;
        case 22:
            break;
        case 23:
            break;
        case 24:
            break;
        case 25:
            break;
    default:
		break;
}