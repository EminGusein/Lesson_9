using MyLib;

// Урок 9. Рекурсия

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

int Task68(int m, int n)
{

    if (m == 0) return n + 1;
    else if (n == 0) return Task68(m - 1, 1);
    else return Task68(m - 1, Task68(m, n - 1));
}

Console.Clear();

int m = MyLibClass.Input("Введите значение m: ");
int n = MyLibClass.Input("Введите значение n: ");

Console.WriteLine(Task68(m, n));




