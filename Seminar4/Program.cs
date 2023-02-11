//Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

//Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
/*
int QuantityNumber(int num)
{
    int count = 0;
    while(num != 0)
    {
        num = num/10;
       count++; 
    }
return count;
}
Console.WriteLine("Input your number = ");
int num = Convert.ToInt32(Console.ReadLine());
int result = QuantityNumber(num);
Console.WriteLine($"Количество чисел в {num} = {result}");
*/

//Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
/*
int ProisvNumber(int num)
{
   int proisv = 1;
    for (int count = 1; count<=num; count++)
    {
        
        proisv = proisv*count;
      
    }
return proisv;
}
Console.WriteLine("Input your number = ");
int num = Convert.ToInt32(Console.ReadLine());
int Factorial = ProisvNumber(num);
Console.WriteLine("Факториал =" +Factorial);*/
/*
int[] CreateRandomArray(int size, int MinValue, int MaxValue)
{
    int[] array = new int[size];
    for (int i = 0; i<size; i++)
    {
        array[i] = new Random(). Next(MinValue, MaxValue+1);
    }
    return array;
}
void ShowArray(int[] array)
{
for (int index = 0; index<array.Length; index++)
Console.Write(array[index] + " ");
Console.WriteLine();
}
Console.Write("Input a length a new array = ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value = ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value = ");
int max= Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, min, max);
ShowArray(myArray);*/

//---------------------------------------------------------------------------

//Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
/*
double PowNum(int numA, int numB)
{
    double result = Math.Pow(numA, numB);
    return result;
}
Console.WriteLine("Input numA = ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input numB = ");
int numB = Convert.ToInt32(Console.ReadLine());
double pownum = PowNum(numA, numB);
Console.WriteLine("А в стпенеи В = " + pownum);*/

//-----------------------------------------------------------------------------------------
//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int NumSum(int num)
{
    int sum = 0;
    while(num/10 != 0 || num%10 != 0)
    {
       sum = sum + num%10;
       num = num/10;
    }
    return sum;
}
Console.WriteLine("Input your number = ");
int num = Convert.ToInt32(Console.ReadLine());
int sumnum = NumSum(num);
Console.WriteLine(sumnum);*/

//----------------------------------------------------------------------------------------------

//Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
/*
void Array(int [] collection)
{

    for(int index =0; index<collection.Length; index++)
    {
        Console.WriteLine("  Input element number "+ index + "  = ");
        collection [index]= Convert.ToInt32(Console.ReadLine());
    }
}

 void PrintArray(int[] coll)
 {
 for (int current = 0; current<coll.Length;current++)
    {
        Console.Write("  " + coll[current] + "   ");
    }
 }
 Console.WriteLine("Input array size = ");
 int size = Convert.ToInt32(Console.ReadLine());
 int [] array = new int [size];
 Array(array);
  PrintArray(array);*/
//-----------------------------------------------------------------------------------------------------
/*
void Array(int[] collection)
{
    for(int index = 0; index<collection.Length; index++)
    {
        Console.WriteLine("Input element number  "+ index + " = ");
        collection [index] = Convert.ToInt32(Console.ReadLine()); 
    }
}
void PrintArray(int [] collection)
{
    for (int current = 0; current<collection.Length; current++)
    {
        Console.Write("   "+ collection [current] +"   ");
    }
}
int MaxElement(int [] collection)
{
    int max = collection [0];
    for(int count = 1; count<collection.Length; count++)
    {
        if (collection[count]>max) max = collection[count];   
    }
    return max;
}
Console.WriteLine("Input array size = ");
int size = Convert.ToInt32(Console.ReadLine());
int [] array = new int [size];
Array(array);
PrintArray(array);
Console.WriteLine();
int max = MaxElement(array);
Console.WriteLine("Your max number is =" +max);*/
//-----------------------------------------------------------------------------------------------
