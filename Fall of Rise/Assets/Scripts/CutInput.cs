using System.Collections;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.SceneManagement;
public class CutInput : MonoBehaviour
{
    [SerializeField]
    public TMP_InputField input;
    //длина слова
    public int maxLen;
    
    //символы, которые можно вводить, кроме цифр
    private readonly char[] Symbols = new char[58 * 2] { 'я', 'ч', 'с', 'м', 'и', 'т', 'ь', 'б', 'ю', 'ф', 'ы', 'в', 'а', 'п', 'р', 'о', 'л', 'д', 'ж', 'э', 'й', 'ц', 'у', 'к', 'е', 'н', 'г', 'ш', 'щ', 'з', 'х', 'ъ',
                                                     'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
                                                      'Я', 'Ч', 'С', 'М', 'И', 'Т', 'Ь', 'Б', 'Ю', 'Ф', 'Ы', 'В', 'А', 'П', 'Р', 'О', 'Л', 'Д', 'Ж', 'Э', 'Й', 'Ц', 'У', 'К', 'Е', 'Н', 'Г', 'Ш', 'Щ', 'З', 'Х', 'Ъ',
                                                     'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};
    private string txt;

    //метод для обновления поля ввода
    public void update()
    {
        bool fl = false;
        //проверка введеного символа на русскую букву
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
