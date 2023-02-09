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

/*void Compare (int[] nums1, int[] nums2)
{
    int sumnum1 = Sum(nums1);
    int sumnum2 = Sum(nums2);
    if (sumnum1>sumnum2)
        Console.WriteLine("Сумма чисел массива 1 больше");
    else if (sumnum1<sumnum2)
        Console.WriteLine("Сумма чисел массива 2 больше");
    else
        Console.WriteLine("Сумма чисел массива 1= сумме чисел массива 2");
    int Sum(int[] nums)
    {
        int result = 0;
               
        foreach(int num in nums)
        result +=num;
        return result;
    } 
}
int[] numbers1 = {1, 4, 22};
int[] numbers2 = {1, 1, 15, 3};
Compare(numbers1, numbers2);*/

//-------------------------------------------------------------------------------------

void Compare(int[] nums1, int[] nums2)
{
    int fact1 = FNum(nums1);
    int fact2 = FNum(nums2);
    if (fact1 > fact2)
    
    Console.WriteLine("Comp array 1 ");
    else if (fact1 < fact2)  Console.WriteLine("Comp array 2");
    else  Console.WriteLine("Comp array 1 and 2");
   }

int FNum(int[] collections)
{
    int result = 1;
    foreach(int collection in collections)
    result *=collection;
    return result;
}
int[] nums1 = {2,5,3,8};
int[] nums2 = {1,3,2,4};
int fact1 = FNum(nums1);
Console.WriteLine("Произведение элементов массива 1 = " + fact1);
int fact2 = FNum(nums2);
Console.WriteLine("Произведение элементов массива 2 = " + fact2);
Compare(nums1, nums2);

