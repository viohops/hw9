// // Задача 66: Задайте значения M и N. Напишите программу, 
// //которая найдёт сумму натуральных элементов в промежутке от M до N.
// // M = 1; N = 15 -> 120
// // M = 4; N = 8. -> 30

// Console.Write("Введите число первое число N: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число второе число M: ");
// int N = Convert.ToInt32(Console.ReadLine());

// void Sum(int numM, int numN, int sum)
// {
//   if (numN < numM)
//   {
//     Console.Write($"Сумма элементов = {sum} ");
//     return;
//   }
//   Sum(numM, numN - 1, sum+numN);
// }

// NumSum(M,N,0);



// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n. 
// m = 2, n = 3 -> A(m,n) = 29

System.Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int Akkerman(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Akkerman(m - 1, 1);
  else return Akkerman(m - 1, Akkerman(m, n - 1));
}
int Akk = Akkerman(M,N);
Console.Write($"Функция Аккермана = {Akk}");