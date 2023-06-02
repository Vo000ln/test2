using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TransitionToHostelForRun : MonoBehaviour
{
    public bool once = true;
    public GameObject AfterMeeting;
    public GameObject AfterMeetingGirl;

    //public Image genderIcon;
    //public Sprite maleIcon;
    //public Sprite femaleIcon;

    void Start()
    {

    }

    void Update()
    {
        if (DataClass.endDialogue == 5 && once)
            StartCoroutine(Coroutine());
    }

    IEnumerator Coroutine()
    {
        once = false; //чтобы один раз сработал канвас
        DataClass.endDialogue = 0; //обнуляем энддиалог для следующих сцен
        if (DataClass.gender == "M")
            AfterMeeting.SetActive(true);
        else
            AfterMeetingGirl.SetActive(true);
        yield return new WaitForSecondsRealtime(9);
        if (DataClass.gender == "M")
            Application.LoadLevel("HostelForRun"); //переходим на сцену
        else
            Application.LoadLevel("WomanHostelForRun");
    }
}
