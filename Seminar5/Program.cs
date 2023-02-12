
/*int[] NewColl(int size, int MinValue, int MaxValue)
{   int[] collection = new int[size];
    for (int i = 0; i<size; i++)
    {
        collection[i] = new Random().Next(MinValue, MaxValue);
    }
    return collection;
}
void ShowArray(int[] collection)
{
    for(int index = 0; index<collection.Length; index++)
    {
        Console.Write(collection[index]+ "  ");
    }
}
Console.WriteLine("Input size of array = ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input possible min value = ");
int minval = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input possible max value = ");
int maxval = Convert.ToInt32(Console.ReadLine());
int[] array = NewColl(size, minval, maxval);
ShowArray(array);  */

//---------------------------------------------------------------------------------------
/*
void NewArray(int[] collection)
{
    for(int i = 0; i<collection.Length; i++)
    {
    Console.WriteLine("Input element number "+i+" = ");
    collection[i] = Convert.ToInt32(Console.ReadLine());
    }
}
void ShowArray(int[] coll)
{
    for(int index = 0;  index<coll.Length; index++)
    {
        Console.Write(coll[index] + "  ");
    }
}
int[] array = new int[4];
NewArray(array);
ShowArray(array);*/
//--------------------------------------------------------------------------------
//Задайте массив из 12 элементов, заполненный случайными 
//числами из промежутка [-9, 9]. Найдите сумму отрицательных элементов массива.
//------------------------------------------------------------------------------------------
//Напишите программу замена элементов массива: 
//положительные элементы замените на соответствующие отрицательные, и наоборот.
/*
int[] NewColl(int size, int MinValue, int MaxValue)
{   int[] collection = new int[size];
    for (int i = 0; i<size; i++)
    {
        collection[i] = new Random().Next(MinValue, MaxValue);
    }
    return collection;
}
void ShowArray(int[] collection)
{
    for(int index = 0; index<collection.Length; index++)
    {
        Console.Write(collection[index]+ "  ");
    }
    Console.WriteLine();
}

int[] ReverseArray(int[] collection)
{
    for(int index=0; index<collection.Length; index++)
        collection[index] *=(-1);
    return collection;
}
Console.WriteLine("Input size of array = ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input possible min value = ");
int minval = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input possible max value = ");
int maxval = Convert.ToInt32(Console.ReadLine());
int[] array = NewColl(size, minval, maxval);
ShowArray(array);  
array = ReverseArray(array);
ShowArray(array);*/


//-------------------------------------------------------------------------------------------------

//Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
/*void NewArray(int[] collection)
{
    for(int i = 0; i<collection.Length; i++)
    {
    Console.WriteLine("Input element number "+i+" = ");
    collection[i] = Convert.ToInt32(Console.ReadLine());
    }
}
void ShowArray(int[] coll)
{
    for(int index = 0;  index<coll.Length; index++)
    {
        Console.Write(coll[index] + "  ");
    }
    Console.WriteLine();
}
bool NumberFind(int find, int[] coll)
{
    for(int index = 0; index<coll.Length; index++)
        if (coll[index] == find)  
            return true;
    return false;
}


int[] array = new int[5];
NewArray(array);
ShowArray(array);
Console.WriteLine("Input find = ");
int find = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(NumberFind(find, array));*/

//----------------------------------------------------------------------------------------------------------

//Задайте массив из m случайных чисел. 
//Найдите количество элементов массива, значения которых лежат в отрезке [a,b].
/*
void NewArray(int[] collection)
{
    for(int i = 0; i<collection.Length; i++)
    {
    Console.WriteLine("Input element number "+i+" = ");
    collection[i] = Convert.ToInt32(Console.ReadLine());
    }
}
void ShowArray(int[] coll)
{
    for(int index = 0;  index<coll.Length; index++)
    {
        Console.Write(coll[index] + "  ");
    }
    Console.WriteLine();
}
int Numbers(int[] array, int a, int b)
{
    int count = 0;
    for(int i = 0; i<array.Length; i++)
        if (array[i]>=a && array[i]<=b)
        count++;
    return count;            
}
int[] array = new int[5];
NewArray(array);
ShowArray(array);
Console.WriteLine("Input a = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input b = ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Numbers(array, a, b));*/
//-------------------------------------------------------------------------------------------
//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int[] RandomCollection(int size, int minvalue, int maxvalue)
{
    int[] randomarray = new int[size];
    for(int index = 0; index<size; index++)
        randomarray[index] = new Random().Next(minvalue, maxvalue);
    return randomarray;
}
void PrintCollection(int[] randomcoll)
{
    for (int i = 0; i<randomcoll.Length; i++)
    Console.Write(randomcoll[i] + "  ");
    Console.WriteLine(); 
}


int NumberOfEvenNumbers(int[] randomcoll)
{
    int count = 0;
    for(int index = 0; index<randomcoll.Length; index++)
        if(randomcoll[index]%2 == 0) count+=1;
    return count;
}

Console.WriteLine("Input size of array = ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min value of array's element = ");
int minvalue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max valueof array's element = ");
int maxvalue = Convert.ToInt32(Console.ReadLine());
int[] randomarray = RandomCollection(size, minvalue, maxvalue);
PrintCollection(randomarray);
int count = NumberOfEvenNumbers(randomarray);
Console.WriteLine(count);*/

//-----------------------------------------------------------------------------------------

//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
/*
int RandomArray(int size, int minValue, int maxValue)
{
    int[] randomarray = new int[size];
    for(int index = 0; index < size; index++)
        randomarray[index] = new Random().Next(minValue, maxValue);
    return randomarray;
}
void ShowRandomArray(int[] newarray)
{
    for(int i = 0; i<newarray.Length; i++)
        Console.Write(newarray[i] + "   ");
        Console.WriteLine();
}
int SumOddNumbersPosition(int[] collection)
{
    int sum = 0;
    for(int i = 0; i<collection.Length; i++)
        if(i%2 != 0)
            sum += collection[i];
    return sum;
}

Console.WriteLine("Input size of array = ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min value of array = ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max valueof array = ");
int maxValue = Convert.ToInt32(Console.ReadLine());
int[] randomArray = RandomArray(size, minValue, maxValue);
ShowRandomArray(randomArray);
int Sum = SumOddNumbersPosition(randomArray);
Console.WriteLine(Sum);*/
//------------------------------------------------------------------------
//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

double FloatArray(int size, int minnum, int maxnum)
{
    double[] collection = new double[size];
    for(int i = 0; i<size; i++)
        collection[i] = new Random.NextDouble() + new Random().Next(minnum, maxnum);
    return collection; 
}
void ShowFloatArray(double[] collection)
{
    for (int i = 0; i<collection.Length; i++)
        Console.Write(collection [i] + "  ");
        Console.WriteLine();
}

double DifNumber(double[] collection)
{
    double max = collection[0];
    double min = collection[0];
    for(int index = 1; index<collection.Length; index++)
    {
        if(collection[index]>max) {max = collection[index];}
        if(collection[index]<min) {min = collection[index];}
    double difnum = max - min;
    return difnum;
    }
}
Console.WriteLine("Input size of array = ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min value of element = ");
int minnum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max value of element = ");
int maxnum = Convert.ToInt32(Console.ReadLine());
double[] collection = Math.Round(FloatArray(size, minnum, maxnum),2);
ShowFloatArray(collection);
double difnum = Math.Round(DifNumber(collection),2);
Console.WriteLine(difnum);

