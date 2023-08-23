﻿/* В данной лекции изучаются 4 вида функций:
1. не принимает и не возвращает аргумент;
2. не принимает аргумент, но возвращает;
3. принимает аргумент, но не возвращает;
4. принимает и возвращает аргумент.*/

//Вид 1 - ничего не возвращают и не принимают

/*
void Method1()
{
    Console.WriteLine("Author.....");
}
Method1(); // вызов метода
*/

//Вид 2 - ничего не возвращают, но принимают аргумент

/*
метод принимает 1 аргумент 
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Текст сообщения");
*/

/*
void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
} 
// ниже представлен способ именной печати аргументов метода
// не важно в каком порядке отражены аргументы при вызове метода
//Method21(count: 4, msg: "Текст сообщения");  
// ниже неименованный способ вывода на печать
Method21("Текст сообщения", 88);
*/

//Вид 3 - ничего не принимают в качестве аргумента, но возвращают
//особенность заключается в том, что при описании метода неободимо указать ожидаемый к возвращению тип данных
//также в обязательном порядке используется return для возвращения результата функции

/*
int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3(); //присваиваем переменной результат работы функции
Console.WriteLine(year);
*/

//Вид 4 - принимает аргументы и возвращает результат

/*
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "qwerty");
Console.WriteLine(res);
/*