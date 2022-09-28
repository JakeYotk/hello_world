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

string Method4(int count, string text)
{
    int i = 0;
    string result = string.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
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
// string res = Method41(10, "z" + " ");
// Console.WriteLine(res);


// Цикл в цикле

// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <=10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i*j}");
//     }
//     Console.WriteLine();
// }


// РАБОТА С ТЕКСТОМ
// Дан текст. В тесте нужно все пробелы заменить черточками,
// Малкенькие буквы "к" заменить большими "К",
// большие "С" заменить маленькими "с".

// ЯСНА ЛИ ЗАДАЧА?

string text = "- Я думаю, - сказал князь, улыбаясь, - что,"
             + "ежели бы вас послали вместо нашего милого Винценгероде"
             + "вы бы приступом взяли согласие прусского короля. "
             + "Вы так красноречивы. Вы дадите мне чаю?";


// string s = "qwerty"
//             012345
// s[3] = r


string Replace(string text, char oldValue, char newValue)
{
    string result = string.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result+ $"{text[i]}";
    }

    return result;
}

// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();

// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);
// Console.WriteLine();

// newText = Replace(newText, 'С', 'с');
// Console.WriteLine(newText);


int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };
void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1 ; i++)
    {
        int minPosition = i;

        for(int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j; // для написания массива от max к min нужно просто поменять знак < на >,
                                                               // и для наглядности переименовать переменную на maxPosition.
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}


PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);