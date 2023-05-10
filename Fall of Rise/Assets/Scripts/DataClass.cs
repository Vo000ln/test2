using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DataClass
{
    //name - имя персонажа
    public static string scene =  "";
    //name - название сцены
    public static string name;
    //intellect - уровень интеллекта
    public static int intellect = 0;
    //brave - смелость
    public static int brave = 0;
    //relation - отношение с мамой
    public static int relation = 0;
    //пол персонажа - для вставки подходящей картинки в диалогах 
    public static string gender = "M";
    //конец диалога на сцене с комнатой
    public static int endDialogue = 0;

    //диалоги
    //choose_conversation_mommy - диалог с мамой
    public static int choose_conversation_mommy = 1; //начинаем с 1, чтобы первый диалог точно активировался
    //choose_conversation_tutor - диалог с куратором
    public static int choose_conversation_tutor = 1; //начинаем с 0, идет +1 после активации вставки с заданием пройти в корпус
    //choose_conversation_O2 - диалог с Васькой
    public static int choose_conversation_O2 = 0; //начинаем с 0, идет +1 после разговора с кураторшей
    //choose_conversation_O2 - диалог с Владом
    public static int choose_conversation_O1 = 0;
    //choose_conversation_O3 - диалог с Ириной
    public static int choose_conversation_O3 = 0;
}
