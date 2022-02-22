//Задача 22: Найти расстояние между точками в пространстве 2D/3D

Double x1, x2, y1, y2, z1, z2, distance; 

Console.WriteLine( " Press 1 " + "The distance between points on the plane. "); 
Console.WriteLine( " Press 2 " + "Distance between points in space. "); 
int num=int.Parse(Console.ReadLine());

 
if( num==1){
Console.Write("Enter coordinates x1: "); 
x1 = Convert.ToDouble(Console.ReadLine()); 
 
Console.Write("Enter coordinates x2: "); 
x2 = Convert.ToDouble(Console.ReadLine()); 
 
Console.Write("Enter coordinates y1: "); 
y1 = Convert.ToDouble(Console.ReadLine()); 
Console.Write("Enter coordinates y2: "); 
y2 = Convert.ToDouble(Console.ReadLine()); 
 
distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)); 
Console.WriteLine($"Distance between points on the plane {distance}");} 

  
if(num==2){
Console.Write("Enter coordinates x1: "); 
 x1 = Convert.ToDouble(Console.ReadLine()); 
 
Console.Write("Enter coordinates x2: "); 
x2 = Convert.ToDouble(Console.ReadLine()); 
 
Console.Write("Enter coordinates y1: "); 
 y1 = Convert.ToDouble(Console.ReadLine()); 
 
Console.Write("Enter coordinates y2: "); 
 y2 = Convert.ToDouble(Console.ReadLine()); 
 
Console.Write("Enter coordinates z1: "); 
z1 = Convert.ToDouble(Console.ReadLine()); 
 
Console.Write("Enter coordinates z2: "); 
z2 = Convert.ToDouble(Console.ReadLine()); 
 
distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)); 
Console.WriteLine($"Distance between points in space  {distance}"); 

             }