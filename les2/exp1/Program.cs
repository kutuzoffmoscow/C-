void n (int collection)
{
    string s = collection.ToString();
    if(s.Length >= 2)
    {
        Console.WriteLine(s[1]);
    }
    else
    {
        Console.WriteLine("ввидите 3хзначное число");
    }
    
}

int collection = 562;
n (collection);