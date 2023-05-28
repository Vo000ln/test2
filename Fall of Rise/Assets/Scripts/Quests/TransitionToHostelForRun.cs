using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionToHostelForRun : MonoBehaviour
{
    public bool once = true;
    public GameObject AfterMeeting;

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
        AfterMeeting.SetActive(true);
        yield return new WaitForSecondsRealtime(9);
        if (DataClass.gender == "M")
            Application.LoadLevel("HostelForRun"); //��������� �� �����
        else
            Application.LoadLevel("WomanHostelForRun");
    }
}
