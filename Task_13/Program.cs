// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или 
// сообщает, что третьей цифры нет
// Через логарифм
Console.WriteLine("Введите число N: ");
string inputNumber = Console.ReadLine() ?? "";

int numberN = int.Parse(inputNumber);
int nThird = 3;                                  // Переменная nThird чтобы не было магических чисел
string resDescrip;
int result;

int countN = (int)Math.Log10(numberN) + 1;

if (countN<nThird)
{
    resDescrip = "Третьей цифры нет";
}
else
{
    int degree = (int)Math.Pow(10, countN-nThird);  // Считаем 10^(countN-nThird)
    result = (numberN/degree)%10;                   // Делим на 10^(countN-nThird), чтобы отбросить цифры справа от третьей
                                                    // % - чтобы получить саму третью цифру 
    resDescrip = $"{numberN} -> {result}";
}

Console.WriteLine(resDescrip);
