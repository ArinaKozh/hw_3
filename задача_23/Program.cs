/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

int GetNumber(string message)
{
   int result = 0;
   bool isCorrect = false;

   while(!isCorrect)
   {

    Console.WriteLine(message);

    if (int.TryParse(Console.ReadLine(), out result) && result>0)
    {
        isCorrect = true;
    } 
    else
    {
        Console.WriteLine("Неверно ввели число");
    }
   } 
   return result;
}
int N = GetNumber("Введите натуральное число");
int i = 1;
while(i<=N)
{
    if (i<N)
    {
    Console.Write($"{Math.Pow(i, 3)},  ");
    i++;
    }
    else
    {
    Console.Write($"{Math.Pow(i, 3)} ");
    i++;  
    }
}