using System.Collections;
using System.Diagnostics.Tracing;

//Console.WriteLine("cual es tu edad?");
//int edad =int.Parse(Console.ReadLine());
//if (edad>=18) Console.WriteLine("es mayor de edad");

//Ejercicio 2

/* Console.WriteLine("Esribe un numero entero");
int numero2 =int.Parse(Console.ReadLine());
if (numero2 > 0) Console.WriteLine("El numero es mayor que cero");
else Console.WriteLine("El numero no es mayor que cero");
   
 */
// ejercicio3
//Console.WriteLine("pon tu nota");
//double nota3 =double.Parse(Console.ReadLine());
//if (nota3>=5) Console.WriteLine("aprobado");

// //Ejercicio 4
// Console.WriteLine("Introduce la temperatura en ºC ");
// double temperatura4 = double.Parse(Console.ReadLine());
// if (temperatura4 > 30) Console.WriteLine("Hace calor");

// ejercicio5
//Console.Write("introduce un numero entero: ");
//int numero3 =int.Parse(Console.ReadLine());
//if (numero3 % 2 ==0) Console.WriteLine("es par");

// //Ejercicio 6
// Console.WriteLine("Introduce un numero entero entre 255 y -255");
// int numero6 = int.Parse(Console.ReadLine());
// if (numero6 > 0) Console.WriteLine("El numero es positivo");
//     else if (numero6 < 0) Console.WriteLine("El numero es negativo");
//         else Console.WriteLine("El numero es cero");

////ejercicio7
//string contraseñacorrecta ="1234";
//Console.WriteLine("escribe una contraseña");
//string contraseña7 = Console.ReadLine();
//if (contraseñacorrecta==contraseña7) Console.WriteLine("contraseña correcta");
//else Console.WriteLine("contraseña incorrecta");

// // Ejercicio 8
// Console.WriteLine("Introduce la nota");
// double nota8 = double.Parse(Console.ReadLine());
// if (nota8 < 5) Console.WriteLine("Suspenso");
// else if (5 < nota8 && nota8 < 6) Console.WriteLine("Aprobado");
// else if (7< nota8 && nota8 <8) Console.WriteLine("Notable");
// else if (nota8 > 8) Console.WriteLine("Sobresaliente");
// else Console.WriteLine("Bien");

//ejercicio 9
//Console.WriteLine("introduce tu edad");
//int edad9 = int.Parse(Console.ReadLine());
//if (edad9<13) Console.WriteLine("niño");
//else if (edad9>=13 && edad9<=17) Console.WriteLine("adolecente");
//else if (edad9>=18 && edad9<=64) Console.WriteLine("adulto");
//else Console.WriteLine("persona mayor");

// //Ejercicio 10
// Console.WriteLine(" Introduce el precio del producto");
// double precioProducto = double.Parse(Console.ReadLine());
// if (precioProducto < 50) Console.WriteLine($"Precio del producto: {precioProducto}");
// else if (50 <= precioProducto && precioProducto < 100) Console.WriteLine($"Precio del producto con descuento: {precioProducto * 0.95}");
// else Console.WriteLine($"Precio del producto con descuento: {precioProducto * 0.90}");

////ejercicio 11
//Console.WriteLine("introduce un nuemro del 1 al 7");
//int diadelasemana = int.Parse(Console.ReadLine());
//switch (diadelasemana) {case 1: Console.WriteLine ("lunes");
//break;
//case 2: Console.WriteLine ("martes");
//  break;
//case 3: Console.WriteLine ("miercoles");
//  break;
//case 4: Console.WriteLine ("jueves");
//   break;
//case 5: Console.WriteLine ("viernes");
//     break;
//case 6: Console.WriteLine ("sabado");
//      break;
//default: Console.WriteLine ("domingo");
//break;}

// //Ejercicio 12
// Console.WriteLine("MENU: \n 1.- Crear \n 2.- Consultar \n 3.- Modificar \n 4.- Elminiar");
// Console.WriteLine("Elija una opción.");
// int opcion = int.Parse(Console.ReadLine());

// switch (opcion)
// {
//     case 1: Console.WriteLine ("Crear");
//         break;
//     case 2: Console.WriteLine("Consultar");
//         break;
//     case 3: Console.WriteLine ("Modificar");
//         break;
//     case 4: Console.WriteLine ("Eliminar");
//         break;
//     default: Console.WriteLine ("Opción no válida");
//         break;
//  }
//ejercicio 13
// Console.WriteLine("elige operacion matematica: \n 1.- * \n 2.- + \n 3.- - \n 4.- /");
//Console.WriteLine("Elija una opción.");
//int opcion = int.Parse(Console.ReadLine());
//Console.WriteLine("introduce el primer numero");
//double numero131 = double.Parse(Console.ReadLine());
//Console.WriteLine("introduce el segundo numero");
//double numero132 = double.Parse(Console.ReadLine());


