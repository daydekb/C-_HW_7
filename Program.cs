// Условия задачи №1:
// Задайте значения M и N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

// void PrintNumbers(int M, int N)
// {
//     Console.Write(M + " ");
//     M += 1;
//     if (M > N)
//         return;
//     PrintNumbers(M, N);
// }
// PrintNumbers(4, 8);

// Условия задачи №2:
// Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.

// int Akkerman(int m, int n)
// {
//     if (m == 0)
//         return n + 1;
//     if (m > 0 && n == 0)
//         return Akkerman(m - 1, 1);
//     if (m > 0 && n > 0)
//         return Akkerman(m - 1, Akkerman(m, n - 1));
//     return Akkerman(m, n);
// }
// Console.WriteLine(Akkerman(3, 2));

// Условия задачи №3:
// Задайте произвольный массив. Выведете его элементы, 
// начиная с конца. Использовать рекурсию, не использовать циклы.

int[] Arr = { 1, 2, 3, 4, 5 };
int i =Arr.Length;
void PrintArr(int[] Arr)
{
    if (i>0)
    {
        i = i -1;
        Console.Write($"{Arr[i]} ");
        PrintArr(Arr);
    }
}

PrintArr(Arr);