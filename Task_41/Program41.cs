// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.WriteLine("Введите числа через запятую");
int[] numbers = Console.ReadLine().Split(", ").Select(int.Parse).ToArray(); //Просто интересно было посмотреть, как разделит не через пробел

Console.WriteLine(String.Join(" ", numbers));
Console.Write("Положительных чисел: ");
int count = 0;// На лекции показывали, что переменную можно просто объявить, не присваивая значения, но так не работает...
int i = 0;
void CountPositive(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    Console.WriteLine(count);
}
CountPositive(numbers);
