//Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 
//и выдаёт номер четверти плоскости, в которой находится эта точка.

//----------------------------------------------------------------------------------------------
//Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти (x и y).
/*
void ShowDiapazon(int quadNum)
{
  
    if(quadNum == 1) Console.WriteLine("Координаты x>0, y>0");
    if(quadNum == 2) Console.WriteLine("Координаты x<0, y>0");
    if(quadNum == 3) Console.WriteLine("Координаты x<0, y<0");
    if(quadNum == 4) Console.WriteLine("Координаты x>0, y<0");
}
Console.WriteLine("Input quad number  = ");
int quadNum = Convert.ToInt32(Console.ReadLine());
ShowDiapazon(quadNum);*/





//--------------------------------------------------------------------------------------------------
//Напишите программу, которая принимает на вход число (N) и выдаёт квадраты чисел от 1 до N.
/*
void QuadNum(int number)
{
    int result = 1;
    while (result<=number)
    {
        Console.Write(Math.Pow(result,2)+ " ");
        result++;
    }

}
Console.Write("Input number = ");
int number = Convert.ToInt32(Console.ReadLine());
QuadNum(number);
*/





//--------------------------------------------------------------------------------------------------
//Напишите программу, которая принимает на вход 
//координаты двух точек и находит расстояние между ними в 2D пространстве.

double Distance(double xA, double yA, double xB, double yB)
{
    double result = Math.Sqrt(Math.Pow((xB - xA),2)+Math.Pow((yB - yA),2));
    return result;
}
Console.WriteLine("Input coordinate xA =");
double xA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input coordinate yA =");
double yA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input coordinate xB =");
double xB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input coordinate yB =");
double yB = Convert.ToDouble(Console.ReadLine());
double distanse = Distance(xA, yA, xB, yB);
Console.WriteLine(distanse);