/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/


int Coord(string message)
{
   int result = 0;
   bool isCorrect = false;

   while(!isCorrect)
   {

    Console.WriteLine(message);

    if (int.TryParse(Console.ReadLine(), out result))
    {
        isCorrect = true;
    } 
    else
    {
        Console.WriteLine("Ввели не число");
    }
   } 
   return result;
}

int ax = Coord("Введите х-координату точки А");
int ay = Coord("Введите y-координату точки А");
int az = Coord("Введите z-координату точки А");

int bx = Coord("Введите х-координату точки B");
int by = Coord("Введите y-координату точки B");
int bz = Coord("Введите z-координату точки B");


Console.WriteLine($"Расстояние между точками = {Math.Sqrt(Math.Pow((ax-bx),2)+Math.Pow((ay-by),2)+Math.Pow((az-bz),2))}");