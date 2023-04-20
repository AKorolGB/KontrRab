Console.Clear();

Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] array = new string[n];
for (int i = 0; i < array.Length; i++)
{
Console.Write($"Введите {i+1} элемент массива: ");
  array[i]= Console.ReadLine();
}
int longb = 0;
int f = 0;
for (int i = 0; i < array.Length; i++)
if (array[i].Length <= 3)
{
longb = longb +1;
}

string[] barray = new string[longb];    
for (int i = 0; i < array.Length; i++)
if (array[i].Length <= 3){
barray[f] = array[i];
f = f +1;
}

Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Новый  массив: [{string.Join(", ", barray)}]");

