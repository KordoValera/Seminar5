// Задайте массив из 12 элементов, заполненный случайными числами из промежутка
// [-9,9]. Найдите сумму отрицательных и положительных элементов массива. 
// Например, в массиве [3, 9, -8, 1, 0, -7, 2, -1, 8, -3, -1, 6] сумма положительных
// чисел равна 29, сумма отрицательных равна -20.

void FillArr(int[]array)
{
    int index = 0;
    while (index < array.Length)
    {
        array[index] = new Random().Next(-9, 10);
        index++;
    }
}
void PrintArr(int[]Narray)
{
    int count = Narray.Length;
    int pos = 0;
    while (pos < count)
    {
        Console.Write($"{Narray[pos]} ");
        pos++;
    }
}
void Summ(int[]array)
{
    int count = 0;
    int SumMin = 0;
    int SumPlus = 0;
    while (count < array.Length)
    {
        if (array[count] < 0)
        {
            SumMin = SumMin + array[count];
            count ++;
        }
        else
        {
            SumPlus = SumPlus + array[count];
        }
    }
    Console.WriteLine($"Сумма отрицательных значений: {SumMin}");
    Console.WriteLine($"Сумма положительных значений: {SumPlus}");
}

int[]arr = new int[12];
FillArr(arr);
PrintArr(arr);
Summ(arr);

