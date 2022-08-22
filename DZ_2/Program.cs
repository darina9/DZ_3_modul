Console.WriteLine("Введите число 1");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2");
int number2 = Convert.ToInt32(Console.ReadLine());
int max;
int min;
if(number1>number2)
{
    max = number1;
    min = number2;
}

 else
  {
    max = number2;
    min = number1;
 }
 Console.WriteLine("макс число  :{0}", max);
 Console.WriteLine("мин число  :{0}", min);
