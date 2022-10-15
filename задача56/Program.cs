/*
Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Программа считает сумму элементов в каждой строке 
и выдаёт номер строки с наименьшей суммой элементов.
*/
int [,] GenerateArray()
{   
    int m=new Random().Next(3,6);//число строк
    int n=new Random().Next(3,6);//число солбцов
    int [,] array=new int [m,n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j <array.GetLength(1); j++)
        {    
            array[i,j]=new Random().Next(0,10);
        }
    }
    return array;
}
void Color(string data)
{
Console.ForegroundColor=ConsoleColor.Green;
Console.Write(data);
Console.ResetColor();
}
void PrintArray(int [,] array)
{
    Console.Write("\t");
    for (int i = 0; i < array.GetLength(1); i++)
    {       
         Color(i+"\t");
    }
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Color(i+"\t");
        for (int j = 0; j <array.GetLength(1); j++)
        {              
            Console.Write(array[i,j] +"\t");
        }
            Console.WriteLine();
    }
}
int SerchNumberOfMinSumInRows(int [,] array)
{
    int minSumIndexRow=0;
    int [] strokaSum=new int [array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
            for (int j = 0; j <array.GetLength(1); j++)
            {    
                 strokaSum[i]=strokaSum[i]+array[i,j];
            }
        if (strokaSum[i]<strokaSum[minSumIndexRow]) minSumIndexRow=i;
    }
    return minSumIndexRow;
}

int [,] ourArray=GenerateArray();
Color("начальный массив:");
Console.WriteLine();
PrintArray(ourArray);
Color($"минимальная сумма элементов в строке №:{SerchNumberOfMinSumInRows(ourArray)}");
Console.WriteLine();
