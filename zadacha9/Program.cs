/*
9.Напишите программу, которая выводит случайное число из отрезка [10,99] 
и показывает наибольшую цифру числа.
*/
Random random = new Random();
int randomNumber = random.Next(10,100);

Console.WriteLine(randomNumber);

int firstNumber = randomNumber / 10;

int lastNumber = randomNumber % 10;

if(lastNumber > firstNumber)
{
    Console.WriteLine($"Максимальное число {lastNumber}");
}
else
{
 Console.WriteLine($"Максимальное число {firstNumber}");
}
