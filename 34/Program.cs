// задайте массив, заполненный случайными положительными трехзначными числами.
// напишите программу, которая покажет количество четных чисел в массиве


int quantityNum = 8;
int[] arr = new int[quantityNum];
Random numbers = new Random();
int count = 0;

for (int i = 0; i < quantityNum; i++)
{
    arr[i] = numbers.Next(100, 1000);
    Console.WriteLine(arr[i]);
    if (arr[i] % 2 == 0) 
    {
        count++;
    }
}
Console.WriteLine("Количество четных чисел в массиве: " + count);