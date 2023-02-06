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
ShowArray(myArray);

