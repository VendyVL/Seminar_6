// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
Console.WriteLine("Введите числа"); //непонятно, как объяснить пользователю, что он вообще вводит. Четыре случайных числа или какие-то конкретные параметры.
Console.Write("b1 = ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("k1 = ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("b2 = ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("k2 = ");
int k2 = Convert.ToInt32(Console.ReadLine());

// y = k1 * x + b1
// y = k2 * x + b2
// Точка пересечения (x; y) Есть какая-то общая формула или нужно сначала решить уравление вручную? 
// k1 * x + b1=k2 * x + b2 => x=(b2-b1)/(k1-k2)
Console.WriteLine($"y = {k1} * x + {b1}");
Console.WriteLine($"y = {k2} * x + {b2}");

//double x = ((b2 - b1)/(k1 - k2)); Я не понимаю почему, но без промежуточного действия результат неверный.
double b = (b2 - b1);
double k = (k1 - k2);
double x = b / k;
double y = ((k2 * x) + b2);

Console.WriteLine($"Точка пересечения прямых, заданных этими уравнениями ({Math.Round(x,2)};{Math.Round(y,2)})");
