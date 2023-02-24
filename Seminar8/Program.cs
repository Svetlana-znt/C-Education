/*double[,] CreateRandomArray()
    {
        Console.WriteLine("Input quantity rows = ");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input quantity columns = ");
        int columns = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input maxValue = ");
        int maxValue = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input minValue = ");
        int minValue = Convert.ToInt32(Console.ReadLine());

        double[,] array = new double[rows, columns];
        for(int i = 0; i<rows; i++)
            for(int j = 0; j<columns; j++)
                array[i,j] = new Random().Next(minValue, maxValue);
        return array;
    }
void ShowArray(double[,] array)
{
    for(int i = 0; i<array.GetLength(0); i++)
        {
        for(int j = 0; j<array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]}  ");
        }
        Console.WriteLine();
        }
    Console.WriteLine();
  }

double[,] newArray = CreateRandomArray();
ShowArray(newArray);*/

//-----------------------------------------------------------------------------
//Задайте двумерный массив. Напишите программу, 
//которая поменяет местами первую и последнюю строку массива.

//------------------------------------------------------------------------------------
//Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
/*
int[,] CreateRandomArray()
    {
        Console.WriteLine("Input quantity rows = ");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input quantity columns = ");
        int columns = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input maxValue = ");
        int maxValue = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input minValue = ");
        int minValue = Convert.ToInt32(Console.ReadLine());

        int[,] array = new int[rows, columns];
        for(int i = 0; i<rows; i++)
            for(int j = 0; j<columns; j++)
                array[i,j] = new Random().Next(minValue, maxValue);
        return array;
    }
void ShowArray(int[,] array)
{
    for(int i = 0; i<array.GetLength(0); i++)
        {
        for(int j = 0; j<array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]}  ");
        }
        Console.WriteLine();
        }
    Console.WriteLine();
  }
  
void ReverseArray(int[,] array)
{
    if(array.GetLength(0) == array.GetLength(1))
        for(int i = 0; i<array.GetLength(0);i++)
        {
            for(int j = i+1; j<array.GetLength(1); j++)
            {
                int temp = array[i,j];
                array[i,j] = array[j,i];
                array[j,i] = temp;
            }          
        }
    else Console.WriteLine("Матрица не квадратная");
}
int[,] newArray = CreateRandomArray();
ShowArray(newArray);
ReverseArray(newArray);
ShowArray(newArray);*/

//-------------------------------------------------------------------------------------------
//Из двумерного массива целых чисел удалить строку и столбец, 
//на пересечении которых расположен наименьший элемент.
/*
int[,] CreateRandomArray()
    {
        Console.WriteLine("Input quantity rows = ");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input quantity columns = ");
        int columns = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input maxValue = ");
        int maxValue = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input minValue = ");
        int minValue = Convert.ToInt32(Console.ReadLine());

        int[,] array = new int[rows, columns];
        for(int i = 0; i<rows; i++)
            for(int j = 0; j<columns; j++)
                array[i,j] = new Random().Next(minValue, maxValue);
        return array;
    }
void ShowArray(int[,] array)
{
    for(int i = 0; i<array.GetLength(0); i++)
        {
        for(int j = 0; j<array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]}  ");
        }
        Console.WriteLine();
        }
    Console.WriteLine();
  }
int[] PositionMinElemeentArray(int[,] array)
{
    int imin = 0;
    int jmin = 0;
    for(int i =0; i<array.GetLength(0); i++)
        for(int j = 0; j<array.GetLength(1); j++)
            if(array[i,j]<array[imin, jmin])
            {
                jmin = j;
                imin = i;
            }
    int[] pos = {imin, jmin};
    return pos;
}

int[,] DeleteRowColumnMinElement(int[,] array, int[] pos)
{
    int[,] newArray = new int[array.GetLength(0)-1, array.GetLength(1)-1];
    for(int i = 0, x = 0; i<array.GetLength(0); i++)
    {
        if(i != pos[0])
        {
            for(int j = 0, y = 0; j<array.GetLength(1); j++)
            {
                if(j != pos[1])
                {
                    newArray[x,y] = array[i,j];
                    y++;
                }  
            }
            x++;
        }        
    }
    return newArray;
} 

int[,] newArray = CreateRandomArray();
ShowArray(newArray);
int[] pos = PositionMinElemeentArray(newArray);
int[,] matrix = DeleteRowColumnMinElement(newArray, pos);
ShowArray(matrix);*/
//--------------------------------------------------------------------------------------
//Задача 54: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
Console.Clear();
Console.WriteLine($"Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.");
Console.WriteLine($"\nВведите размер массива m x n и диапазон случайных значений:");
int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");
int range = InputNumbers("Введите диапазон: от 1 до ");

