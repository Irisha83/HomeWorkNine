// 1. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// void ShowNums(int n)
// {
//   if (n < 1) return;
//   Console.Write(n + " ");
//   ShowNums(n - 1);
// }
//  ShowNums(10);

//  2. Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// int SumOfNum(int n, int m)
// {
//   if (n < m) return n += SumOfNum(n + 1, m);
//   if (n > m) return n += SumOfNum(n - 1, m);
//   else return n;
// }

// Console.WriteLine(SumOfNum(1, 15));

// 3. Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int A(int n, int m) 
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return A(n - 1, 1);
    else
      return A(n - 1, A(n, m - 1));
}

Console.WriteLine(A(3, 2));