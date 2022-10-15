/*
Треугольник Паскаля
*/
int [,] GenerateArray(int number)
{  
    int [,] array=new int [number,number*2+1];
    array[0,array.GetLength(1)/2]=1;
    for (int i = 1; i < array.GetLength(0); i++)
    {
        for (int j = 1; j <array.GetLength(1)-1; j++)
        {    
            array[i,j]=array[i-1,j-1]+array[i-1,j+1];
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
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Color(i+1+"\t");
        for (int j = 0; j <array.GetLength(1); j++)
        {   
            if (array[i,j]!=0)  Console.Write(array[i,j] +"\t");
            else Console.Write("\t");
        }
            Console.WriteLine();
    }
}
Console.WriteLine("введети число");
int userNumber=Convert.ToInt32(Console.ReadLine());
PrintArray(GenerateArray(userNumber));