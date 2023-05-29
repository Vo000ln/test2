using System.Collections;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class  CheckInput : MonoBehaviour
{
    //fadeout
    public GameObject canvas_end;
    //канвас с кроссоврдом
    public GameObject defaultt;
    //при попытку еще раз ввести слово
    public GameObject notright;
    //при отгадывании кроссворда
    public GameObject uraaa;
    //поле ввода
    [SerializeField]
    public TMP_InputField input;
    //длина слова
    private int maxLen;
    //номер слова в кросворде
    private int number;
    //private readonly KeyCode[] keyCodes = new KeyCode[32] {KeyCode.Z, KeyCode.X, KeyCode.C, KeyCode.V, KeyCode.B, KeyCode.N, KeyCode.M, KeyCode.A, KeyCode.S, KeyCode.D,
    //                                                       KeyCode.F, KeyCode.G, KeyCode.H, KeyCode.J, KeyCode.K, KeyCode.L, KeyCode.Q, KeyCode.W, KeyCode.E, KeyCode.R,
    //                                                       KeyCode.T, KeyCode.Y, KeyCode.U, KeyCode.I, KeyCode.O, KeyCode.P, KeyCode.Comma, KeyCode.Period, KeyCode.Semicolon,
    //                                                       KeyCode.Quote, KeyCode.LeftBracket, KeyCode.RightBracket
    //};
    //символы, которые можно вводить, кроме цифр
    private readonly char[] Symbols = new char[32] {'я', 'ч', 'с', 'м', 'и', 'т', 'ь', 'б', 'ю', 'ф', 'ы', 'в', 'а', 'п', 'р', 'о', 'л', 'д', 'ж', 'э', 'й', 'ц', 'у','к', 'е', 'н', 'г', 'ш', 'щ', 'з', 'х', 'ъ'};
    private string txt;

    public GameObject canvas_fadein;

    void Start()
    {
        StartCoroutine(Coroutine_Disable());
        //макс слов это 7
        int brave = (int)(DataClass.brave / 10f * 5f) + (((DataClass.brave / 10f * 5f) - (int)((DataClass.brave / 10f * 5f))) >= 0.5 ? 1 : 0);
        //макс букв 21
        int intel = DataClass.intellect;
        //сначала заполняем слова, потом буквы
        System.Random random = new System.Random();
        //чтоб заполнить сколько надо
        int[] arr_rand = new int[19] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18};
        int count_hor = 0;
        for(int i = 0;i < brave; ++i)
        {
            //выбираем ранд слово
            
            int now_fill = arr_rand[random.Next(0, arr_rand.Length)];
            //Debug.Log(now_fill);
            if ((now_fill == 14 || now_fill == 16 || now_fill == 11 || now_fill == 13 || now_fill == 5 || now_fill == 8 || now_fill == 0 || now_fill == 6 || now_fill == 4 || now_fill == 9 || now_fill == 17))
                count_hor++;      
            if (arr_rand.Length > 0)
            {
                List<int> tmp = new List<int>(arr_rand);
                tmp.Remove(now_fill);
                arr_rand = tmp.ToArray();
            }
            string s = "";
            for (int j = 0; j < arr_rand.Length; ++j)
            {
                s += arr_rand[j].ToString() + " ";
            }
            //Debug.Log(s);
            GameObject.Find((now_fill + 1).ToString()).GetComponent<TMP_InputField>().SetTextWithoutNotify(AllCrossword.all_words[now_fill]);
            AllCrossword.guessed[now_fill] = true;
        }
        if (count_hor + intel > 11)
            intel = 11 - count_hor;
        for(int i = 0;i < intel; ++i)
        {
            int now_fill = 0;
            while(true){
                now_fill = arr_rand[random.Next(0, arr_rand.Length)];
                if ((now_fill == 14 || now_fill == 16 || now_fill == 11 || now_fill == 13 || now_fill == 5 || now_fill == 8 || now_fill == 0 || now_fill == 6 || now_fill == 4 || now_fill == 9 || now_fill == 17))
                    break;
            }
            //выбираем буквы
            int max_len = maxLen = AllCrossword.all_words[now_fill].Length;
            //номер первой буквы
            int first = random.Next(0, maxLen);
            //номер второй буквы
            int second = first;
            while(second == first)
            {
                second = random.Next(0, maxLen);
            }
            //номер третьей буквы
            int third = second;
            while (third == first || third == second)
            {
                third = random.Next(0, maxLen);
            }
            string s = "";
            for(int j = 0;j < max_len; ++j)
            {
                if(j == first)
                {
                    s += AllCrossword.all_words[now_fill][j];
                }else if(j == second)
                {
                    s += AllCrossword.all_words[now_fill][j];
                }
                else if(j == third)
                {
                    s += AllCrossword.all_words[now_fill][j];
                }
                else
                {
                   s += " ";
                }
            }
            GameObject.Find((now_fill + 1).ToString()).GetComponent<TMP_InputField>().SetTextWithoutNotify(s);
            //Debug.Log(s);
            if (arr_rand.Length > 0)
            {
                List<int> tmp = new List<int>(arr_rand);
                tmp.Remove(now_fill);
                arr_rand = tmp.ToArray();
            }
        }
    }
    //метод для обновления поля ввода
    public void update()
    {
        bool fl = false;
        //проверка введеного символа на русскую букву
        if (input.text.Length > 0)
        {
            //проверка то что первая цифра
            if (input.text.Length == 1)
            {
                char digit = input.text[0];
                if (digit >= '1' && digit <= '9')
                {
                    number = digit - '0' - 1;
                    maxLen = AllCrossword.all_words[number].Length + 1;
                }
                else
                {
                    input.text = input.text.Substring(0, input.text.Length - 1);
                }
            }
            else if(input.text.Length <= maxLen)
            {
                //проервка что введена русская буква после числа
                txt = input.text;
                char tmp = txt[txt.Length - 1];
                foreach (char symb in Symbols)
                {
                    if (tmp == symb)
                    {
                        fl = true;
                        //проверка на то что слово уже было угадано   
                        if(AllCrossword.guessed[number])
                        {
                            input.text = input.text.Substring(0, input.text.Length - 1);
                            input.DeactivateInputField();
                            //уведомление о том, что слово введено 
                            notright.SetActive(true);
                            StartCoroutine(Coroutine_guessed());  
                            return;
                        }
                        break;
                    }

                }
                //если номер двузначный(10,11,12)
                if (input.text.Length == 2) {
                    if (txt[0] == '1' && (txt[1] >= '0' && txt[1] <= '9'))
                    {
                        fl = true;
                        number = int.Parse(txt) - 1;
                        maxLen = AllCrossword.all_words[number].Length + 2;
                    }    
                }
                //если буква не русская то удаляем последний символ
                if (!fl && input.text.Length > 0)
                    input.text = input.text.Substring(0, input.text.Length - 1);
                AllCrossword.already_write[number] = input.text;
                //если слово угадали, то запускаем корутин для вставки слова
                if (AllCrossword.all_words[number].Equals(input.text.Substring((number + 1).ToString().Length, input.text.Length - (number + 1).ToString().Length)))
                {
                    input.DeactivateInputField();
                    AllCrossword.guessed[number] = true;
                    //установка слова в кроссворд
                    GameObject.Find((number + 1).ToString()).GetComponent<TMP_InputField>().SetTextWithoutNotify(input.text.Substring((number + 1).ToString().Length, input.text.Length - (number + 1).ToString().Length));
                    if (Array.TrueForAll(AllCrossword.guessed, value => { return value; }))
                    {
                        //если угадали все, запускаем корутин с переходом на другую сцену
                        //uraaa.SetActive(true);
                        StartCoroutine(Coroutine_End());
                        return;
                    }
                    StartCoroutine(Coroutine_Fill());
                }
            }
            //если вышли за границу удаляем последний введенный символ 
            else
            {
                input.text = input.text.Substring(0, input.text.Length - 1);
                
            }
        }
        //проврека что все слова угаданы
        
    }
    //для записи слова в кроссворд
    IEnumerator Coroutine_Fill()
    {
        yield return new WaitForSecondsRealtime(1);
        input.ActivateInputField();
        input.SetTextWithoutNotify("");
        number = 0;
        maxLen = 0;
    }
    //для информирования, что слово уже угадано
    IEnumerator Coroutine_guessed()
    {
        yield return new WaitForSecondsRealtime(4);
        notright.SetActive(false);
        input.ActivateInputField();
        input.SetTextWithoutNotify("");
        number = 0;
        maxLen = 0;
    }
    //запускается, когда все слова угаданы, переходим на предыдущую сцену
    IEnumerator Coroutine_End()
    {
        //yield return new WaitForSecondsRealtime(10);
        input.ActivateInputField();
        input.SetTextWithoutNotify("");
        number = 0;
        maxLen = 0;
        //DataClass.brave += 5;
        if (DataClass.gender == "M")
            DataClass.final_anim = 1; //хорошая концовка муж.
        else
            DataClass.final_anim = 2; //хорошая концовка жен.
        canvas_end.SetActive(true);
        yield return new WaitForSecondsRealtime(2.9f);
        SceneManager.LoadScene("Final");
    }

    IEnumerator Coroutine_Disable()
    {
        yield return new WaitForSecondsRealtime(1);
        canvas_fadein.SetActive(false);
    }
}
