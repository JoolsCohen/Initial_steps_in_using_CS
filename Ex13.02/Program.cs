
int[,] matrix = new int[3, 4];

PrintArray(matrix);

FillArray(matrix);

Console.WriteLine(); // пустая строка чтобы разделить массивы

PrintArray(matrix);



void PrintArray(int[,] matr)    // метод создаем и выводим матрицу
{
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      Console.Write($"{matr[i, j]} "); // чтобы добиться вывода в виде
    }                                      // матрицы такая конструкция
    Console.WriteLine();
  }
}

void FillArray(int[,] matr)
{
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      matr[i, j] = new Random().Next(1, 10); //[1,10]
    }
  }
}