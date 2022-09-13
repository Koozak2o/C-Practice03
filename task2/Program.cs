


// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double Distance_3D(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double dist = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
    return dist;
}
double dist1 = Distance_3D(3, 6, 8, 2, 1, -7);
Console.WriteLine("{0:N2}", dist1);

double dist2 = Distance_3D(7, -5, 0, 1, -1, 9);
Console.WriteLine("{0:N2}", dist2);

//A (3,6,8); B (2,1,-7), -> 15.84

//A (7,-5, 0); B (1,-1,9) -> 11.53
