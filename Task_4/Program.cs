Console.Clear();
Console.WriteLine("Введите число ");
int numberA = int.Parse(Console.ReadLine());

  for(int numberB=2; numberB<=numberA; numberB++) 
  {
   if(numberB%2 == 0) 
   {
    Console.Write("{0} ", numberB);
   }
  }
  Console.ReadKey();
  
 

