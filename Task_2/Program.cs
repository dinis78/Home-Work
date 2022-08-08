Console.WriteLine("Введите Первое число ");
int numberA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите Второе число. ");
int numberB = int.Parse(Console.ReadLine());

Console.WriteLine("Введите Третье число. ");
int numberC = int.Parse(Console.ReadLine());

int max = numberA;

if (numberB>max) max = numberB;
if (numberC>max) max = numberC;

Console.Write("Максимальное число, ");
Console.WriteLine(max);


    

