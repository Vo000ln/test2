using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class AllCrossword
{
    //ответы на кроссворд
    public static String[] all_words = new String[19] { "экспонента", "коши", "главная", "ассоциативность", "эпсилон", "вырожденная", "базис",
                                                         "один", "однородная", "дифференциальное", "первообразная", "бесконечность", "транзитивность", "милиционер", "комплексных", "ноль", "плоскость",
                                                         "гаусса", "определитель"};
    //массив с текущим написанным
    public static String[] already_write = new String[19] { "", "", "", "", "", "", "",
                                                         "", "", "", "", "", "", "", "", "", "", "", ""};
    public static bool[] guessed = new bool[19] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
}
