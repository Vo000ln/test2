using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TransitionToHostelForRun : MonoBehaviour
{
    public bool once = true;
    public GameObject AfterMeeting;

    public Image genderIcon;
    public Sprite maleIcon;
    public Sprite femaleIcon;

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
        once = false; //����� ���� ��� �������� ������
        DataClass.endDialogue = 0; //�������� ��������� ��� ��������� ����
        if (DataClass.gender == "M")
            genderIcon.sprite = maleIcon;
        else
            genderIcon.sprite = femaleIcon;
        AfterMeeting.SetActive(true);
        yield return new WaitForSecondsRealtime(9);
        if (DataClass.gender == "M")
            Application.LoadLevel("HostelForRun"); //��������� �� �����
        else
            Application.LoadLevel("WomanHostelForRun");
    }
}
