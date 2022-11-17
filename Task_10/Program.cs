// Задача 10. Напишите программу, которая принимает на вход трехзначное число и на выходе 
//показывает вторую цифру этого числа
int numberA;

//Опровобала конструкцию циклического ввода переменной из семинара
while (true)
{
    Console.Write("Введите трехзначное число: ");
    if (int.TryParse(Console.ReadLine(), out numberA) & numberA<999 & numberA>99)
        break;
    Console.WriteLine("Ошибка ввода");
}

int result = (numberA/10)%10;

Console.WriteLine($"{numberA} -> {result}");