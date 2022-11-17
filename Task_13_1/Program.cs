// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или 
// сообщает, что третьей цифры нет
// Много делений на 10
Console.WriteLine("Введите число N: ");
string inputNumber = Console.ReadLine() ?? "";

int numberN = int.Parse(inputNumber);
string resDescrip;
int result;

if (numberN < 100)
{
    resDescrip = "третьей цифры нет";
}
else
{
    while (numberN > 999)
    {
        numberN = numberN / 10;
    }
result = numberN % 10;
resDescrip= $"{inputNumber} -> {result}";
}

Console.WriteLine(resDescrip);
