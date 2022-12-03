double firstDotFirstCoordinate = ConverInputIntoDouble("Enter the first coordinate of the first dot ");
double firstDotSecondCoordinate = ConverInputIntoDouble("Enter the second coordinate of the first dot ");
double firstDotThirdCoordinate = ConverInputIntoDouble("Enter the third coordinate of the first dot ");
double secondDotFirstCoordinate = ConverInputIntoDouble("Enter the first coordinate of the second dot ");
double secondDotSecondCoordinate = ConverInputIntoDouble("Enter the second coordinate of the second dot ");
double secondDotThirdCoordinate = ConverInputIntoDouble("Enter the third coordinate of the second dot ");
double firstCathetus = Cathetus(firstDotFirstCoordinate, secondDotFirstCoordinate);
double secondCathetus = Cathetus(firstDotSecondCoordinate, secondDotSecondCoordinate);
double thirdCathetus = Cathetus(firstDotThirdCoordinate, secondDotThirdCoordinate);
double distance = Distance(firstCathetus, secondCathetus, thirdCathetus);
Console.WriteLine(distance);


double Cathetus(double a, double b)
{
    double cathetus = (b - a);
    return cathetus;
}


double Distance(double a, double b, double c)
{
    double dist = Math.Sqrt((Math.Pow(a, 2)) + (Math.Pow(b, 2)) + (Math.Pow(c, 2)));
    return Math.Round(dist, 2);
}



double ConverInputIntoDouble(string message)
{
    Console.Write(message);
    bool isParsed = double.TryParse(Console.ReadLine(), out double number);
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