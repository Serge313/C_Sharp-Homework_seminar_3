int yourNumber = GetNumber("Enter your number ");
int[] number = new int [5];
FillArray(number, yourNumber);
PrintArray(number);
Console.WriteLine();
PalindromeOrNot(number);


void PalindromeOrNot(int[] number)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine("It's a palindome!");
    }
    else
    Console.WriteLine("It's NOT a palindrome!");
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
        int cutDigit = a % 10;
        array[i] = cutDigit;
        a = a / 10;
    }
}


int GetNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}