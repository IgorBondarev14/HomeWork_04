// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
//возводит число A в натуральную степень B.
Console.WriteLine("Введите число 1");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2");
int b = Convert.ToInt32(Console.ReadLine());
int exp = a;
for (int i = 1; i < b ; i++)
    exp = exp * a;
Console.WriteLine("Если " + a + " возвести в степень " + b + " получится:");
Console.WriteLine(exp);
