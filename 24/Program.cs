//Задача 24: Найти кубы чисел от 1 до N


Console.WriteLine("write a number");
int num = int.Parse(Console.ReadLine());
void cube(int num1){
    for(int i=0;i<num1;i++){
        Console.WriteLine(i*i*i);
    }
}
cube(num);