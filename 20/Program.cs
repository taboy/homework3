//Задача 20: Задать номер четверти, показать диапазоны для возможных координат

Console.WriteLine("print x: "); 
 double x = Convert.ToDouble(Console.ReadLine()); 
 
 Console.WriteLine("print y: "); 
 double y = Convert.ToDouble(Console.ReadLine()); 
 
 if ((x > 0) && (y > 0)) 
    Console.WriteLine("First quarter "); 
 else if ((x < 0) && (y > 0)) 
    Console.WriteLine(" Second Quarter "); 
 else if((x < 0) && (y < 0)) 
    Console.WriteLine("Third Quarter "); 
 else if ((x > 0) && (y < 0)) 
    Console.WriteLine("Fourth quarter "); 
else 
    Console.WriteLine("The point lies on the axis ");