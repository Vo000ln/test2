using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DataClass
{
    //name - имя персонажа
    public static string scene =  "";
    //name - название сцены
    public static string name = "";//УБРАААААААААААААААААААААААААААТЬ!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
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
    //запрет на движение
    public static int move = 0;
    //когда двигаешься move = 0
    //когда недвигаешься move = 1
    //диалоги
    //choose_conversation_mommy - диалог с мамой
    public static int choose_conversation_mommy = 1; //начинаем с 1, чтобы первый диалог точно активировался
    //choose_conversation_tutor - диалог с куратором
    public static int choose_conversation_tutor = 0; //начинаем с 0, идет +1 после активации вставки с заданием пройти в корпус
    //choose_conversation_O2 - диалог с Васькой
    public static int choose_conversation_O2 = 0; //начинаем с 0, идет +1 после разговора с кураторшей
    //choose_conversation_O2 - диалог с Владом
    public static int choose_conversation_O1 = 0;
    //choose_conversation_O3 - диалог с Ириной
    public static int choose_conversation_O3 = 0;
    //choose_conversation_igor - диалог с Игорем
    public static int choose_conversation_igor = 0;

    //облака
    //на сцене HomePlayer
    public static bool off_cloud1 = false;
    //на сцене 14Frame
    public static bool off_cloud_krossword = false;
    //на сцене HostelForRun
    public static bool off_cloud_hfr = false;
    public static bool off_cloud_igor = false;
    public static bool on_bed = false;
}
