// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int GetSumRecurs(int num2, int num1)
{
    if (num2 == num1) return (num2);
    return GetSumRecurs(num2 - 1, num1) + num2;
}


Console.Clear();
Console.WriteLine("Введите первое целое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма натуральных чисел от {num1} до {num2} равна {GetSumRecurs(num2, num1)}");