/*
Напишите программу, которая выводит случайное трехзначное число
 и удаляет вторую цифру этого числа. 456-46, 782-72, 918-98.
 */

 Random random = new Random();
int randomNumber = random.Next(100,1000);

Console.WriteLine(randomNumber);

int firstNumber = randomNumber / 100;

int lastNumber = randomNumber % 10;

Console.Write(firstNumber);
Console.Write(lastNumber);
/*

int Number = new Random().Next(100,1000);
Console.WriteLine(Number);
*/