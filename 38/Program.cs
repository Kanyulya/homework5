// Задать массив вещественных чисел (double).
// Найти разницу между максимальным и минимальным элементами массива

int N = 7;                            //
int[] num = new int[N];               //
Random arr = new Random();            //

int imax = 0;
int imin = 0;
double result = 0;

for (int i = 0; i < N; i++)
{
    num[i] = arr.Next(-100, 100);        //

    if (num[i] > num[imax])
    {
        imax = i;
    }
    else if (num[i] < num[imin])
    {
        imin = i;
    }
    Console.WriteLine(num[i]);
}
result = num[imax] - num[imin];
Console.WriteLine("Разница между максимальным и минимальным значениями равна " + result);

// для исполнения программы с заданным массивом нужна эта строка начале:
// double[]num = new double[5]{3,7,22,2,78}; 
// плюс удалить строки с пометкой  "//" и заменить "N" на "num.Lenght"