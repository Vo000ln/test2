using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitFromComputer : MonoBehaviour
{
    public void ExitScene()
    {
        DataClass.choose_conversation_mommy = 2; //���������� ������ ����� ������ "���������� ������"
        if (DataClass.gender == "M")
            SceneManager.LoadScene("HomePlayer");
        else
            SceneManager.LoadScene("WomanHomePlayer");
    }
}
