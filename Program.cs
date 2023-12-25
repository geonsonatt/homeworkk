using System;
using System.Reflection.PortableExecutable;
namespace program;
    class program
    {
    static void Main()
    {
    char[,] mass = new char[1,33]; // Задаём двумерный массив, состоящий из 1 строки и 33 столбцов
     for (int i = 0; i < mass.GetLength(0); i++) //цикл перебора строк
     {
        for (int j = 0; j < mass.GetLength(1); j++) // цикл перебора столбцов 
      {
        mass[i,j] = Convert.ToChar(new Random().Next(41,59)); //генерация рандомных значений юникода и конвертация их в тип char
        Console.Write($"{mass[i,j]} ");  //вывод массива 
      }
      Console.WriteLine();
     }
    }
}