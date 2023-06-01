Console.WriteLine("rows = ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("columns = ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("min = ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("max = ");
int max = Convert.ToInt32(Console.ReadLine());


var A_B = CreatingArray(rows, columns, min, max); 

WriteArray(A_B);
Sort(ref A_B);
Console.WriteLine("sorted:");    
WriteArray(A_B);
void Sort(ref int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int h = 0; h < array.GetLength(1); h++)
            {
                if (array[i, j] > array[i,h])
                {
                    (array[i, j], array[i, h]) = (array[i, h], array[i, j]);
                }
            }
        }
    }   
} 

int[,] CreatingArray (int rows, int columns,int min, int max)
{
    var array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(min, max);
        }
    }
    return array;
}

void WriteArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j]+"\t");
        }
        Console.WriteLine();
    }
   
}