Console.WriteLine("Hello");

Console.WriteLine("Please input the first number");
var firstAsText = Console.ReadLine();
var number1 = int.Parse(firstAsText);

Console.WriteLine("Please input the second number");
var secondAsText = Console.ReadLine();
var number2 = int.Parse(secondAsText);

Console.WriteLine("What do you want to do with those numbers?\n[A]dd\n[S]ubtract\n[M]ultiply");
var option  = Console.ReadLine();


if (EqualsCaseInsensitive(option, "A"))
{
    int result = number1 + number2;
    PrintFinalEquation(number1, number2, result, "+");
}
else if (EqualsCaseInsensitive(option, "S"))
{
    int result = number1 + number2;
    PrintFinalEquation(number1, number2, result, "-");

}
else if (EqualsCaseInsensitive(option, "M"))
{
    int result = number1 + number2;
    PrintFinalEquation(number1, number2, result, "*");
}

else
{
    Console.WriteLine("That is not a valid option");

}

Console.WriteLine("Press any key to close.");
Console.ReadKey();

void PrintFinalEquation(
    int number1, int number2, int result, string @operator)
{
    Console.WriteLine(
        number1 + " " + @operator + " " + number2 + " = " + result); 
}

bool EqualsCaseInsensitive(string left, string right) 
{ 
    return left.ToUpper() == right.ToUpper();
}