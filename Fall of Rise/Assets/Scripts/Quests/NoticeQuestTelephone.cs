using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoticeQuestTelephone : MonoBehaviour
{
    public GameObject notice;
    public GameObject end_dialogue;

    void Start()
    {
        
    }

    void Update()
    {
        //1 ��� ������������ ��������
        if (DataClass.endDialogue == 1)
        {
            notice.SetActive(true); //������������� �����������
            DataClass.endDialogue = 0;
            GameObject.Find("EndDialogue").GetComponent<NoticeQuestTelephone>().enabled = false; //����� �� ����������� ������� ����������� ���������
        }
    }


}
