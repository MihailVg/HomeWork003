// Задача N3, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите число, кубы до которого будут высчитываться: ");

int N = int.Parse(Console.ReadLine());
int numberA = 1;

if (N < 0)
{
    while (numberA > N)
    {
        Console.Write(numberA * numberA * numberA + ", ");
        numberA = numberA -1;
    }
    Console.Write(numberA * numberA * numberA);
}

if (N > 0)
{
    while (numberA < N)
    {
        Console.Write(numberA * numberA * numberA + ", ");
        numberA++;
    }
    Console.Write(numberA * numberA * numberA);
}