int Max(int arg1, int arg2, int arg3)
{
  int result = arg1;
  if (arg2 > result) result = arg2;
  if (arg3 > result) result = arg3;
  return result;
}
// int a1 = 15; заменяем ввод отдельных переменных на массив
// int b1 = 21;
// int c1 = 39;
// int a2 = 12;
// int b2 = 2311;
// int c2 = 33;
// int a3 = 13;
// int b3 = 22223;
// int c3 = 313;

//     индекс   0   1   2   3    4    5   6    7    8
int[] array = { 15, 21, 39, 12, 2311, 33, 13, 22223, 313 };

int max = Max(Max(array[0], array[1], array[2]),
              Max(array[3], array[4], array[5]),
              Max(array[6], array[7], array[8])
             );

Console.WriteLine(max);