using MyLib;

// Урок 9. Рекурсия

// Задача 66: Задайте значения M и N. Напишите рекурсивный метод, который найдёт сумму натуральных 
// элементов в промежутке от M до N.

int Task66(int M, int N, int sum = 0)
{
    if (M > N) return sum;
    sum = sum + M;
    return Task66(M + 1, N, sum);
}

Console.Clear();

int M = MyLibClass.Input("Введите значение M: ");
int N = MyLibClass.Input("Введите значение N: ");
int sum = Task66(M, N);
Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N равна: {sum}");

