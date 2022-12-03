int yourNumber = ConvertInputIntoInt("Enter your number ");
int[] arrayOfCubes = new int [yourNumber];
int startNumber = 1;
FillArrayWithCubes(arrayOfCubes, startNumber);
PrintArray(arrayOfCubes);


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write(array[i] + ", ");
        }
        else
        {
            Console.Write(array[i]);
        }
    }
}


void FillArrayWithCubes(int[] array, int a)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = (int)Math.Pow(a, 3);
        a++;
    }
}


int ConvertInputIntoInt(string message)
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