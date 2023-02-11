
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
Console.WriteLine(Numbers(array, a, b));