using MyLib;

// Урок 9. Рекурсия

void Task64(int M, int N)
{
    // Задача 64: Задайте значения M и N. Напишите рекурсивный метод, который выведет все 
    // натуральные числа кратные 3-ём в промежутке от M до N.

    if (M > N) return;
    if (M % 3 == 0) Console.Write($"{M} ");
    Task64(M + 1, N);
}

int M = MyLibClass.Input("Введите значение M: ");
int N = MyLibClass.Input("Введите значение N: ");
Console.WriteLine($"Все натуральные числа кратные 3-ём в промежутке от {M} до {N}: ");

Task64(M, N);


