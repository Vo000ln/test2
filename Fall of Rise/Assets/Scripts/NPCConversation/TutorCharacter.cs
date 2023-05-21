using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class TutorCharacter : MonoBehaviour
{
    public bool zone = false; //����, ����� �����, ����� �������� ������� � �������
    public NPCConversation myConversation;  //�������
    public GameObject cloud;
    public NPCConversation myConversation2;
    //public NPCConversation myConversation3;
    public GameObject cloud_krossword;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "PlayerMen" || other.tag == "PlayerWoman")
        {
            zone = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        zone = false;
    }

    void Start()
    {
        DataClass.choose_conversation_tutor = 1;
    }

    private void Update()
    {
        if (DataClass.off_cloud_krossword)
        {
            cloud_krossword.SetActive(false);
        }
        if (zone && Input.GetKeyDown(KeyCode.E) && DataClass.move == 0)
        {
            cloud.SetActive(false);
            //1 ������
            //���������������, �������� ������ +1 � =0 � ���������� � ������ ����, ����� ������������ ������ ����� ���� ������ ����� ��������� �� ��������
            //if (DataClass.choose_conversation_tutor == 1 || DataClass.choose_conversation_tutor == 2) //1, ���� �� �������� � ���� �����; 2, ���� �������� �� ����� StudentHostel
            if (DataClass.choose_conversation_tutor == 1)
            {
                ConversationManager.Instance.StartConversation(myConversation);
                //DataClass.choose_conversation_tutor = 0;
                DataClass.choose_conversation_O3 = 1;
                DataClass.choose_conversation_O2 = 1;
                DataClass.choose_conversation_O1 = 1;
            }
            if (DataClass.choose_conversation_tutor == 2)
            {
                ConversationManager.Instance.StartConversation(myConversation2);
                //�������, ���� �����
            }
        }
    }
}
