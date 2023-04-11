using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitFromComputer : MonoBehaviour
{
    public void ExitScene()
    {
        DataClass.choose_conversation_mommy = 2; //активируем диалог после выбора "посмотреть самому"
        SceneManager.LoadScene("HomePlayer");
    }
}
