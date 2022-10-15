/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
 Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

int [,,] GenerateArray(int m, int n, int k)
{   
    int temp=0;
    int [,] dictionary=new int[2,100];
    for (int x = 0; x <100 ; x++)
    {
        dictionary[0,x]=x;
    }
    int [,,] array=new int [m,n,k];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j <array.GetLength(1); j++)
        {    
            for (int z = 0; z <array.GetLength(2); z++)
            {
                temp=new Random().Next(10,100);
                if (dictionary[1,temp]==0) 
                {
                    array[i,j,z]=temp; 
                    dictionary[1,temp]=1;
                }
                else z-=1;
            }  
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
void PrintArray(int [,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j <array.GetLength(1); j++)
        {    
            for (int k = 0; k < array.GetLength(2); k++)
            {
              Console.Write($"{array[i,j,k]} ({i},{j},{k}) \t");  
            }  
            Console.WriteLine();        
        }
            Console.WriteLine();
    }
}

int m=new Random().Next(2,4);
int n=new Random().Next(2,4);
int k=new Random().Next(2,4);
int [,,] ourArray=GenerateArray(m,n,k);
PrintArray(ourArray);
