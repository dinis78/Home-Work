Console.Clear();

//Задача №10

// int num = new Random().Next(100,999);

// int rezult = (num%100)/10;

// Console.WriteLine($"{num} -> {rezult}");

////////////////////////

//Задача №13

// int numA = new Random().Next();


// if (numA>99 && numA<1000)
// {
//    int rezult= numA%10;
//        Console.WriteLine($"{numA} -> {rezult}");
// }
// if (numA<100)
// {
//     Console.WriteLine ("У числа нет третьей цыфры");
// }
// while (numA>999) 
// numA=(numA/10); 
// if (numA>99 && numA<1000)
//  {
//     int rezult= (numA%10);
//      Console.WriteLine($"{numA} -> {rezult}");
//  }
  // так циклится
// {

//  int numB=  (numA/10); 

// if (numB>99 && numB<1000)
 
//     numB= (numB%10);

//      Console.WriteLine($"{numA} -> {numB}");

// }

//////////////////////////////////////////

//Задача 

Console.WriteLine("Введите число от 1 до 7 ");
int numA =int.Parse(Console.ReadLine());

if (numA>0 && numA<6)
{
 Console.WriteLine("Будний день(((");
}

if (numA>5 && numA<7)
{
  Console.WriteLine("Суббота Выходной!!!");
}
if (numA>6 && numA<8)
{
  Console.WriteLine("Ура Воскесенье Выходной!!!!");
}