//switch (opcion)
//{
//    case 1: 
//        Console.WriteLine ($"{numero131} x {numero132} = {numero131*numero132}");

//        break;
//    case 2: 
//        Console.WriteLine ($"{numero131} + {numero132} = {numero131+numero132}");

//        break;
//    case 3: 
//        Console.WriteLine ($"{numero131} - {numero132} = {numero131-numero132}");

//        break;
//    case 4: 
//        Console.WriteLine ($"{numero131} / {numero132} = {numero131/numero132}");
//        break;
//    default: 
//        Console.WriteLine ("Opción no válida");
//        break;
//}

// //Ejercicio 14
// Console.WriteLine("elige un numero del 1 al 12");
// int opcion = int.Parse(Console.ReadLine());


// switch (opcion)
// {
//     case 1:
//         Console.WriteLine("Enero");

//         break;
//     case 2:
//         Console.WriteLine("Febrero");

//         break;
//     case 3:
//         Console.WriteLine("Marzo");

//         break;
//     case 4:
//         Console.WriteLine("Abril");
//         break;
//     case 5:
//         Console.WriteLine("Mayo");
//         break;
//     case 6:
//         Console.WriteLine("Junio");
//         break;
//     case 7:
//         Console.WriteLine("Julio");
//         break;
//     case 8:
//         Console.WriteLine("Agosto");
//         break;
//     case 9:
//         Console.WriteLine("Septiembre");
//         break;
//     case 10:
//         Console.WriteLine("Octubre");
//         break;
//     case 11:
//         Console.WriteLine("Noviembre");
//         break;
//     case 12:
//         Console.WriteLine("Diciembre");
//         break;

//     default:
//         Console.WriteLine("Opción no válida");
//         break;
// }

//ejercicio 15
//Console.WriteLine("introduce un numero del 1 al 3");
//int numero15 = int.Parse(Console.ReadLine());
//string grado = numero15 switch
//{
//    1=>"bajo",
//    2=>"medio",
//    3=>"alto",
//};
//Console.WriteLine($"el grado es {grado}");

// //Ejercicio 16
// Console.WriteLine("Elige un numero del 1 al 7");
// int numero16 = int.Parse(Console.ReadLine());
// string diasemcorto = numero16 switch
// {
//     1 => "Lun",
//     2 => "Mar",
//     3 => "Mie",
//     4 => "Jue",
//     5 => "Vie",
//     6 => "Sab",
//     7 => "Dom",
//     _ => "???",
// };
// Console.WriteLine($" {diasemcorto} ");

//ejercicio 17
//object dato = 25.5;
//if (dato is int numero17)
//{
//    Console.WriteLine($"el dato es un numero entero y su valor es {numero17}");

//}
//else
//{ 
//    Console.WriteLine("el dato no es un numero entero");

//}

//Ejercicio 18
// object dato18 = 15.5;
// if(dato18 is int resultado18)
// {
//     if (resultado18 > 18)
//     {
//         Console.WriteLine($"El numero es entero y su valor es {resultado18}, mayor que 18");
//     }
//     else 
//     {
//         Console.WriteLine("El numero es menor que 18");
//     }
// }
// else 
// {
//     Console.WriteLine("El numero no es un entero");
// }
// ejericio 19
//object dato1 = 25;
//object dato2 = "hola";
//object dato3 = 8.5;
//if(dato1 is int numero1911)
//{
//    Console.WriteLine("dato1 es un numero entero");

//}
//if(dato1 is double numero1912)
//{
//    Console.WriteLine("dato1 es double");

//}
//if (dato1 is string numero1913)
//{
//    Console.WriteLine("dato1 es un texto");

//}
//if(dato2 is int nuemro1921)
//{
//    Console.WriteLine("dato2 es un numero entero");

//}
//if(dato2 is double numero1922)
//{
//    Console.WriteLine("dato2 es double");

//}
//if(dato2 is string numero1923)
//{
//    Console.WriteLine("dato2 es un texto");

//}
//if(dato3 is int nuemro1931)
//{
//    Console.WriteLine("dato3 es un numero entero");

//}
//if(dato3 is double numero1932)
//{
//    Console.WriteLine("dato3 es double");

//}
//if(dato3 is string numero1933)
//{
//    Console.WriteLine("dato3 es un texto");

//}

// //Ejercicio 20
// int i;
// for (i = 1; i <= 10; i++) 
// {
//     Console.WriteLine($"{i} ");
// }


//ejercicio 
int i;
for ( i=1; i<=10;i++)
{
    Console.WriteLine($"{i*2}");
    
}
