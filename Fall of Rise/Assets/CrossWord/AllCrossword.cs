using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class AllCrossword
{
    //������ �� ���������
    public static String[] all_words = new String[19] { "����������", "����", "�������", "���������������", "�������", "�����������", "�����",
                                                         "����", "����������", "����������������", "�������������", "�������������", "��������������", "����������", "�����������", "����", "���������",
                                                         "������", "������������"};
    //������ � ������� ����������
    public static String[] already_write = new String[19] { "", "", "", "", "", "", "",
                                                         "", "", "", "", "", "", "", "", "", "", "", ""};
    public static bool[] guessed = new bool[19] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
}
