void Method1()
{
    Console.WriteLine("Author ...");
}
// Method1();

// Type2

void Method2(string msg)
{
    Console.WriteLine(msg);
}
// Method2("msg text");


void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
         Console.WriteLine(msg);
         i++;
    }
}
// Method21(count: 5, msg: "new text");
// Method21(msg: "new text", count: 5); we can change arguments order 

int Method3()
{
    return DateTime.Now.Year;
} 
int year = Method3();
// Console.WriteLine(year);


string Method4 (int count, string a)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + a;
        i++;
    }
    return result;
}
string res = Method4(14, "error");
Console.WriteLine(res);
