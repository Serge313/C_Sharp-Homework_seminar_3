int yourNumber = ConverInputIntoInt("Enter your number ");
int size = GetSizeOfArray(yourNumber);
int[] array = new int [size];
int[] flippedArray = new int [size];
FillArray(array, yourNumber);
PrintArray(array); //проверка корректности заполнения первого массива
Console.WriteLine();
FlipAndFillArray(array, flippedArray);
PrintArray(flippedArray); //проверка корректности заполнения второго(перевернутого) массива
Console.WriteLine();

if (!array.SequenceEqual(flippedArray))
{
    Console.WriteLine("It's NOT a palindrome!");
    return;
}
else
{
    Console.WriteLine("It's a palindrome!");
}


void FlipAndFillArray(int[] array1, int[] array2)
{
    for (int i = array1.Length - 1; i >= 0; i--)
    {
        for (int j = 0; j < array2.Length; j++)
        {
            array2[j] = array1[i];
            i--;
        }
    }
}


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
    }
}


void FillArray(int[] array, int a)
{
    for (int i = array.Length - 1; i >= 0; i--)
    {
        array[i] = a % 10;
        a /= 10;
    }
}


int GetSizeOfArray(int a)
{
    int counter = 0;
    while (a > 0)
    {
        a /= 10;
        counter++;
    }
    return counter;
}


int ConverInputIntoInt(string message)
{
    Console.Write(message);
    bool isParsed = int.TryParse(Console.ReadLine(), out int number);
    if (isParsed)
    {
        return number;
    }
    else
    {
        Console.WriteLine("Invalid value entered!");
        return -1;
    }
}