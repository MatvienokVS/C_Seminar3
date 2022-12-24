//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

using static System.Console;
Clear();


Write("Точка A --> Введите координату x: ");
int.TryParse(ReadLine(), out int ax);
Write("Точка A --> Введите координату y: ");
int.TryParse(ReadLine(), out int ay);
Write("Точка A --> Введите координату z: ");
int.TryParse(ReadLine(), out int az);
Write("Точка B --> Введите координату x: ");
int.TryParse(ReadLine(), out int bx);
Write("Точка B --> Введите координату y: ");
int.TryParse(ReadLine(), out int by);
Write("Точка B --> Введите координату z: ");
int.TryParse(ReadLine(), out int bz);


WriteLine($"{Math.Sqrt(Math.Pow((bx - ax), 2) + Math.Pow((by - ay), 2) + (Math.Pow((bz - az), 2))):f2}");


