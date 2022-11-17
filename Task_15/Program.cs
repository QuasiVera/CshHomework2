// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным
int numberA;

//Опровобала конструкцию циклического ввода переменной из семинара
while (true)
{
    Console.Write("Введите номер дня недели: ");
    if (int.TryParse(Console.ReadLine(), out numberA) & numberA>0 & numberA<8)
        break;
    Console.WriteLine("Ошибка ввода, введите число от 1 до 7");
}
string result;

if (numberA==6)
{
    result = "да";
} 
else if (numberA==7) 
{
    result = "да";
}
else result = "нет";

Console.WriteLine($"{numberA} -> {result}");