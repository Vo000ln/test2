using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class AllCrossword
{
    //ответы на кроссворд
    public static String[] all_words = new String[12] { "корень", "степень", "логарифм", "абсцисса", "производная", "уравнение", "интеграл",
                                                         "переменная", "хорда", "банан", "ньютон", "экзамен"};
    //массив с текущим написанным
    public static String[] already_write = new String[12] { "", "", "", "", "", "", "",
                                                         "", "", "", "", ""};
    public static bool[] guessed = new bool[12] { false, false, false, false, false, false, false, false, false, false, false, false };
}
