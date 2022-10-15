/*
Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
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
            array[i,j]=new Random().Next(10,100);
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
int [,] SortNumbersRows(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j <array.GetLength(1)-1; j++)
        {    
            for (int k = j+1; k <array.GetLength(1); k++)
            {
                if (array[i,j]<array[i,k])
                {
                    int temp=array[i,j];
                    array[i,j]=array[i,k];
                    array[i,k]=temp;
                }
            }
        }
    }
    return array;
}

int [,] ourArray=GenerateArray();
Color("начальный массив:");
Console.WriteLine();
PrintArray(ourArray);
Color("отсортированный массив:");
Console.WriteLine();
PrintArray(SortNumbersRows(ourArray));

