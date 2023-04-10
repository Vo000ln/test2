using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DataClass
{
    //name - имя персонажа
    public static string scene =  "";
    //id - название сцены
    public static string name;
    //intellect - уровень интеллекта
    public static int intellect = 0;
    //brave - смелость
    public static int brave = 0;
    //rel_mother - отношение с мамой
    public static int rel_mother = 0;

    //диалоги
    //choose_conversation_mommy - диалог с мамой
    public static int choose_conversation_mommy = 1; //начинаем с 1, чтобы первый диалог точно активировался
}
