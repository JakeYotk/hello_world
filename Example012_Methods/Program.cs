// Вид 1
void Method1()
{
    Console.WriteLine("Автор ...");
}
// Например для указания авторства в конце каждой программы.

// Method1();



// Вид 2
void Method2(string msg)
{
    Console.WriteLine(msg);
}
// Method2("Текст сообщения"); 
// При вызове метода мы в скобках пишем значение
// которое хотим придать аргументу указанному в методе.



// Именованные аргументы, мы вручную указываем программе 
// какое значение к какому аргументу относится.
void Method21(string msg, int count) // в скобках после имени метода мы указываем АРГУМЕНТЫ(arg/args), (переменные и т.п.)
                                    // которым в последствии, при вызове метода, будет придано какое-то значение. 
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
// Method21(msg: "Текст", count: 4);

// Вид 3

int Method3()
{
    return DateTime.Now.Year;
}

// int year = Method3();
// Console.WriteLine(year);



// Вид 4

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = string.Empty;

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string res = Method4(10, "z" + " ");
// Console.WriteLine(res);


// Тот же метод №4 только с циклом for, в не while.

string Method41(int count, string text)
{
    string result = string.Empty;
    for( int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method41(10, "z" + " ");
Console.WriteLine(res);