

// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76



Console.Clear();
int a = 10;
int b = 99;
int c = 1000;
int [] massiv = GetRandomArray (a, b, c);

Console.WriteLine ($"Массив случайных чисел [{String.Join (", ", massiv)}]");
int[] GetRandomArray (int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }

    return result;
}


int result = array (massiv);

 Console.WriteLine ($"Разность {result}");




int array (int [] a){
int max= 0;
int i = 0;
int min = a[i];
for (; i<a.Length; i++)
{
  if (a[i]>max){
    max=a[i];
  }
  if (a[i]<=min){
    min=a[i];
  }
  
}
int res = max-min;
Console.WriteLine ($" max = {max}, min = {min}");
return res;
}


