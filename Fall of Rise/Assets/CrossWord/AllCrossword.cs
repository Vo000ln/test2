using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class AllCrossword
{
    //������ �� ���������
    public static String[] all_words = new String[12] { "������", "�������", "��������", "��������", "�����������", "���������", "��������",
                                                         "����������", "�����", "�����", "������", "�������"};
    //������ � ������� ����������
    public static String[] already_write = new String[12] { "", "", "", "", "", "", "",
                                                         "", "", "", "", ""};
    public static bool[] guessed = new bool[12] { false, false, false, false, false, false, false, false, false, false, false, false };
}
