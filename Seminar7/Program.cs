/*
void FillArray(int[,] matrix)
{
    for(int i=0; i<matrix.GetLength(0); i++)
    {
        for(int j=0; j<matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(1,20);
        }
    }
}
void PrintArray(int [,] matr)
{
    for(int i=0; i<matr.GetLength(0); i++)
    {
        for(int j=0; j<matr.GetLength(1); j++)
        {
            Console.Write($"  {matr[i,j]}  ");
        }
    Console.WriteLine();
    }
}
 int[,] matrix = new int[5,6];
 FillArray(matrix);
 PrintArray(matrix);*/

 //---------------------------------------------------------------------------------------------
//Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
/*int[,] CreateRandom2dArray()
{
    Console.WriteLine("Input number rows = ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input number columns = ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input number minValue = ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input number maxValue = ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows,columns];
    for(int i = 0; i<rows; i++)
    
        for(int j = 0; j<columns; i++)
            array[i,j] = new Random().Next(minValue, maxValue);
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i =0; i<array.GetLength(0); i++)
    {   
        for(int j = 0; j<array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);*/
//-----------------------------------------------------------------------------------------------------
//Задайте двумерный массив размера m на n, 
//каждый элемент в массиве находится по формуле: Aij = i+j. Выведите полученный массив на экран.
/*
int[,] FillArray(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for(int i=0; i<rows; i++)
    {
        for(int j=0; j<columns; j++)
        {
            matrix[i,j] = i+j;
            
        }
    }
    return matrix;
}
void PrintArray(int [,] matr)
{
    for(int i=0; i<matr.GetLength(0); i++)
    {
        for(int j=0; j<matr.GetLength(1); j++)
        {
            Console.Write($"  {matr[i,j]}  ");
        }
    Console.WriteLine();
    }
}
Console.WriteLine("Input rows = ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input columns = ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillArray(rows, columns);
 
PrintArray(matrix);*/


//-------------------------------------------------------------------------------------------------
//Задайте двумерный массив. Найдите элементы, 
//у которых оба индекса чётные, и замените эти элементы на их квадраты.
/*

int[,] FillArray(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for(int i=0; i<rows; i++)
    {
        for(int j=0; j<columns; j++)
        {
            matrix[i,j] = new Random().Next(1,20);
            
        }
    }
    return matrix;
}
void PrintArray(int [,] matr)
{
    for(int i=0; i<matr.GetLength(0); i++)
    {
        for(int j=0; j<matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j]}  ");
        }
    Console.WriteLine();
    }
    Console.WriteLine();
}

void MakeKvadratEvenNumbers(int[,] array)
{
    for (int i = 0; i< array.GetLength(0); i+=2)
        for(int j = 0; j< array.GetLength(1); j+=2)
            array[i,j] *= array[i,j];
}

    Console.WriteLine("Input number rows = ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input number columns = ");
    int columns = Convert.ToInt32(Console.ReadLine());
    int[,] array = FillArray(rows, columns);
    PrintArray(array);
    MakeKvadratEvenNumbers(array);
    PrintArray(array);*/
    
//----------------------------------------------------------------------------------
//Задайте двумерный массив. Найдите сумму элементов, 
//находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

