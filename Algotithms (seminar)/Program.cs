// Console.WriteLine("Hello, World!");

// Реализовать в классе MyLinkedList, который начали на уроке, следующие методы


// 1. public int size() - получение размера списка, проитерировався по всей структуре
// 1.1 * Можно завести переменную size, поддерживать ее и использовать ее.

//string 
var people = new List<string>() { "Tom", "Bob", "Sam" };
for (int i = 0; i < people.Count; i++)
{
  Console.WriteLine(people[i]);
}

//int
int[] CreateArrayRndInt(int size, int min, int max)
{
  int[] arr = new int[size];
  Random rnd = new Random();

  for (int i = 0; i < arr.Length; i++)
  {
    arr[i] = rnd.Next(min, max + 1);
  }
  return arr;
}


// 2. public boolean contains(int value) - проверка наличия элемента по значению
// string
var people1 = new List<string>() { "Eugene", "Mike", "Kate", "Tom", "Bob", "Sam" };
var containsBob = people.Contains("Bob");     //  true
var containsBill = people.Contains("Bill");    // false
// проверяем, есть ли в списке строки с длиной 3 символа
var existsLength3 = people.Exists(p => p.Length == 3);  // true
// проверяем, есть ли в списке строки с длиной 7 символов
var existsLength7 = people.Exists(p => p.Length == 7);  // false
// получаем первый элемент с длиной в 3 символа
var firstWithLength3 = people.Find(p => p.Length == 3); // Tom
// получаем последний элемент с длиной в 3 символа
var lastWithLength3 = people.FindLast(p => p.Length == 3);  // Sam
// получаем все элементы с длиной в 3 символа в виде списка
List<string> peopleWithLength3 = people.FindAll(p => p.Length == 3);
// peopleWithLength3 { "Tom", "Bob", "Sam"}

//int
bool IsPresent(int[] arr, int number)
{
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] == number) return true;
  }
  return false;
}


// 3. public int popLast() - удаление последнего элемента. Если список пустой - то ошибка
//string
List<string> people2 = new List<string>() { "Eugene", "Mike", "Kate", "Tom", "Bob", "Sam", "Tom", "Alice" };
people2.RemoveAt(people2.Count - 1); //  удаляем последний элемент
Console.WriteLine(String.Join(", ", people2));
// people = { "Eugene", "Mike", "Kate", "Tom", "Bob", "Sam", "Tom" };

//int
int[] array = { 1, 2, 3, 4, 5 };
array = array.SkipLast(1).ToArray();
Console.WriteLine(String.Join(",", array));


// 4. * Переделать все int значения на дженерик T, чтобы можно было хранить значения любых типов
//этот метод на C# мы не проходили, постаралась разобраться сама, но не уверена, что он эффективный
bool TryParseOf<TType>(string s, out TType result)
{
  var converter = System.ComponentModel.TypeDescriptor.GetConverter(typeof(TType));
  try
  {
    result = (TType)converter.ConvertFromString(s)!;
  }
  catch (ArgumentException)
  {
    result = default!;
    return false;
  }
  return true;
}


// 5. * public MyLinkedList reversed() - создать НОВЫЙ список, порядок в котором обратный текущему
Console.WriteLine("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array1 = new int[n];
for (int i = 0; i < n; i++)
{
  for (int j = 0; j < n - 1; j++)
  {
    if (array[j] > array[j + 1])
    {
      int temp = array[j];
      array[j] = array[j + 1];
      array[j + 1] = temp;
    }
  }
  Console.WriteLine(i + "[" + string.Join(", ", array) + "]");
}
