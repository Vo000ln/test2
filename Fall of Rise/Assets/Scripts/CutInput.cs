using System.Collections;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.SceneManagement;
public class CutInput : MonoBehaviour
{
    [SerializeField]
    public TMP_InputField input;
    //����� �����
    public int maxLen;
    
    //�������, ������� ����� �������, ����� ����
    private readonly char[] Symbols = new char[58 * 2] { '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�',
                                                     'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
                                                      '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�',
                                                     'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};
    private string txt;

    //����� ��� ���������� ���� �����
    public void update()
    {
        bool fl = false;
        //�������� ��������� ������� �� ������� �����
        if (input.text.Length > 0)
        {
            txt = input.text;
            char tmp = txt[txt.Length - 1];
            Debug.Log("123");
            foreach (char symb in Symbols)
            {
                if (tmp == symb)
                {
                    fl = true;
                    break;
                }

            }
            if (input.text.Length >= maxLen)
                fl = false;
            if (!fl)
            {
                input.text = input.text.Substring(0, input.text.Length - 1);
            }
        }
        DataClass.name = input.text;
}
    
}