/*
int[,] FillArray(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for(int i=0; i<rows; i++)
    {
        for(int j=0; j<columns; j++)
        {
            matrix[i,j] = new Random().Next(1,20);
            
        }
    }
    return matrix;
}
void PrintArray(int [,] matr)
{
    for(int i=0; i<matr.GetLength(0); i++)
    {
        for(int j=0; j<matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j]}  ");
        }
    Console.WriteLine();
    }
    Console.WriteLine();
}

int SumElementMainDiagonal(int[,] array)
{
    int sum = 0;
    for(int i=0; i<array.GetLength(0); i++)
    {
        {
            sum += array[i,i];
        }
    }
 return sum;
}
 
    Console.WriteLine("Input number rows = ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input number columns = ");
    int columns = Convert.ToInt32(Console.ReadLine());
    int[,] array = FillArray(rows, columns);
    PrintArray(array);
    int sum = SumElementMainDiagonal(array);
    Console.WriteLine($"Сумма элементов главной диагонали = {sum} ");*/
    //--------------------------------------------------------------------------------------
   //Задача 47. Задайте двумерный массив размером m×n, 
   //заполненный случайными вещественными числами.
   /*
    double[,] FillArray()
    {
        Console.WriteLine("Input quality of rows = ");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input qualityof columns = ");
        int columns = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input min value = ");
        int minValue = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input max value = ");
        int maxValue = Convert.ToInt32(Console.ReadLine());

        double[,] array = new double[rows, columns];
        for(int i = 0; i<rows; i++)
        {
            for(int j = 0; j<columns; j++)
            {
                array[i,j] = new Random().NextDouble() + new Random().Next(minValue, maxValue);
            }
        }
        return array;
    }
     void ShowArray(double[,] array)
    {
        for(int i=0; i<array.GetLength(0); i++)
        {
            for(int j=0; j<array.GetLength(1); j++)
            {
                Console.Write($"{Math.Round(array[i,j],2)} ");
            }
        Console.WriteLine();
        }
    Console.WriteLine();
    }
   
   double[,] newRandomArray = FillArray();
   ShowArray(newRandomArray);*/

   //------------------------------------------------------------------------------------
   
   //Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
   //и возвращает значение этого элемента или же указание, что такого элемента нет.
  /* double[,] FillArray()
    {
        Console.WriteLine("Input quality of rows = ");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input qualityof columns = ");
        int columns = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input min value = ");
        int minValue = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input max value = ");
        int maxValue = Convert.ToInt32(Console.ReadLine());

        double[,] array = new double[rows, columns];
        for(int i = 0; i<rows; i++)
        {
            for(int j = 0; j<columns; j++)
            {
                array[i,j] = new Random().NextDouble() + new Random().Next(minValue, maxValue);
            }
        }
        return array;
    }
     void ShowArray(double[,] array)
    {
        for(int i=0; i<array.GetLength(0); i++)
        {
            for(int j=0; j<array.GetLength(1); j++)
            {
                Console.Write($"{Math.Round(array[i,j],2)} ");
            }
        Console.WriteLine();
        }
    Console.WriteLine();
    }
    void PositionElement(double[,] array, int row, int column)
    {
        if(row > array.GetLength(0)&& column > array.GetLength(1))
        {
            Console.WriteLine("Такого элемента в массиве нет");
        }
        else 
        {
            Console.WriteLine($" {Math.Round(array[row, column],2)} ");
        }
    }

    Console.WriteLine("Input number of row = ");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input number of column = ");
    int column = Convert.ToInt32(Console.ReadLine());
    double[,] newRandomArray = FillArray();
    ShowArray(newRandomArray);
    PositionElement(newRandomArray, row, column);*/

//------------------------------------------------------------------------------------------
//Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

int[,] FillArray()
{
    Console.WriteLine("Input quality of rows = ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input qualityof columns = ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input min value = ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input max value = ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];
    for(int i = 0; i<rows; i++)
    {
        for(int j = 0; j<columns; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue);
        }
    }
    return array;
}
     
void ShowArray(int[,] array)
{
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
    Console.WriteLine();
    }
Console.WriteLine();
}

double[] AverageOfColumnArray(int[,] array)
{
double[] averageColumnElement = new double[array.GetLength(1)];
for(int j = 0; j<array.GetLength(1); j++)
    {  
    double[] average = new double[array.GetLength(1)];      
    for(int i = 0; i<array.GetLength(0); i++)
        {
            average[j]+= array[i,j];
        }
    averageColumnElement[j] = average[j]/(array.GetLength(0));
    }
     return averageColumnElement;
}

void PrintArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]} ");
    }
Console.WriteLine();
}

int[,] newRandomArray = FillArray();
ShowArray(newRandomArray);
double[] averageColumnElement = AverageOfColumnArray(newRandomArray);
PrintArray(averageColumnElement);