int MaxDigit(int argument)
{
    int argument1 = argument / 10;
    int argument2 = argument % 2;
    int result = argument1;
    
    if(argument1 > argument2)
    {
        result = argument1;
    }
    else 
    {
        result = argument2;
    }
    return result;
}

int number = new Random(). Next(10,100);

Console.WriteLine($"случайно число из отрезка 10-99 => {number}");


int maxdigit = MaxDigit(number);
Console.WriteLine(maxdigit);








