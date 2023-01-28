/*int number1  = 5;
int number2 = 8;

//Console.WriteLine("My numbers are " + number1 + " and " + number2 + " its good! ");
Console.WriteLine($"My numbers are {number1} and {number2} and its good!");*/
//-----------------------------------------------------------------------------

/* Console.Write("Input your integer number ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("My number is " + num);*/

//------------------------------------------

//Задача 1. Напишите программу, которая на вход принимает два числа и проверяет, 
// является ли первое число квадратом второго.

/*Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number ");
int num2 = Convert.ToInt32(Console.ReadLine());

int quad2 = num2*num2;

if (num1 == quad2)
{
 Console.WriteLine("Yes");   
}
else
{
    Console.WriteLine("No");
}
*/
//------------------------------------------------------------------------
//Задача 2: Напишите программу, которая на вход принимает два числа 
//и выдаёт, какое число большее, а какое меньшее.

/*Console.Write("Input your first number ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input your second number ");
int num2 = Convert.ToInt32(Console.ReadLine());

int max = num1;
if (max>num2)
{
    Console.WriteLine("max = " + num1);
}
else
{
   Console.WriteLine("max = " + num2); 
} */
//--------------------------------------------------------------------------

//Задача 4: Напишите программу, которая принимает на вход три числа 
//и выдаёт максимальное из этих чисел.

Console.Write("Input first number = ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number = ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third number = ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (num2>max)
{
   if(num3>num2)
   {
    Console.WriteLine("Maximum = " +num3);
   }
   else
   {
     Console.WriteLine("Maximum = " +num2);
   } 
}
else
{
    if (num3>max)
    {
      Console.WriteLine("Maximum = " +num3);  
    }
    else
    {
        Console.WriteLine("Maximum = " + num1);
    }
}
       

