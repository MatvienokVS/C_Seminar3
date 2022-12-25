//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.


using static System.Console;
Clear();



if (!int.TryParse(ReadLine(), out int num))
{
	WriteLine("Ошибка ввода. Введено не число.");
	return;
}
else
{
	WriteLine("\\num/-\\num^3/");

	while (num > 0)
	{
		WriteLine($"{"  "}{num} {" | "} {Math.Pow(num, 3)}");
		WriteLine("-------------");
		num--;
	}
}