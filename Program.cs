using System;
using System.Reflection.PortableExecutable;
using System.Runtime.Serialization;
namespace program;
    class program
    {
    static void Main()
    {
    int[,] mass = new int[10,10]; 
    Console.WriteLine("Ввод позиции строки ");
    int numberCow = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ввод позиции столбца ");
    int numberCow1 = Convert.ToInt32(Console.ReadLine());
    if (numberCow > mass.GetLength(0) || numberCow < 0 || numberCow1 > mass.GetLength(1) || numberCow1 < 0 )
    {
     Console.WriteLine("Неверно заданы значения");   
    }
    else
    {
     for (int i = 0; i < mass.GetLength(0); i++) 
     {
        for (int j = 0; j < mass.GetLength(1); j++) 
      {
        mass[i,j] = new Random().Next(41,59); 
        Console.Write($"{mass[i,j]} "); 
      }
      Console.WriteLine();
     }
     Console.Write($"{mass[numberCow - 1,numberCow1 -1 ]} ");
    }
    }
}