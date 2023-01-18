int number = 967;
string str = number.ToString();

if(str.Length > 2)
{
Console.WriteLine(str[2]); 
}
else
{
    Console.WriteLine("введите 3 числа");
}