// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int AckermanFunction(int numN, int numM)
{
    if (numN == 0) 
        return numM + 1;
    else if (numM == 0)
        return AckermanFunction(numN-1, 1);
    return AckermanFunction(numN - 1, AckermanFunction(numN, numM - 1));
}


Console.Clear();
Console.Write("Введите целое число m: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число n: ");
int numN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"A(m,n) = {AckermanFunction(numM, numN)}");