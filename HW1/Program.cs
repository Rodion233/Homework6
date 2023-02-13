/* Задача 1: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */
int Prompt(string msg)
{
    System.Console.Write($"{msg}: ");
    int res = Convert.ToInt32(Console.ReadLine());
    return res;
}
int[] GenerateArray(int len)
{
    int[] array = new int[len];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите число {i + 1}: ");
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;
}
int PositivNumber(int[] number)
{
    int Positive = 0;
    for (int i = 0; i < number.Length; i++)
    {
        if (number[i] > 0)
        {
            Positive++;
        }
    }
    return Positive;
}
void PrintArray(int[] array)
{
    foreach (int item in array)
    {
        System.Console.Write($"{item}\t");
    }
    System.Console.WriteLine();
}
int num = Prompt("Какое количество чисел для ввода");
int[] array = GenerateArray(num);
int positivenum = PositivNumber(array);
PrintArray(array);
PositivNumber(array);
System.Console.WriteLine($"Количество положительных чисел равно {positivenum}");