int[,] array = new int[m, n];
CreateArray(array);
WriteArray(array);

Console.WriteLine($"\nОтсортированный массив: ");
OrderArrayRows(array);
WriteArray(array);

void OrderArrayRows(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void WriteArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
  }
}*/
/*
//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.
Console.WriteLine("Введите размер массива m x n и диапазон случайных значений:");
int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");
int range = InputNumbers("Введите диапазон: от 1 до ");

int[,] array = new int[m, n];
CreateArray(array);
WriteArray(array);

int minSumLine = 0;
int sumLine = SumLineElements(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int tempSumLine = SumLineElements(array, i);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    minSumLine = i;
  }
}

Console.WriteLine($"\n{minSumLine+1} - строкa с наименьшей суммой ({sumLine}) элементов ");


int SumLineElements(int[,] array, int i)
{
  int sumLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}*/
//----------------------------------------------------------------------------------
//Задача 58: Задайте две матрицы. 
//Напишите программу, которая будет находить произведение двух матриц.

Console.WriteLine("Введите размеры матриц и диапазон случайных значений:");
int m = InputNumbers("Введите число строк 1-й матрицы: ");
int n = InputNumbers("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int p = InputNumbers("Введите число столбцов 2-й матрицы: ");
int range = InputNumbers("Введите диапазон случайных чисел: от 1 до ");



int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

int[,] firstMartrix = new int[m, n];
CreateArray(firstMartrix);
Console.WriteLine($"Первая матрица:");
WriteArray(firstMartrix);

int[,] secomdMartrix = new int[n, p];
CreateArray(secomdMartrix);
Console.WriteLine($"Вторая матрица:");
WriteArray(secomdMartrix);

int[,] resultMatrix = new int[m,p];

MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine($"Произведение первой и второй матриц:");
WriteArray(resultMatrix);

//Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
//которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*
int[,,] CreateRandomArray()
    {
        Console.WriteLine("Input quantity rows = ");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input quantity columns = ");
        int columns = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input quantity depth = ");
        int depth = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input minValue = ");
        int minValue = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input maxValue = ");
        int maxValue = Convert.ToInt32(Console.ReadLine());

        int[,,] matrix = new int[rows, columns, depth];
        Random rnd = new Random();   
        for (int i = 0; i < matrix.GetLength(0); i++) 
        {            
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int k = 0; k < matrix.GetLength(2); k++)                 
                    {                       
                        matrix[i,j,k] = rnd.Next(minValue, maxValue + 1);
                    }
            }             
        }
        return matrix;  
    }

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i <  matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
            Console.Write($" {matrix[i, j, k]} {(i,j,k)} ");            
            }
        Console.WriteLine();
        }         
    }  
    Console.WriteLine();      
}

int[,,] CreateArray(int[,,] array3D)
{
  int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < array3D.GetLength(0); x++)
  {
    for (int y = 0; y < array3D.GetLength(1); y++)
    {
      for (int z = 0; z < array3D.GetLength(2); z++)
      {
        array3D[x, y, z] = temp[count];
        count++;
      }
    }
  }
  return array3D;
}


 
int[,,] array3D = CreateRandomArray();
PrintMatrix(array3D);
int[,,]unicumNumbergArray =CreateArray(array3D);
PrintMatrix(unicumNumbergArray);*/

//Задача 62.Напишите программу, которая заполнит спирально массив 4 на 4.
/*Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());

int[,] nums = new int[size, size];

int num = 1;
int i = 0;
int j = 0;

while (num <= size * size)
{
    nums[i, j] = num;
    if (i <= j + 1 && i + j < size - 1)
        ++j;
    else if (i < j && i + j >= size - 1)
        ++i;
    else if (i >= j && i + j > size - 1)
        --j;
    else
        --i;
    ++num;
}

PrintArray(nums);

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}*/
  

