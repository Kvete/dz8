/*
Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
*/
int [,] GenerateArray()
{   
    int m=new Random().Next(3,5);//число строк
    int n=new Random().Next(3,5);//число солбцов
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
int [,] MultiplicationOfArray(int [,] array1, int [,] array2)
{
    int [,] massive=new int [array1.GetLength(0),array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
            for (int j = 0; j <array2.GetLength(1); j++)
            {    
             int sum=0;
             for (int k = 0; k <array2.GetLength(0); k++)
             {
                sum+=array1[i,k]*array2[k,j];
             }
             massive[i,j]=sum;
            }
    }
    return massive;
}

int [,] ourArray1=GenerateArray();
Color("массив A:");
Console.WriteLine();
PrintArray(ourArray1);
int [,] ourArray2=GenerateArray();
Console.WriteLine();
Color("массив B:");
Console.WriteLine();
PrintArray(ourArray2);
Console.WriteLine();
if (ourArray1.GetLength(1)==ourArray2.GetLength(0))
{
    Color("A*B=");
    Console.WriteLine();
    PrintArray(MultiplicationOfArray(ourArray1,ourArray2));
}
else 
{
 Color("матрицы нельзя перемножать! Ко-во столбцов матрицы А не равно ко-ву строк матрицы В");
}
Console.WriteLine();
Console.WriteLine();

