
//Assignment 1:


Console.WriteLine("Enter Day number : ");
int Day = Convert.ToInt32(Console.ReadLine());

if (Day == 1)
{
    Console.WriteLine("Sunday");
}
else if (Day == 2)
{
    Console.WriteLine("Monday");
}
else if (Day == 3)
{
    Console.WriteLine("Tuesday");
}
else if (Day == 4)
{
    Console.WriteLine("Wednesday");
}
else if (Day == 5)
{
    Console.WriteLine("Thursday");
}
else if (Day == 6)
{
    Console.WriteLine("Friday");
}
else if (Day == 7)
{
    Console.WriteLine("Saturday");
}
else if (Day < 1)
{
    Console.WriteLine("Invalid Input");
}
else if (Day > 7)
{
    Console.WriteLine("Invalid Input");
}

//Assignment 2:

Console.WriteLine("Enter Month number : ");
int Month = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Year number : ");
int Year = Convert.ToInt32(Console.ReadLine());

if (Month < 1 || Month > 12)
{
    Console.WriteLine("Invalid Month Input");
}

int days;


if (Month == 1 || Month == 3 || Month == 5 || Month == 7 || Month == 8 || Month == 10 || Month == 12)
{
    days = 31;
}
else if (Month == 4 || Month == 6 || Month == 9 || Month == 11)
{
    days = 30;
}
else
{
    //التحقق ما اذا كانت السنة كبيسة

    if ((Year % 4 == 0 && Year % 100 != 0) || (Year % 400 == 0))
        days = 29; // سنة كبيسة
    else
        days = 28; // سنة عادية
}

Console.WriteLine($"Month {Month} in year {Year} has {days} days.");


