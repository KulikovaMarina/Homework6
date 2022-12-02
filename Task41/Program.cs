// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

int size = 5;
int[] array = new int[size];
int count = 0;

Console.WriteLine($"Введите {size} целых чисел");
for (int i = 0; i < size; i++)
{
    try {
        array[i] = Convert.ToInt32(Console.ReadLine());
        if (array[i] > 0)
        {
            count++;
        }
    } catch {
        Console.WriteLine("Введены некорректные данные. Должны быть числа");
    }
}

Console.WriteLine("Количетво чисел больше нуля равно " + count);