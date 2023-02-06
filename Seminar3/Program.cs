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
/*
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
Console.WriteLine(distanse);*/
//------------------------------------------------------------------------------------------------------
//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
bool PalindromNum(int number, int n)
{
        int number1 = number;
    double newnum = 0;
    while (number1>0)
    {
      newnum = newnum + number1%10 * Math.Pow(10,n);
      number1 = number1/10;  
      n = n - 1;
    }
    
     bool solve = false;
     if(newnum == number) 
        {
            solve = true;
        }
        return solve;
}
    Console.WriteLine("Input number = " );
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input power of your number = ");
    int n = Convert.ToInt32(Console.ReadLine());
    bool solve = PalindromNum(number, n);
    Console.WriteLine("Число явялется палиндромом = " + solve);*/

//------------------------------------------------------------------------------------------
//Задача 21 Напишите программу, которая принимает на вход координаты 
//двух точек и находит расстояние между ними в 3D пространстве.
/*
double DistAB(int xA, int yA, int zA, int xB, int yB, int zB)
{
    double result = Math.Sqrt(Math.Pow((xB-xA),2) + Math.Pow((yB-yA), 2) + Math.Pow ((zB-zA),2));
        return result;
}
Console.WriteLine ("Input  xA = ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input  yA = ");
int  yA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input coordinate zA = "); 
int zA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input  xB = ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input  yB = ");
int  yB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input zB = "); 
int zB = Convert.ToInt32(Console.ReadLine());

double distanceAB = DistAB(xA, yA, zA, xB, yB, zB);
Console.WriteLine("Distance is = " + Math.Round(distanceAB,2));*/

//Задача 23 Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N.

void NumCub(int num)
{
    for (int current = 1; current <=num; current++)
    {
        Console.Write(Math.Pow(current, 3)+  "  ");
    }
}
Console.WriteLine("Input num = ");
int num = Convert.ToInt32(Console.ReadLine());
NumCub(num);