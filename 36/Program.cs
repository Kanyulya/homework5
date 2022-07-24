// задайте одномерный массив, заполненный случайными числами. 
// найти сумму элементов, стоящих на НЕчетных позициях


int quantityNum = 10;
int[] arr = new int[quantityNum];
Random numbers = new Random();
int sumNeg = 0;

for (int i = 0; i < quantityNum; i++)
{
    arr[i] = numbers.Next(0, 100);
    Console.WriteLine(arr[i]);
    if (i % 2 != 0)
    {
        sumNeg = sumNeg + arr[i];
    }
}
Console.WriteLine("Сумма чисел на нечетных позициях равна " + sumNeg);