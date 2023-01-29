/*
Задача 2

Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

double dotX1 = InputInt("Введите точку X1");
double dotY1 = InputInt("Введите точку Y1");
double dotX2 = InputInt("Введите точку X2");
double dotY2 = InputInt("Введите точку Y2");
double dotZ1 = InputInt("Введите точку Z1");
double dotZ2 = InputInt("Введите точку Z2");

double lengthBetwPoints = findLength(dotX1, dotX2, dotY1, dotY2, dotZ1, dotZ2);
Console.WriteLine($"Расстояние между точками = {lengthBetwPoints:F2}");

double InputInt(string message)
{ 
    Console.Write(message + " > "); 
    string? inputValue = Console.ReadLine(); 
    double result = Convert.ToDouble(inputValue); 
    return result; 
}

double findLength(double xOne, double xTwo, double yOne, double yTwo, double zOne, double zTwo) 
{
     double catet1 = Math.Pow(xOne - xTwo, 2);
     double catet2 = Math.Pow(yOne - yTwo, 2);
     double catet3 = Math.Pow(zOne - zTwo, 2);
     double gipotenusa = Math.Sqrt(catet1 + catet2 + catet3); 
     return gipotenusa; 
}