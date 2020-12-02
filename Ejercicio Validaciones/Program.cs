using System;

namespace Actividad_CSharp_3_Trimestre
{
    class Program
    {
        static void Main(string[] args)
        {
            string Menu = "00";
           
            while (Menu != "0") 
            { 

                Console.WriteLine("/***    MENU    ***/ \n" +

                              "1-> Leer un numero por teclado y definir si es par o impar\n" +

                              "2-> Leer un numero por teclado y generar las tablas de multiplicar de ese numero del 1 al 10.\n" +

                              "3-> Generar las tablas de multiplicar del 2 al 9, cada una del 1 al 10.\n" +

                              "4-> Leer un numero por teclado y definir si es primo o no. = \n" +

                              "5->  Dado el vector edad [12,50,23,10,18,35,41,85,16,45],ordenarlos en forma ascendente.\n" +

                              "6-> Leer un nombre por teclado y definir si existe y en caso de existir mostrar su edad de lo contrario un mensaje que el nombre no existe. \n" +

                              "7-> Partiendo de los vectores anteriores buscar el menor y el mayor y presentar sus respectivos nombres con su edad. \n" +

                              "8-> Dado un palabra definir si es palíndromo o no. \n" +

                              "0-> Salir." );
                Menu = Console.ReadLine();

                Console.Clear();



                switch (Menu)
                {
                    case "1":
                        int num = 0;
                        Console.WriteLine("Digite un número");
                        num = int.Parse(Console.ReadLine());
                        if (num % 2 == 0)
                        {
                            Console.WriteLine(" El número es par");
                        }
                        else
                        {
                            Console.WriteLine("El número es impar \n");
                        }
                        break;



                    case "2":
                        int numero;
                        int Resultado;
                        Console.WriteLine("Ingrese un número");
                        numero = Convert.ToInt32(Console.ReadLine());
                        for (int i = 1; i <= 10; i++)
                        {
                            Resultado = numero * i;
                            Console.WriteLine(numero + "x" + i + "=" + Resultado);
                        }
                        break;


                    case "3":
                        int rango;
                        Console.WriteLine("Ingrese un número entre el 2 y el 9");
                        rango = Convert.ToInt32(Console.ReadLine());
                        for (int a = 1; a <= rango; a++)
                        {
                            for (int b = 2; b <= 9; b++)
                                Console.WriteLine(a + "x" + b + "=" + (a * b));
                            Console.WriteLine("");


                        }
                        break;


                    case "4":
                        int x, y, z;
                        z = 0;
                        Console.WriteLine("Ingrese un número: ");
                        x = int.Parse(Console.ReadLine());

                        for (y = 1; y <= x; y++)
                        {
                            if (x % y == 0)
                            {
                                z = z + 1;
                            }
                        }
                        if (z > 2)
                        {
                            Console.WriteLine(" El número No es primo: ", x);
                        }
                        else
                        {
                            Console.WriteLine(" El número  es primo: ", x);
                        }
                        break;

                    case "5":
                        int [] n = { 12, 50, 23, 10, 18, 35, 41, 85, 16, 45 };
                        
                        int temp;
                        int t = n.Length;

                        Console.WriteLine(" Arreglo real");

                        foreach (int elemento in n)
                        {
                            Console.Write(elemento + " | ");

                        }
                        Console.WriteLine(" Tamaño del arreglo " + t);

                        for (int j = 1; j < t; j++)
                        {


                            for (int m = 0; m < t - 1; m++)
                            {
                                if (n[m] > n[m + 1])
                                {
                                    temp = n[m];
                                    n[m] = n[m + 1];
                                    n[m + 1] = temp;
                                }
                            }
                        }

                            Console.WriteLine(" Arreglo en orden ");
                            foreach (int elemento in n)
                            {
                                Console.Write(elemento + " | ");
                            }
                            Console.WriteLine("");
                            Console.ReadKey();
                                                                          
               

                        break;
                         
                    case "6":
                        int[] edades = new int[] { 12, 50, 23, 10, 18, 35, 41, 85, 16, 45 };
                        string[] nombre = new string[] { "juan", "maria", "teresa", "pedro", "javier", "ana", "diana", "jorge","dayana","lady" };
                        bool encontrado = false;
                        Console.WriteLine("Escriba un nombre que desea buscar");
                        string nombres = Console.ReadLine().ToLower().Trim();

                        for (int k = 0; k < nombres.Length; k++)
                        {
                            if (nombres == nombre[k])
                            {
                                for (int e = 0; e < edades.Length; e++)
                                {
                                    if (e == k)
                                    {
                                        encontrado = true;
                                        Console.WriteLine("Nombre: " + nombre[k] + "\nedad: " + edades[e]);
                                    }
                                }
                            }
                        }

                        if (encontrado == false)
                                
                        {
                                Console.WriteLine("El nombre ingresado es incorrecto");
                        }
                        Console.ReadKey();
                            break;

                            
                            
                        
                        

                    case "7":
                        break;

                    case "8":
                        string palabra, inverso, caracter;
                        int g;
                        Console.WriteLine(" Ingrese una palabra");
                        palabra = Convert.ToString(Console.ReadLine());
                        g = palabra.Length;
                        inverso = "";

                        for(int f=g-1; f >= 0; f--)
                        {
                            caracter = palabra.Substring(f, 1);
                            inverso = inverso + caracter;
                        }
                        if (palabra== inverso)
                        {
                            Console.WriteLine(" La palabra ingresada en Palíndromo");
                        }
                        else
                        {
                            Console.WriteLine(" La palabra ingresada NO es Palíndromo");
                        }

                        break;                                                           


                }
                 Console.ReadKey();

            }
                
            
        }
    }
}
