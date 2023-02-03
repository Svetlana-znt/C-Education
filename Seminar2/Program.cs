//Напишите программу, которая принимает на вход 
//трёхзначное число и удаляет вторую цифру этого числа.
/*int CutNumber(int number)

{
    int sot = number/100;
    int ed = number%10;
     int result = sot*10 +ed;
     return result;
}

//Console.Write("Input number: ");
//int num = Convert.ToInt32(Console.ReadLine());
int num = new Random().Next(100, 1000);
int newNum = CutNumber(num);
//Console.WriteLine($"new version of {num} is {newNum}");*/
//-------------------------------------------------------------------
//Напишите программу, которая получает случайное число из
// отрезка [10, 99] и показывает наибольшую цифру числа.
/*
int MaxNumber(int number)
{
    int dec = number/10;
    int ed = number%10;
    int result = dec;
    
    if(ed>result)
  {  
    result = ed;
}
  return result;
}

int num = new Random().Next(10, 100);

int max = MaxNumber(num);

Console.WriteLine($"maximum number {num} and {max}");*/



//--------------------------------------------------------------------
//Напишите программу, которая будет принимать на вход два числа и выводить, 
//является ли второе число кратным первому.
/*
bool NumKrat(int number1, int number2)
{
    bool result = false;
    if(number2%number1 == 0)
    {
        result = true;
    }
   
    return result;
}
Console.WriteLine("Input first number  ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number  ");
int num2 = Convert.ToInt32(Console.ReadLine());
bool qrt = NumKrat(num1, num2);
Console.WriteLine(qrt);*/
//------------------------------------------------------------------------------

//Напишите программу, которая принимает на вход два числа и проверяет, 
//является ли одно число квадратом другого.
/*
bool NumQrt(int number1, int number2)
{
 bool result = false;
 if (number1 == number2*number2||number2 == number1*number1)
 {
  result = true;
 }  
 return result;
}
Console.Write("Input first number  = ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input your second number = ");
int num2 = Convert.ToInt32(Console.ReadLine());
bool result = NumQrt(num1,num2);
Console.WriteLine(result);*/

//--------------------------------------------------------------------------------

//Задача 10: Напишите программу, которая принимает на вход трёхзначное число
//и на выходе показывает вторую цифру этого числа.


/*
int CutNum2(int number)
{
  
  int det = number/10%10;
  
  return det;
}
int number = new Random().Next(100, 1000);
Console.WriteLine(number);
int num2 = CutNum2(number);
Console.WriteLine(num2);*/
//-----------------------------------------------------------------------------

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа.
/*
int CutNum3(int col)
{
  int result = -1;
  while (col>1000)
    {
      col = col/10;
    }
    if (col>100)
      {
        result = col%10;
      }
  
  return result;
}

Console.WriteLine("Input number = ");
int number = Convert.ToInt32(Console.ReadLine());
int num = CutNum3(number);
Console.WriteLine(num);*/
//------------------------------------------------------------------
//Решение задачи 13 с помощью массива

 /*
void FillArray(int[] collection)
 {
    int length = collection.Length;
    int index = 0;
while(index<length)
{
    Console.WriteLine("Input element number "+index+" =" );
   collection [index] = Convert.ToInt32(Console.ReadLine());
   
index++;
}
 }
 void PrintArray(int[] coll)
 {
int count = coll.Length;
int position = 0;
while(position<count)
{
    Console.Write(coll[position]);
    Console.WriteLine();
    position++;
}
 }
 int[] array = new int[5];
  FillArray(array);
 PrintArray(array);
 int number3 = array[2];
 Console.WriteLine("Elevment number 3 = " + number3);*/

 //-----------------------------------------------------------------------
// Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.
/*
bool WeekEnd(int day)
{
  bool result = false;
  if(day == 6||day == 7)
  {
    result = true;
  }
  return result;
}
Console.WriteLine("Input week day =");
int day = Convert.ToInt32(Console.ReadLine());
bool result = WeekEnd(day);
Console.WriteLine(result);*/

//---------------------------------------------------------------------------
//Задача 2: Напишите программу, которая на вход принимает два числа 
//и выдаёт, какое число большее, а какое меньшее.
/*
int MaxNumber(int num1, int num2)
{
  int max = num1;
  if (num2>num1)
  {
    max = num2;
  }
  return max;
}
Console.WriteLine("Input number 1 = ");
int num1 = Convert. ToInt32(Console.ReadLine());
Console.WriteLine("Input number 2 = ");
int num2 = Convert.ToInt32(Console.ReadLine());
int max = MaxNumber(num1, num2);
Console.WriteLine("Maximum = " +max);*/
//----------------------------------------------------------
// Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
   // является ли число чётным (делится ли оно на два без остатка). 
bool EvenNum(int number)
{
  bool result = false;
  if(number%2 == 0) result = true; 
  return result;
}
Console.WriteLine("Input number = ");
int number = Convert.ToInt32(Console.ReadLine());
bool result = EvenNum(number);
Console.WriteLine("Result is = " +result);


















